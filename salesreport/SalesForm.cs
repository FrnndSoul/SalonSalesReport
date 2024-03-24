using salesreport.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesreport
{

    public partial class SalesForm : UserControl
    {
        readonly EmployeePerformance employeePerformance = new EmployeePerformance();
        readonly ProductsSales productsSales = new ProductsSales();

        public SalesForm()
        {
            InitializeComponent();
        }

        private void ShowDefault()
        {
            foreach (Control control in this.Controls)
            {
                if(control is EmployeePerformance || control is ProductsSales)
                {
                    this.Controls.Remove(employeePerformance);
                    this.Controls.Remove(productsSales);
                }
            }
        }

        private async void EmployeeFilter_Click(object sender, EventArgs e)
        {
            ShowDefault();
            await Task.Delay(500);
            try
            {
                if (!this.Controls.Contains(employeePerformance))
                {
                    this.Controls.Add(employeePerformance);
                    employeePerformance.Location = new Point(374, 94);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }
        }

        private void GeneralBtn_Click(object sender, EventArgs e)
        {
            ShowDefault();
        }

        private async void ProductFilter_Click(object sender, EventArgs e)
        {
            ShowDefault();
            await Task.Delay(500);
            try
            {
                if (!this.Controls.Contains(productsSales))
                {
                    this.Controls.Add(productsSales);
                    productsSales.Location = new Point(374, 94);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }
        }
    }
}
