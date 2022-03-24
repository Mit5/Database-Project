using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenLogic;

namespace SomerenUI
{
    public partial class RevenueReportForm : Form
    {

        StudentService studService = new StudentService();
        OrderService orderService = new OrderService();
        DrinkService drinkService = new DrinkService();

        public RevenueReportForm()
        {
            InitializeComponent();
            this.revReport_StartDatemonthCalendar.ShowToday = false;
            this.revReport_EndDatemonthCalendar.ShowToday = false;
        }

        private void RevenueReportForm_Load(object sender, EventArgs e)
        {

        }

        private void calcRevReport_btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(this.revReport_StartDatemonthCalendar.SelectionEnd);
            DateTime endDate = Convert.ToDateTime(this.revReport_EndDatemonthCalendar.SelectionEnd);
            sales_lbl.Text = $"{orderService.GetOrdersCount(startDate, endDate)}";
        }

        private void revReport_StartDatemonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            revReport_StartDatemonthCalendar.MaxSelectionCount = 1;
            this.revReport_StartDatemonthCalendar.SelectionRange.Start.ToString();
            DateTime startDate = Convert.ToDateTime(this.revReport_StartDatemonthCalendar.SelectionEnd);
            startDate_lbl.Text = $"{startDate: dd/MM/yyyy}";  
        }

        private void revReport_EndDatemonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            revReport_EndDatemonthCalendar.MaxSelectionCount = 1;
            this.revReport_EndDatemonthCalendar.SelectionRange.Start.ToString();
            DateTime endDate = Convert.ToDateTime(this.revReport_EndDatemonthCalendar.SelectionEnd);
            endDate_lbl.Text = $"{endDate: dd/MM/yyyy}";

        }
    }
}
