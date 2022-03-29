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
    public partial class LecturersForm : Form
    {
        public LecturersForm()
        {
            InitializeComponent();
            DisplayLecturers();
        }
        private void DisplayLecturers()
        {
            // Show Lecturers
            pnlTeachers.Dock = DockStyle.Fill;

            // fill the teachers listview within the teachers panel with a list of Teachers
            TeacherService teacherService = new TeacherService(); ;
            List<Teacher> TeacherList = teacherService.GetTeachers(); ;

            // clear the listview before filling it again
            listViewTeachers.Items.Clear();

            foreach (Teacher t in TeacherList)
            {
                ListViewItem li = new ListViewItem(t.Number.ToString());
                li.SubItems.Add(t.FirstName);
                li.SubItems.Add(t.LastName);
                li.SubItems.Add((t.Supervisor) ? "Yes" : "No");
                listViewTeachers.Items.Add(li);
            }
        }
    }
}
