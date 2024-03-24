using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Crmf;
using salesreport.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesreport
{
    internal class SalesClass
    {
        public static string mysqlcon = "server=153.92.15.3;user=u139003143_salondatabase;database=u139003143_salondatabase;password=M0g~:^GqpI";
        public MySqlConnection connection = new MySqlConnection(mysqlcon);

        public static DataTable LoadEmployeeDGV(string filter)
        {
            string query = @"
                SELECT 
                    er.CustomerID AS RefID, 
                    DATE_FORMAT(er.TimeStart, '%m/%d/%Y') AS Date, 
                    se.AccountID AS EmployeeID, 
                    st.ServiceTypeName AS ServiceType, 
                    se.Name AS Name, 
                    SUM(sg.Amount) AS Sales, 
                    AVG(er.CustomerRating) AS Rating 
                FROM 
                    salon_employees se 
                INNER JOIN 
                    employee_records er ON er.AccountID = se.AccountID 
                INNER JOIN
                    customer_info ci ON ci.TransactionID = er.CustomerID 
                INNER JOIN 
                    service_group sg ON sg.ServiceGroupID = er.CustomerID
                INNER JOIN
                    service_type st ON st.ServiceID = se.ServiceID 
                WHERE 
                    se.AccountAccess = 'Staff' AND ci.PaymentStatus = 'PAID' ";

            if (!string.IsNullOrEmpty(filter))
            {
                query += "AND st.ServiceTypeName = @serviceType ";
            }

            query += @"GROUP BY 
            er.CustomerID, er.TimeStart, se.AccountID, se.Name, er.CustomerRating, st.ServiceTypeName;";

            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(mysqlcon))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    if (!string.IsNullOrEmpty(filter))
                    {
                        cmd.Parameters.AddWithValue("@serviceType", filter);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public static DataTable LoadProductSales()
        {
            string query = @"
                SELECT 
                    ProductGroupID AS `Reference Number`, 
                    ProductName AS `Product Name`, 
                    ProductID AS `Product ID`, 
                    Quantity, 
                    Amount, 
                    DATE_FORMAT(OrderDate, '%m/%d/%Y') AS Date,
                    IsVoided 
                FROM 
                    product_group";

            DataTable dataTable = new DataTable();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(mysqlcon))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.");
            }

            return dataTable;
        }
    }
}
