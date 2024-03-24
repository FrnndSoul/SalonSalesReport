using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesreport.UserControls
{
    public partial class ProductsSales : UserControl
    {
        public ProductsSales()
        {
            InitializeComponent();
            ProductSalesDGV.DataSource = SalesClass.LoadProductSales();
        }

        private void ShowVoided_CheckedChanged(object sender, EventArgs e)
        {
            string filterExpression;
            if (ShowVoided.Checked)
            {
                filterExpression = "";
            }
            else
            {
                filterExpression = "IsVoided = 'No'";
            }
            ((DataTable)ProductSalesDGV.DataSource).DefaultView.RowFilter = filterExpression;
        }
    }
}

