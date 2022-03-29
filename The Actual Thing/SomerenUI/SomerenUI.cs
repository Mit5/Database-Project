using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showWindow("Dashboard");
        }

        private void showWindow(string windowName)
        {
            try
            {
                if (windowName == "Dashboard")
                {
                    pnlDashboard.Dock = DockStyle.Fill;
                    //supervisorsControl1.Hide();
                }
                else if (windowName == "Students")
                {
                    StudentsForm studentsForm = new StudentsForm();
                    studentsForm.ShowDialog();
                }
                else if (windowName == "Rooms")
                {
                    RoomsForm roomsForm = new RoomsForm();
                    roomsForm.ShowDialog();
                }
                else if (windowName == "Teachers")
                {
                    LecturersForm lecturersForm = new LecturersForm();
                    lecturersForm.ShowDialog();
                } 
                else if (windowName == "Register")
                {
                    RegisterForm registerForm = new RegisterForm();
                    registerForm.ShowDialog();
                }
                else if (windowName == "Drinks")
                {
                    DrinksForm drinksForm = new DrinksForm();
                    drinksForm.ShowDialog();
                }
                else if (windowName == "RevenueReport")
                {
                    RevenueReportForm revenueReportForm = new RevenueReportForm();
                    revenueReportForm.ShowDialog();
                }
                else if (windowName == "Supervisors")
                {
                    SupervisorsForm supervisorsForm = new SupervisorsForm();
                    supervisorsForm.Show();
                }
                else if (windowName == "Activities")
                {
                    ActivityForm activityForm = new ActivityForm();
                    activityForm.ShowDialog();
                }
                else if (windowName == "Participants")
                {
                    ParticipantsForm ParticipantsForm = new ParticipantsForm();
                    ParticipantsForm.Show();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong while loading the {windowName}: " + e.Message);
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showWindow("Dashboard");
        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow("Students");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow("Rooms");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow("Teachers");
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow("Register");
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow("Drinks");
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow("RevenueReport");
        }

        private void supervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow("Supervisors");
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow("Activities");
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showWindow("Participants");
        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }
    }
}
