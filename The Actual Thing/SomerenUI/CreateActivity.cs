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
    public partial class CreateActivity : Form
    {
        ActivityForm _activityForm;
        public CreateActivity(ActivityForm activityForm)
        {
            InitializeComponent();
            _activityForm = activityForm;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = dateTimePickerStart.Value;
            DateTime endDateTime = dateTimePickerEnd.Value;
            string desc = richTextBoxDesc.Text;
            Activity activity = new Activity()
            { 
                Description = desc,
                StartDateTime = startDateTime,
                EndDateTime = endDateTime
            };
            ActivityService activityService = new ActivityService();
            activityService.CreateActivity(activity);
            _activityForm.DisplayActivities();
            Close();
        }
    }
}
