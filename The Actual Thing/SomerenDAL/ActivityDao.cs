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

        //This method is used to quickly access an entry in the Activities table for use in other methods
        public Activity GetActivityById(int ActivityId)
        {
            string query = "SELECT * FROM Activities WHERE ID=@Id";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", ActivityId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public void DeleteActivity(int ActivityId)
        {
            string query = "DELETE FROM Activities WHERE ID = @Id";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", ActivityId) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void CreateActivity(Activity activity)
        {
            string startDate = DateToString(activity.StartDateTime);
            string endDate = DateToString(activity.EndDateTime);
            string query = "INSERT INTO Activities VALUES ('@Description', @StartDate, @EndDate)";
            SqlParameter[] sqlParameters = { new SqlParameter("@Description", activity.Description), new SqlParameter("@StartDate", startDate), new SqlParameter("@EndDate", endDate) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void EditActivity(Activity activity)
        {
            string startDate = DateToString(activity.StartDateTime);
            string endDate = DateToString(activity.EndDateTime);
            string query = "UPDATE Activities SET Description = '@Description', StartDateTime = @StartDate, EndDateTime = @EndDate WHERE Id = @Id;";
            SqlParameter[] sqlParameters = { new SqlParameter("@Description", activity.Description), new SqlParameter("@StartDate", startDate), new SqlParameter("@EndDate", endDate), new SqlParameter("@Id", activity.Id) };
            ExecuteEditQuery(query, sqlParameters);
        }

        //This method is used to return a string corresponding to the format of DATE in SQL
        public string DateToString(DateTime dateTime)
        {
            return $"'{dateTime:yyyy}-{dateTime:MM}-{dateTime:dd}'";
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
