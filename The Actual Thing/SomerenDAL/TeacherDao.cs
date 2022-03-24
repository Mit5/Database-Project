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
