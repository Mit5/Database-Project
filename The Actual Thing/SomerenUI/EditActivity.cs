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
    public partial class EditActivity : Form
    {
        ActivityForm _activityForm;
        Activity activityToEdit;
        public EditActivity(ActivityForm activityForm, Activity activity)
        {
            InitializeComponent();
            _activityForm = activityForm;
            activityToEdit = activity;
            DisplayActivityToEdit();
        }

        void DisplayActivityToEdit()
        {
            richTextBoxDesc.Text = activityToEdit.Description;
            dateTimePickerStart.Value = activityToEdit.StartDateTime;
            dateTimePickerEnd.Value = activityToEdit.EndDateTime;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DateTime startDateTime = dateTimePickerStart.Value;
            DateTime endDateTime = dateTimePickerEnd.Value;
            string desc = richTextBoxDesc.Text;
            Activity activity = new Activity()
            {
                Id = activityToEdit.Id,
                Description = desc,
                StartDateTime = startDateTime,
                EndDateTime = endDateTime
            };
            ActivityService activityService = new ActivityService();
            activityService.EditActivity(activity);
            _activityForm.DisplayActivities();
            Close();
        }
    }
}
