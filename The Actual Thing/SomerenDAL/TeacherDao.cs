using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class TeacherDao : BaseDao
    {      
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT TeacherFirst_Name,TeacherLast_Name, Teacher_NumberID,Supervisor FROM Lecturers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Teacher> GetSupervisors(int activityId)
        {
            string query = "SELECT TeacherFirst_Name,TeacherLast_Name, Teacher_NumberID,Supervisor FROM ActivitySupervisor AS S JOIN Lecturers AS L ON S.LecturerId = L.Teacher_NumberID WHERE ActivityID = @Id";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", activityId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Teacher> GetNonSupervisors(int activityId)
        {
            string query = "SELECT TeacherFirst_Name,TeacherLast_Name, Teacher_NumberID,Supervisor FROM Lecturers WHERE Teacher_NumberID NOT IN(SELECT LecturerID FROM ActivitySupervisor WHERE ActivityID = @Id)";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", activityId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateIsSupervisor(int teacherId, int isSupervisor)
        {
            string query = "UPDATE Lecturers SET [Supervisor] = @Supervisor WHERE [Teacher_NumberID] = @Id";
            SqlParameter[] sqlParameters = { new SqlParameter("Id", teacherId), new SqlParameter("Supervisor", isSupervisor) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void InsertSupervisorEntry(int teacherId, int activityId)
        {
            string query = "INSERT INTO ActivitySupervisor VALUES(@TeacherId, @ActivityId)";
            SqlParameter[] sqlParameters = { new SqlParameter("TeacherId", teacherId), new SqlParameter("@ActivityId", activityId) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteSupervisorEntry(int teacherId, int activityId)
        {
            string query = "DELETE FROM ActivitySupervisor WHERE (LecturerID = @TeacherId AND ActivityID = @ActivityId)";
            SqlParameter[] sqlParameters = { new SqlParameter("TeacherId", teacherId), new SqlParameter("@ActivityId", activityId) };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Number = (int)dr["Teacher_NumberID"],
                    FirstName = (string)(dr["TeacherFirst_Name"].ToString()),
                    LastName = (string)(dr["TeacherLast_Name"].ToString()),
                    Supervisor = ((int)dr["Supervisor"] == 0) ? false : true
                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
