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
    public partial class SupervisorsControl : UserControl
    {
        ActivityService activityService = new ActivityService();
        public SupervisorsControl()
        {
            InitializeComponent();
        }

        private void SupervisorsControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            
            
        }

        private void DisplayActivities()
        {
            Activities_lstview.FullRowSelect = true;
            List<Activity> activities = null;

            Activities_lstview.Clear();

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
    }
}
