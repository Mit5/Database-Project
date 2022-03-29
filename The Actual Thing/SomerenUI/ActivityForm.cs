using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class ActivityForm : Form
    {
        ActivityService activityService = new ActivityService();
        public ActivityForm()
        {
            InitializeComponent();
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            DisplayActivities();
        }

        public void DisplayActivities()
        {
            pnlActivities.Dock = DockStyle.Fill;

            try
            {
                
                List<Activity> activities = activityService.GetAllActivities();

                listViewActivities.Items.Clear();

                foreach (Activity a in activities)
                {
                    string[] items = { a.Id.ToString(), a.Description, $"{a.StartDateTime:dd-MMM-yyyy}", $"{a.EndDateTime:dd-MMM-yyyy}" };
                    ListViewItem li = new ListViewItem(items);
                    listViewActivities.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the Activities: " + e.Message);
            }
        }

        private void buttonAddActivities_Click(object sender, EventArgs e)
        {
            CreateActivity createActivity = new CreateActivity(this);
            createActivity.Show();
        }

        private void buttonDeleteActivities_Click(object sender, EventArgs e)
        {
            var items = listViewActivities.SelectedItems;
            int activityId = int.Parse(listViewActivities.SelectedItems[0].SubItems[0].Text);
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to remove this activity?","Delete Activity",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                activityService.DeleteActivity(activityId);
                DisplayActivities();
            }
            
        }

        private void buttonEditActivities_Click(object sender, EventArgs e)
        {
            if (listViewActivities.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a Activity to edit", "No activity selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (listViewActivities.SelectedItems.Count > 1)
            {
                MessageBox.Show("Select only one Activity to edit", "Mutliple activities selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int activityId = int.Parse(listViewActivities.SelectedItems[0].SubItems[0].Text);
            Activity activity = activityService.GetActivityById(activityId);
            EditActivity editActivity = new EditActivity(this, activity);
            editActivity.Show();
        }
    }
}
