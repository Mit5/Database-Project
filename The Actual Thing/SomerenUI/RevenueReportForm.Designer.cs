using System;

namespace SomerenUI
{
    partial class RevenueReportForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.revReport_StartDatemonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.revReport_EndDatemonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcRevReport_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sales_lbl = new System.Windows.Forms.Label();
            this.turnOver_lbl = new System.Windows.Forms.Label();
            this.nrOfCustomers_lbl = new System.Windows.Forms.Label();
            this.startDate_lbl = new System.Windows.Forms.Label();
            this.endDate_lbl = new System.Windows.Forms.Label();
            this.RevReport_listView = new System.Windows.Forms.ListView();
            this.Sales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TurnOver = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfStudents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenue Report";
            // 
            // revReport_StartDatemonthCalendar
            // 
            this.revReport_StartDatemonthCalendar.Location = new System.Drawing.Point(55, 80);
            this.revReport_StartDatemonthCalendar.Name = "revReport_StartDatemonthCalendar";
            this.revReport_StartDatemonthCalendar.TabIndex = 1;
            this.revReport_StartDatemonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.revReport_StartDatemonthCalendar_DateChanged);
            // 
            // revReport_EndDatemonthCalendar
            // 
            this.revReport_EndDatemonthCalendar.Location = new System.Drawing.Point(433, 80);
            this.revReport_EndDatemonthCalendar.Name = "revReport_EndDatemonthCalendar";
            this.revReport_EndDatemonthCalendar.TabIndex = 2;
            this.revReport_EndDatemonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.revReport_EndDatemonthCalendar_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date";
            // 
            // calcRevReport_btn
            // 
            this.calcRevReport_btn.Location = new System.Drawing.Point(318, 299);
            this.calcRevReport_btn.Name = "calcRevReport_btn";
            this.calcRevReport_btn.Size = new System.Drawing.Size(115, 54);
            this.calcRevReport_btn.TabIndex = 5;
            this.calcRevReport_btn.Text = "Calculate";
            this.calcRevReport_btn.UseVisualStyleBackColor = true;
            this.calcRevReport_btn.Click += new System.EventHandler(this.calcRevReport_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "TurnOver:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Number of Students:";
            // 
            // sales_lbl
            // 
            this.sales_lbl.AutoSize = true;
            this.sales_lbl.Location = new System.Drawing.Point(149, 387);
            this.sales_lbl.Name = "sales_lbl";
            this.sales_lbl.Size = new System.Drawing.Size(20, 17);
            this.sales_lbl.TabIndex = 9;
            this.sales_lbl.Text = "...";
            // 
            // turnOver_lbl
            // 
            this.turnOver_lbl.AutoSize = true;
            this.turnOver_lbl.Location = new System.Drawing.Point(149, 433);
            this.turnOver_lbl.Name = "turnOver_lbl";
            this.turnOver_lbl.Size = new System.Drawing.Size(20, 17);
            this.turnOver_lbl.TabIndex = 10;
            this.turnOver_lbl.Text = "...";
            // 
            // nrOfCustomers_lbl
            // 
            this.nrOfCustomers_lbl.AutoSize = true;
            this.nrOfCustomers_lbl.Location = new System.Drawing.Point(205, 484);
            this.nrOfCustomers_lbl.Name = "nrOfCustomers_lbl";
            this.nrOfCustomers_lbl.Size = new System.Drawing.Size(20, 17);
            this.nrOfCustomers_lbl.TabIndex = 11;
            this.nrOfCustomers_lbl.Text = "...";
            // 
            // startDate_lbl
            // 
            this.startDate_lbl.AutoSize = true;
            this.startDate_lbl.Location = new System.Drawing.Point(190, 299);
            this.startDate_lbl.Name = "startDate_lbl";
            this.startDate_lbl.Size = new System.Drawing.Size(20, 17);
            this.startDate_lbl.TabIndex = 12;
            this.startDate_lbl.Text = "...";
            // 
            // endDate_lbl
            // 
            this.endDate_lbl.AutoSize = true;
            this.endDate_lbl.Location = new System.Drawing.Point(568, 298);
            this.endDate_lbl.Name = "endDate_lbl";
            this.endDate_lbl.Size = new System.Drawing.Size(20, 17);
            this.endDate_lbl.TabIndex = 13;
            this.endDate_lbl.Text = "...";
            // 
            // RevReport_listView
            // 
            this.RevReport_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sales,
            this.TurnOver,
            this.NumberOfStudents});
            this.RevReport_listView.HideSelection = false;
            this.RevReport_listView.Location = new System.Drawing.Point(287, 387);
            this.RevReport_listView.Name = "RevReport_listView";
            this.RevReport_listView.Size = new System.Drawing.Size(418, 113);
            this.RevReport_listView.TabIndex = 14;
            this.RevReport_listView.UseCompatibleStateImageBehavior = false;
            this.RevReport_listView.View = System.Windows.Forms.View.Details;
            // 
            // Sales
            // 
            this.Sales.Text = "Sales";
            this.Sales.Width = 117;
            // 
            // TurnOver
            // 
            this.TurnOver.Text = "TurnOver";
            this.TurnOver.Width = 136;
            // 
            // NumberOfStudents
            // 
            this.NumberOfStudents.Text = "Number Of Students";
            this.NumberOfStudents.Width = 156;
            // 
            // RevenueReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 557);
            this.Controls.Add(this.RevReport_listView);
            this.Controls.Add(this.endDate_lbl);
            this.Controls.Add(this.startDate_lbl);
            this.Controls.Add(this.nrOfCustomers_lbl);
            this.Controls.Add(this.turnOver_lbl);
            this.Controls.Add(this.sales_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calcRevReport_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.revReport_EndDatemonthCalendar);
            this.Controls.Add(this.revReport_StartDatemonthCalendar);
            this.Controls.Add(this.label1);
            this.Name = "RevenueReportForm";
            this.Text = "Revenue Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar revReport_StartDatemonthCalendar;
        private System.Windows.Forms.MonthCalendar revReport_EndDatemonthCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcRevReport_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label sales_lbl;
        private System.Windows.Forms.Label turnOver_lbl;
        private System.Windows.Forms.Label nrOfCustomers_lbl;
        private System.Windows.Forms.Label startDate_lbl;
        private System.Windows.Forms.Label endDate_lbl;
        private System.Windows.Forms.ListView RevReport_listView;
        private System.Windows.Forms.ColumnHeader Sales;
        private System.Windows.Forms.ColumnHeader TurnOver;
        private System.Windows.Forms.ColumnHeader NumberOfStudents;

        public EventHandler RevReport_listView_SelectedIndexChanged { get; private set; }
    }
}