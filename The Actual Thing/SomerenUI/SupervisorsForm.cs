using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenLogic;
using SomerenModel;

namespace SomerenUI
{
    public partial class SupervisorsForm : Form
    {
        ActivityService activityService = new ActivityService();
        TeacherService teacherService = new TeacherService();
        public SupervisorsForm()
        {
            InitializeComponent();

            Remove_btton.Enabled = false;
            Add_btton.Enabled = false;

            DisplayActivities();
        }

        private void DisplayActivities()
        {
            Activities_lstview.FullRowSelect = true;

            List<Activity> activities = null;

            activities = activityService.GetAllActivities();

            foreach (Activity a in activities)
            {
                ListViewItem li = new ListViewItem(a.Id.ToString());
                li.SubItems.Add(a.Description);
                li.SubItems.Add(a.StartDateTime.ToString());
                li.SubItems.Add(a.EndDateTime.ToString());
                Activities_lstview.Items.Add(li);
            }
        }

        private void Activities_lstview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Activities_lstview.SelectedItems.Count > 0)
            {
                DisplaySupervisors();
                DisplayNonSupervisors();
            }


            Remove_btton.Enabled = false;
            Add_btton.Enabled = false;
        }

        private void DisplaySupervisors()
        {
            Supervisors_lstView.FullRowSelect = true;
            Supervisors_lstView.Items.Clear();
            
            int activityId = int.Parse(Activities_lstview.SelectedItems[0].SubItems[0].Text);
            List<Teacher> supervisors = teacherService.GetSupervisors(activityId);

            foreach (Teacher t in supervisors)
            {
                ListViewItem li = new ListViewItem(t.Number.ToString());
                li.SubItems.Add(t.FirstName);
                li.SubItems.Add(t.LastName);
                Supervisors_lstView.Items.Add(li);
            }
        }

        private void DisplayNonSupervisors()
        {
            NotSupervisors_lstView.FullRowSelect = true;
            NotSupervisors_lstView.Items.Clear();

            int activityId = int.Parse(Activities_lstview.SelectedItems[0].SubItems[0].Text);
            List<Teacher> nonSupervisors = teacherService.GetNonSupervisors(activityId);

            foreach (Teacher t in nonSupervisors)
            {
                ListViewItem li = new ListViewItem(t.Number.ToString());
                li.SubItems.Add(t.FirstName);
                li.SubItems.Add(t.LastName);
                NotSupervisors_lstView.Items.Add(li);
            }
        }

        private void Supervisors_lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Supervisors_lstView.SelectedItems.Count == 1)
            {
                Remove_btton.Enabled = true;
            }
        }

        private void NotSupervisors_lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotSupervisors_lstView.SelectedItems.Count == 1)
            {
                Add_btton.Enabled = true;
            }
        }

        private void Add_btton_Click(object sender, EventArgs e)
        {
            int teacher_Id = int.Parse(NotSupervisors_lstView.SelectedItems[0].SubItems[0].Text);
            int isSupervisor = 1;
            int activityId = int.Parse(Activities_lstview.SelectedItems[0].SubItems[0].Text);

            teacherService.UpdateIsSupervisor(teacher_Id, isSupervisor);
            teacherService.InsertSupervisorEntry(teacher_Id, activityId);

            MessageBox.Show("Supervisor Added!");

            DisplaySupervisors();
            DisplayNonSupervisors();

            Add_btton.Enabled = false;
        }

        private void Remove_btton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you wish to remove this supervisor?", "Delete Supervisor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if ( result == DialogResult.Yes)
            {
                int teacher_Id = int.Parse(Supervisors_lstView.SelectedItems[0].SubItems[0].Text);
                int isSupervisor = 0;
                int activityId = int.Parse(Activities_lstview.SelectedItems[0].SubItems[0].Text);

                teacherService.UpdateIsSupervisor(teacher_Id, isSupervisor);
                teacherService.DeleteSupervisorEntry(teacher_Id, activityId);

                DisplaySupervisors();
                DisplayNonSupervisors();

                Remove_btton.Enabled = false;
            }
        }
    }
}
