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
    public partial class ParticipantsForm : Form
    {
        ActivityService activityService = new ActivityService();
        StudentService studentService = new StudentService();

        public ParticipantsForm()
        {
            InitializeComponent();

            Remove_btton.Enabled = false;
            Add_btton.Enabled = false;

            DisplayActivities();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void DisplayActivities()
        {
            Activities_lstView.FullRowSelect = true;

            List<Activity> activities = null;

            activities = activityService.GetAllActivities();

            foreach (Activity a in activities)
            {
                ListViewItem li = new ListViewItem(a.Id.ToString());
                li.SubItems.Add(a.Description);
                li.SubItems.Add(a.StartDateTime.ToString());
                li.SubItems.Add(a.EndDateTime.ToString());
                Activities_lstView.Items.Add(li);
            }
        }

        private void Activities_lstview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Activities_lstView.SelectedItems.Count > 0)
            {
                DisplayParticipants();
                DisplayNonParticipants();
            }


            Remove_btton.Enabled = false;
            Add_btton.Enabled = false;
        }

        private void DisplayParticipants()
        {
            Participants_lstView.FullRowSelect = true;
            Participants_lstView.Items.Clear();

            int activityId = int.Parse(Activities_lstView.SelectedItems[0].SubItems[0].Text);
            List<Student> participants = studentService.GetParticipants(activityId);

            foreach (Student t in participants)
            {
                ListViewItem li = new ListViewItem(t.Id.ToString());
                li.SubItems.Add(t.Name);
                li.SubItems.Add(t.LastName);
                Participants_lstView.Items.Add(li);
            }
        }

        private void DisplayNonParticipants()
        {
            NotParticipants_lstView.FullRowSelect = true;
            NotParticipants_lstView.Items.Clear();

            int activityId = int.Parse(Activities_lstView.SelectedItems[0].SubItems[0].Text);
            List<Student> nonParticipants = studentService.GetNonParticipants(activityId);

            foreach (Student t in nonParticipants)
            {
                ListViewItem li = new ListViewItem(t.Id.ToString());
                li.SubItems.Add(t.Name);
                li.SubItems.Add(t.LastName);
                NotParticipants_lstView.Items.Add(li);
            }
        }

        private void Participants_lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Participants_lstView.SelectedItems.Count == 1)
            {
                Remove_btton.Enabled = true;
            }
        }

        private void NotParticipants_lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotParticipants_lstView.SelectedItems.Count == 1)
            {
                Add_btton.Enabled = true;
            }
        }

        private void Add_btton_Click(object sender, EventArgs e)
        {
            int student_Id = int.Parse(NotParticipants_lstView.SelectedItems[0].SubItems[0].Text);
            int isParticipant = 1;
            int activityId = int.Parse(Activities_lstView.SelectedItems[0].SubItems[0].Text);

            studentService.UpdateIsParticipant(student_Id, isParticipant);
            studentService.InsertParticipantEntry(student_Id, activityId);

            MessageBox.Show("Participant Added!");

            DisplayParticipants();
            DisplayNonParticipants();
        }

        private void Remove_btton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you wish to remove this Participant?", "Delete Participant", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int student_Id = int.Parse(Participants_lstView.SelectedItems[0].SubItems[0].Text);
                int isParticipant = 0;
                int activityId = int.Parse(Activities_lstView.SelectedItems[0].SubItems[0].Text);

                studentService.UpdateIsParticipant(student_Id, isParticipant);
                studentService.DeleteParticipantEntry(student_Id, activityId);

                DisplayParticipants();
                DisplayNonParticipants();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
