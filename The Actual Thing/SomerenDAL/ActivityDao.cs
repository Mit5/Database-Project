using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT * FROM Activities";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Activity GetActivityById(int ActivityId)
        {
            string query = $"SELECT * FROM Activities WHERE ID={ActivityId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public void DeleteActivity(int ActivityId)
        {
            string query = $"DELETE FROM Activities WHERE ID = {ActivityId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void CreateActivity(Activity activity)
        {
            string query = $"INSERT INTO Activities VALUES ('{activity.Description}', {activity.StartDateTime}, {activity.EndDateTime})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void EditDrink(Activity activity)
        {
            string query = $"UPDATE Activities SET Description = '{activity.Description}', StartDateTime = {activity.StartDateTime}, EndDateTime = {activity.EndDateTime} WHERE Id = {activity.Id};";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    Id = (int)dr["ID"],
                    Description = (string)dr["Description"],
                    StartDateTime = (DateTime)dr["StartDateTime"],
                    EndDateTime = (DateTime)dr["EndDateTime"]
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}
