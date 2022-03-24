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
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            // Show Students
            pnlStudents.Dock = DockStyle.Fill;
            
            // fill the students listview within the students panel with a list of students
            StudentService studService = new StudentService(); 
            List<Student> studentList = studService.GetStudents(); 

            // clear the listview before filling it again
            listViewStudents.Items.Clear();

            foreach (Student s in studentList)
            {
                ListViewItem li = new ListViewItem(s.Id.ToString());
                li.SubItems.Add(s.Name);
                li.SubItems.Add(s.LastName);
                li.SubItems.Add($"{s.BirthDate: dd/MM/yyyy}");
                listViewStudents.Items.Add(li);
            }
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // StudentsForm
        //    // 
        //    this.ClientSize = new System.Drawing.Size(1105, 572);
        //    this.Name = "StudentsForm";
        //    this.ResumeLayout(false);

        //}
    }
}
