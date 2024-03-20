using MySql.Data.MySqlClient;
using Mysqlx.Expect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace salesreport.UserControls
{
    public partial class EmployeePerformance : UserControl
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);
        public static DataTable dataSource;
        public static string ServiceTypeFilter;

        public EmployeePerformance()
        {
            InitializeComponent();
            GetServiceTypeData(TypeFLP);
            EmployeeDGV.DataSource = SalesClass.LoadEmployeeDGV(null);
            LoadCharts();
            RangeFilter.MaxDate = DateTime.Now;
            RangeFilter.MinDate = DateTime.Now.AddYears(-2);
            RangeFilter.Format = DateTimePickerFormat.Custom;
            RangeFilter.CustomFormat = "dd/MM/yyyy";
        }

        public void LoadCharts()
        {
            // Sales Chart
            Dictionary<string, decimal> salesByEmployee = new Dictionary<string, decimal>();

            foreach (DataGridViewRow row in EmployeeDGV.Rows)
            {
                string employeeName = row.Cells["Name"].Value?.ToString();
                string[] nameParts = employeeName.Split(' ');
                string firstName = nameParts[0]; 
                string salesValue = row.Cells["Sales"].Value?.ToString();

                decimal sales;
                if (decimal.TryParse(salesValue, out sales))
                {
                    if (salesByEmployee.ContainsKey(firstName))
                    {
                        salesByEmployee[firstName] += sales;
                    }
                    else
                    {
                        salesByEmployee.Add(firstName, sales);
                    }
                }
            }

            SalesChart.Series.Clear();

            Series salesSeries = new Series("Sales by Employee");

            foreach (var item in salesByEmployee)
            {
                salesSeries.Points.AddXY(item.Key, item.Value);
            }

            SalesChart.Series.Add(salesSeries);

            if (SalesChart.ChartAreas.Count == 0)
            {
                SalesChart.ChartAreas.Add(new ChartArea());
            }

            SalesChart.ChartAreas[0].AxisX.Title = "Employee Names";
            SalesChart.ChartAreas[0].AxisY.Title = "Total Sales";

            // Ratings Chart
            Dictionary<string, decimal> ratesByEmployee = new Dictionary<string, decimal>();

            foreach (DataGridViewRow row in EmployeeDGV.Rows)
            {
                string employeeName = row.Cells["Name"].Value?.ToString();
                string[] nameParts = employeeName.Split(' '); 
                string firstName = nameParts[0]; 
                string ratingsValue = row.Cells["Rating"].Value?.ToString(); 

                decimal ratings;
                if (decimal.TryParse(ratingsValue, out ratings))
                {
                    if (ratesByEmployee.ContainsKey(firstName))
                    {
                        ratesByEmployee[firstName] += ratings;
                    }
                    else
                    {
                        ratesByEmployee.Add(firstName, ratings);
                    }
                }
            }

            RatingsChart.Series.Clear();

            Series ratingsSeries = new Series("Ratings by Employee");

            foreach (var item in ratesByEmployee)
            {
                ratingsSeries.Points.AddXY(item.Key, item.Value);
            }

            RatingsChart.Series.Add(ratingsSeries);

            if (RatingsChart.ChartAreas.Count == 0)
            {
                RatingsChart.ChartAreas.Add(new ChartArea());
            }

            RatingsChart.ChartAreas[0].AxisX.Title = "Employee Names";
            RatingsChart.ChartAreas[0].AxisY.Title = "Average Rating";

            ChartFontRefresh();
        }

        public void GetServiceTypeData(FlowLayoutPanel serviceTypeFL)
        {
            using (var conn = new MySqlConnection(mysqlcon))
            {
                conn.Open();
                string query = "SELECT ServiceTypeName, ServiceTypeImage, ServiceID FROM service_type";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (DbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageBytes = (byte[])reader["ServiceTypeImage"];

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image servicetypeImage = Image.FromStream(ms);

                                Panel panel = new Panel
                                {
                                    Width = 250,
                                    Height = 94,
                                    Margin = new Padding(3),
                                    Tag = reader["ServiceID"].ToString(),
                                    BackColor = Color.FromArgb(255, 192, 255),
                                    BorderStyle = BorderStyle.FixedSingle,
                                };

                                Label labelTitle = new Label
                                {
                                    Text = reader["ServiceTypeName"].ToString() + "\nEmployees",
                                    ForeColor = Color.Black,
                                    Size = new Size(250, 94),
                                    Location = new Point(0, 0),
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Font = new Font("Stanberry", 20, FontStyle.Regular),
                                    Tag = reader["ServiceID"].ToString()
                                };

                                void clickHandler(object sender, EventArgs e)
                                {
                                    string labelText = labelTitle.Text;
                                    string[] parts = labelText.Split('\n');
                                    string filter = parts[0];
                                    EmployeeDGV.DataSource = SalesClass.LoadEmployeeDGV(filter);
                                    LoadCharts();
                                }

                                panel.Click += clickHandler;
                                labelTitle.Click += clickHandler;
                                panel.Controls.Add(labelTitle);
                                serviceTypeFL.Controls.Add(panel);
                            }
                        }
                    }
                }
            }
        }

        private void LabelTitle_Click(object sender, EventArgs e)
        {
            EmployeeDGV.DataSource = SalesClass.LoadEmployeeDGV(null);
            LoadCharts();
        }

        public void ChartFontRefresh()
        {
            //Sales Chart
            if (SalesChart.Titles.Count > 0)
            {
                SalesChart.Titles[0].Font = new Font("Stanberry", 18, FontStyle.Bold);
            }

            if (SalesChart.ChartAreas.Count > 0)
            {
                SalesChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);
                SalesChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);

                SalesChart.ChartAreas[0].AxisX.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
                SalesChart.ChartAreas[0].AxisY.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
            }

            foreach (var series in RatingsChart.Series)
            {
                series.Font = new Font("Stanberry", 14, FontStyle.Regular);
            }

            //Ratings Chart
            if (RatingsChart.Titles.Count > 0)
            {
                RatingsChart.Titles[0].Font = new Font("Stanberry", 18, FontStyle.Bold);
            }

            if (RatingsChart.ChartAreas.Count > 0)
            {
                RatingsChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);
                RatingsChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Stanberry", 14, FontStyle.Regular);

                RatingsChart.ChartAreas[0].AxisX.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
                RatingsChart.ChartAreas[0].AxisY.TitleFont = new Font("Stanberry", 14, FontStyle.Bold);
            }

            foreach (var series in RatingsChart.Series)
            {
                series.Font = new Font("Stanberry", 14, FontStyle.Regular);
            }
        }

        private void DayFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)EmployeeDGV.DataSource;

                DateTime selectedDate = RangeFilter.Value.Date;

                DataTable filteredTable = dataTable.Clone();

                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime timeTaken;
                    if (DateTime.TryParseExact(row["Date"].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeTaken) && timeTaken.Date == selectedDate)
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                EmployeeDGV.DataSource = filteredTable;
                LoadCharts();

                NoFilter.Checked = false;
                WeeklyFilter.Checked = true;
                MonthlyFilter.Checked = true;
                RangeFilter.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NoFilter_Click(object sender, EventArgs e)
        {
            EmployeeDGV.DataSource = SalesClass.LoadEmployeeDGV(null);
            LoadCharts();

            DayFilter.Checked = false;
            WeeklyFilter.Checked = false;
            MonthlyFilter.Checked = false;
            RangeFilter.Enabled = true;
        }

        private void WeeklyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)EmployeeDGV.DataSource;

                DateTime selectedDate = RangeFilter.Value.Date;

                DateTime startOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                DataTable filteredTable = dataTable.Clone();

                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime timeTaken;
                    if (DateTime.TryParseExact(row["Date"].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeTaken))
                    {
                        // Extract the date part from timeTaken
                        DateTime datePart = timeTaken.Date;

                        // Check if the date falls within the start and end dates of the week
                        if (datePart >= startOfWeek && datePart <= endOfWeek)
                        {
                            filteredTable.ImportRow(row);
                        }
                    }
                }


                EmployeeDGV.DataSource = filteredTable;
                LoadCharts();

                DayFilter.Checked = true;
                NoFilter.Checked = false;
                MonthlyFilter.Checked = true;
                RangeFilter.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MonthlyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeDGV.DataSource == null)
                {
                    MessageBox.Show("No data to filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataTable = (DataTable)EmployeeDGV.DataSource;

                DateTime selectedDate = RangeFilter.Value.Date;

                DataTable filteredTable = dataTable.Clone();

                foreach (DataRow row in dataTable.Rows)
                {
                    DateTime timeTaken;
                    if (DateTime.TryParseExact(row["Date"].ToString(), "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out timeTaken))
                    {
                        if (timeTaken.Year == selectedDate.Year && timeTaken.Month == selectedDate.Month)
                        {
                            filteredTable.ImportRow(row);
                        }
                    }
                }

                EmployeeDGV.DataSource = filteredTable;
                LoadCharts();

                NoFilter.Checked = false;
                WeeklyFilter.Checked = true;
                DayFilter.Checked = true;
                RangeFilter.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filtering data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Get the text entered in the search box
            string searchText = searchBox.Text.ToLower();

            // If the search box is empty, clear the filter
            if (string.IsNullOrWhiteSpace(searchText))
            {
                ((DataTable)EmployeeDGV.DataSource).DefaultView.RowFilter = "";
                return;
            }

            // Build a filter expression to match any column containing the search text
            string filterExpression = $"Convert(RefID, 'System.String') LIKE '%{searchText}%' OR " +
                                       $"Convert([Date], 'System.String') LIKE '%{searchText}%' OR " +
                                       $"Convert(EmployeeID, 'System.String') LIKE '%{searchText}%' OR " +
                                       $"ServiceType LIKE '%{searchText}%' OR " +
                                       $"Name LIKE '%{searchText}%' OR " +
                                       $"Convert(Sales, 'System.String') LIKE '%{searchText}%' OR " +
                                       $"Convert(Rating, 'System.String') LIKE '%{searchText}%'";

            // Apply the filter to the DataGridView's DataSource
            ((DataTable)EmployeeDGV.DataSource).DefaultView.RowFilter = filterExpression;
        }
    }
}
