using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Activity> GetAllActivities()
        {
            return activitydb.GetAllActivities();
        }

        public Activity GetActivityById(int activityID)
        {
            return activitydb.GetActivityById(activityID);
        }

        public void DeleteActivity(int activityID)
        {
            activitydb.DeleteActivity(activityID);
        }

        public void CreateActivity(Activity activity)
        {
            activitydb.CreateActivity(activity);
        }

        public void EditActivity(Activity activity)
        {
            activitydb.EditDrink(activity);
        }
    }
}
