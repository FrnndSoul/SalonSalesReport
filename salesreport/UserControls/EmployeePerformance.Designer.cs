﻿using System.Drawing;

namespace salesreport.UserControls
{
    partial class EmployeePerformance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.TypeFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.LoadAllPanel = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.RatingsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RangeFilter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.NoFilter = new Guna.UI2.WinForms.Guna2Button();
            this.DayFilter = new Guna.UI2.WinForms.Guna2Button();
            this.WeeklyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.MonthlyFilter = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).BeginInit();
            this.TypeFLP.SuspendLayout();
            this.LoadAllPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDGV
            // 
            this.EmployeeDGV.AllowUserToAddRows = false;
            this.EmployeeDGV.AllowUserToDeleteRows = false;
            this.EmployeeDGV.AllowUserToResizeColumns = false;
            this.EmployeeDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.EmployeeDGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.EmployeeDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeDGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.EmployeeDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.EmployeeDGV.Location = new System.Drawing.Point(266, 56);
            this.EmployeeDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmployeeDGV.MultiSelect = false;
            this.EmployeeDGV.Name = "EmployeeDGV";
            this.EmployeeDGV.ReadOnly = true;
            this.EmployeeDGV.RowHeadersVisible = false;
            this.EmployeeDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmployeeDGV.Size = new System.Drawing.Size(1175, 381);
            this.EmployeeDGV.TabIndex = 0;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.EmployeeDGV.ThemeStyle.ReadOnly = true;
            this.EmployeeDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeDGV.ThemeStyle.RowsStyle.Height = 22;
            this.EmployeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SalesChart
            // 
            this.SalesChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SalesChart.BorderlineColor = System.Drawing.Color.Black;
            this.SalesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.SalesChart.Location = new System.Drawing.Point(266, 447);
            this.SalesChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalesChart.Name = "SalesChart";
            this.SalesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.SalesChart.Size = new System.Drawing.Size(585, 418);
            this.SalesChart.TabIndex = 1;
            this.SalesChart.Text = "chart1";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.BorderRadius = 20;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(935, 6);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(458, 42);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BorderThickness = 1;
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Image = global::salesreport.Properties.Resources.search;
            this.SearchBtn.Location = new System.Drawing.Point(1399, 6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SearchBtn.Size = new System.Drawing.Size(42, 42);
            this.SearchBtn.TabIndex = 3;
            // 
            // TypeFLP
            // 
            this.TypeFLP.AutoScroll = true;
            this.TypeFLP.BackColor = System.Drawing.Color.White;
            this.TypeFLP.Controls.Add(this.LoadAllPanel);
            this.TypeFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TypeFLP.Location = new System.Drawing.Point(3, 56);
            this.TypeFLP.Name = "TypeFLP";
            this.TypeFLP.Size = new System.Drawing.Size(256, 809);
            this.TypeFLP.TabIndex = 4;
            // 
            // LoadAllPanel
            // 
            this.LoadAllPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LoadAllPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadAllPanel.Controls.Add(this.LabelTitle);
            this.LoadAllPanel.Location = new System.Drawing.Point(3, 3);
            this.LoadAllPanel.Name = "LoadAllPanel";
            this.LoadAllPanel.Size = new System.Drawing.Size(250, 94);
            this.LoadAllPanel.TabIndex = 5;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Stanberry", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(51, 13);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(142, 68);
            this.LabelTitle.TabIndex = 5;
            this.LabelTitle.Text = "Load All\r\nEmployees";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTitle.Click += new System.EventHandler(this.LabelTitle_Click);
            // 
            // RatingsChart
            // 
            this.RatingsChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RatingsChart.BorderlineColor = System.Drawing.Color.Black;
            this.RatingsChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.RatingsChart.Location = new System.Drawing.Point(856, 447);
            this.RatingsChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RatingsChart.Name = "RatingsChart";
            this.RatingsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.RatingsChart.Size = new System.Drawing.Size(585, 418);
            this.RatingsChart.TabIndex = 5;
            this.RatingsChart.Text = "chart1";
            // 
            // RangeFilter
            // 
            this.RangeFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RangeFilter.BorderThickness = 1;
            this.RangeFilter.Checked = true;
            this.RangeFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RangeFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.RangeFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RangeFilter.Location = new System.Drawing.Point(3, 8);
            this.RangeFilter.MaxDate = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            this.RangeFilter.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.RangeFilter.Name = "RangeFilter";
            this.RangeFilter.Size = new System.Drawing.Size(257, 42);
            this.RangeFilter.TabIndex = 6;
            this.RangeFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RangeFilter.Value = new System.DateTime(2024, 3, 20, 0, 0, 0, 0);
            // 
            // NoFilter
            // 
            this.NoFilter.Animated = true;
            this.NoFilter.AutoRoundedCorners = true;
            this.NoFilter.BorderRadius = 20;
            this.NoFilter.BorderThickness = 1;
            this.NoFilter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.NoFilter.Checked = true;
            this.NoFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NoFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NoFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NoFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NoFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NoFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.NoFilter.ForeColor = System.Drawing.Color.Black;
            this.NoFilter.Location = new System.Drawing.Point(266, 8);
            this.NoFilter.Name = "NoFilter";
            this.NoFilter.Size = new System.Drawing.Size(232, 42);
            this.NoFilter.TabIndex = 7;
            this.NoFilter.Text = "No Date Filter";
            this.NoFilter.Click += new System.EventHandler(this.NoFilter_Click);
            // 
            // DayFilter
            // 
            this.DayFilter.Animated = true;
            this.DayFilter.AutoRoundedCorners = true;
            this.DayFilter.BorderRadius = 20;
            this.DayFilter.BorderThickness = 1;
            this.DayFilter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.DayFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DayFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DayFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DayFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DayFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DayFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.DayFilter.ForeColor = System.Drawing.Color.Black;
            this.DayFilter.Location = new System.Drawing.Point(504, 8);
            this.DayFilter.Name = "DayFilter";
            this.DayFilter.Size = new System.Drawing.Size(117, 42);
            this.DayFilter.TabIndex = 8;
            this.DayFilter.Text = "Day";
            this.DayFilter.Click += new System.EventHandler(this.DayFilter_Click);
            // 
            // WeeklyFilter
            // 
            this.WeeklyFilter.Animated = true;
            this.WeeklyFilter.AutoRoundedCorners = true;
            this.WeeklyFilter.BorderRadius = 20;
            this.WeeklyFilter.BorderThickness = 1;
            this.WeeklyFilter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.WeeklyFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WeeklyFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WeeklyFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WeeklyFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WeeklyFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.WeeklyFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.WeeklyFilter.ForeColor = System.Drawing.Color.Black;
            this.WeeklyFilter.Location = new System.Drawing.Point(627, 8);
            this.WeeklyFilter.Name = "WeeklyFilter";
            this.WeeklyFilter.Size = new System.Drawing.Size(133, 42);
            this.WeeklyFilter.TabIndex = 9;
            this.WeeklyFilter.Text = "Weekly";
            this.WeeklyFilter.Click += new System.EventHandler(this.WeeklyFilter_Click);
            // 
            // MonthlyFilter
            // 
            this.MonthlyFilter.Animated = true;
            this.MonthlyFilter.AutoRoundedCorners = true;
            this.MonthlyFilter.BorderRadius = 20;
            this.MonthlyFilter.BorderThickness = 1;
            this.MonthlyFilter.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.MonthlyFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MonthlyFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MonthlyFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MonthlyFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MonthlyFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.MonthlyFilter.Font = new System.Drawing.Font("Stanberry", 20.25F);
            this.MonthlyFilter.ForeColor = System.Drawing.Color.Black;
            this.MonthlyFilter.Location = new System.Drawing.Point(766, 8);
            this.MonthlyFilter.Name = "MonthlyFilter";
            this.MonthlyFilter.Size = new System.Drawing.Size(163, 42);
            this.MonthlyFilter.TabIndex = 10;
            this.MonthlyFilter.Text = "Monthly";
            this.MonthlyFilter.Click += new System.EventHandler(this.MonthlyFilter_Click);
            // 
            // EmployeePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.MonthlyFilter);
            this.Controls.Add(this.WeeklyFilter);
            this.Controls.Add(this.DayFilter);
            this.Controls.Add(this.NoFilter);
            this.Controls.Add(this.RangeFilter);
            this.Controls.Add(this.RatingsChart);
            this.Controls.Add(this.TypeFLP);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.SalesChart);
            this.Controls.Add(this.EmployeeDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeePerformance";
            this.Size = new System.Drawing.Size(1445, 870);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).EndInit();
            this.TypeFLP.ResumeLayout(false);
            this.LoadAllPanel.ResumeLayout(false);
            this.LoadAllPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RatingsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2DataGridView EmployeeDGV;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesChart;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2CircleButton SearchBtn;
        private System.Windows.Forms.FlowLayoutPanel TypeFLP;
        private System.Windows.Forms.Panel LoadAllPanel;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart RatingsChart;
        private Guna.UI2.WinForms.Guna2DateTimePicker RangeFilter;
        private Guna.UI2.WinForms.Guna2Button NoFilter;
        private Guna.UI2.WinForms.Guna2Button DayFilter;
        private Guna.UI2.WinForms.Guna2Button WeeklyFilter;
        private Guna.UI2.WinForms.Guna2Button MonthlyFilter;
    }
}
