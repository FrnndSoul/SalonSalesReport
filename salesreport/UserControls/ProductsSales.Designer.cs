namespace salesreport.UserControls
{
    partial class ProductsSales
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VoidChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ProductSalesDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ShowVoided = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VoidChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSalesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // VoidChart
            // 
            this.VoidChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.VoidChart.BorderlineColor = System.Drawing.Color.Black;
            this.VoidChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.VoidChart.Location = new System.Drawing.Point(725, 422);
            this.VoidChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VoidChart.Name = "VoidChart";
            this.VoidChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.VoidChart.Size = new System.Drawing.Size(585, 418);
            this.VoidChart.TabIndex = 8;
            this.VoidChart.Text = "chart1";
            // 
            // SalesChart
            // 
            this.SalesChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SalesChart.BorderlineColor = System.Drawing.Color.Black;
            this.SalesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.SalesChart.Location = new System.Drawing.Point(135, 422);
            this.SalesChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesChart.Name = "SalesChart";
            this.SalesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.SalesChart.Size = new System.Drawing.Size(585, 418);
            this.SalesChart.TabIndex = 7;
            this.SalesChart.Text = "chart1";
            // 
            // ProductSalesDGV
            // 
            this.ProductSalesDGV.AllowUserToAddRows = false;
            this.ProductSalesDGV.AllowUserToDeleteRows = false;
            this.ProductSalesDGV.AllowUserToResizeColumns = false;
            this.ProductSalesDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ProductSalesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ProductSalesDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductSalesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProductSalesDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductSalesDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProductSalesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductSalesDGV.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ProductSalesDGV.Location = new System.Drawing.Point(135, 97);
            this.ProductSalesDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductSalesDGV.MultiSelect = false;
            this.ProductSalesDGV.Name = "ProductSalesDGV";
            this.ProductSalesDGV.ReadOnly = true;
            this.ProductSalesDGV.RowHeadersVisible = false;
            this.ProductSalesDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProductSalesDGV.Size = new System.Drawing.Size(1175, 315);
            this.ProductSalesDGV.TabIndex = 6;
            this.ProductSalesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductSalesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductSalesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProductSalesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProductSalesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductSalesDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductSalesDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductSalesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProductSalesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductSalesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSalesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductSalesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ProductSalesDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.ProductSalesDGV.ThemeStyle.ReadOnly = true;
            this.ProductSalesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProductSalesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductSalesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSalesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProductSalesDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ProductSalesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProductSalesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ShowVoided
            // 
            this.ShowVoided.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowVoided.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowVoided.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ShowVoided.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ShowVoided.Location = new System.Drawing.Point(1226, 43);
            this.ShowVoided.Name = "ShowVoided";
            this.ShowVoided.Size = new System.Drawing.Size(84, 42);
            this.ShowVoided.TabIndex = 9;
            this.ShowVoided.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowVoided.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowVoided.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ShowVoided.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.ShowVoided.CheckedChanged += new System.EventHandler(this.ShowVoided_CheckedChanged);
            // 
            // searchBox
            // 
            this.searchBox.Animated = true;
            this.searchBox.AutoRoundedCorners = true;
            this.searchBox.BorderColor = System.Drawing.Color.Black;
            this.searchBox.BorderRadius = 20;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.searchBox.ForeColor = System.Drawing.Color.Black;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Location = new System.Drawing.Point(135, 43);
            this.searchBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "Search";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(564, 42);
            this.searchBox.TabIndex = 10;
            this.searchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Chinacat", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(828, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 42);
            this.label2.TabIndex = 11;
            this.label2.Text = "Toggle Voided Orders:";
            // 
            // ProductsSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.ShowVoided);
            this.Controls.Add(this.VoidChart);
            this.Controls.Add(this.SalesChart);
            this.Controls.Add(this.ProductSalesDGV);
            this.Name = "ProductsSales";
            this.Size = new System.Drawing.Size(1445, 870);
            ((System.ComponentModel.ISupportInitialize)(this.VoidChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSalesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart VoidChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesChart;
        public Guna.UI2.WinForms.Guna2DataGridView ProductSalesDGV;
        private Guna.UI2.WinForms.Guna2ToggleSwitch ShowVoided;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private System.Windows.Forms.Label label2;
    }
}
