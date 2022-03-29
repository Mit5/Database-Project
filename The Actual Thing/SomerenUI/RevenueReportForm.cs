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
            //DisplayRevReport();
            this.revReport_StartDatemonthCalendar.ShowToday = false;
            this.revReport_EndDatemonthCalendar.ShowToday = false;

            //sets the labels to the date of today
            DateTime today = DateTime.Today;
            startDate_lbl.Text = $"{today: dd/MM/yyyy}";
            endDate_lbl.Text = $"{today: dd/MM/yyyy}";

        }

        private void calcRevReport_btn_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(this.revReport_StartDatemonthCalendar.SelectionEnd);
            DateTime endDate = Convert.ToDateTime(this.revReport_EndDatemonthCalendar.SelectionEnd);
            sales_lbl.Text = $"{orderService.GetOrdersCount(startDate, endDate)}";
            nrOfCustomers_lbl.Text = $"{studService.GetStudentsCount(startDate, endDate)}";
            turnOver_lbl.Text = $"";
        }

        private void revReport_StartDatemonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            revReport_StartDatemonthCalendar.MaxSelectionCount = 1;
            this.revReport_StartDatemonthCalendar.SelectionRange.Start.ToString();
            DateTime startDate = Convert.ToDateTime(revReport_StartDatemonthCalendar.SelectionStart);
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
