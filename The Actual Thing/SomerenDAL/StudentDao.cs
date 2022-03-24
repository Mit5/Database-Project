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
    public class StudentDao : BaseDao
    {
        private List<Student> students = new List<Student>();
        public List<Student> GetAllStudents()
        {
            string query = "SELECT student_Id, student_Name, student_lastname, student_birthdate FROM Students";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Student GetStudentById(int studentId)
        {
            //Method retrieves specific student by id from the database and returns a student object
            string query = "SELECT student_Id, student_Name, student_LastName, student_birthdate FROM Students WHERE student_Id = @studentId";
            SqlParameter[] sqlParameters = { new SqlParameter("@studentId", studentId) };

            Student student = ReadStudent(ExecuteSelectQuery(query, sqlParameters));

            return student;
        }
        private List<Student> ReadTables(DataTable dataTable)
        {
            students.Clear();
            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Id = (int)dr["student_Id"],
                    Name = (string)(dr["student_Name"].ToString()),
                    LastName = (string)dr["student_LastName"].ToString(),
                    BirthDate = (DateTime)dr["student_birthdate"]
                };
                students.Add(student);
            }
            return students;
        }

        private Student ReadStudent(DataTable dataTable)
        {
            //Method reads a single student and returns a student object
            Student student = new Student();
            if (dataTable.Rows.Count >= 1)
            {
                DataRow row = dataTable.Rows[0];

                student.Id = (int)row["student_Id"];
                student.Name = row["student_Name"].ToString();
                student.LastName = row["student_LastName"].ToString();
                student.BirthDate = (DateTime)row["student_birthdate"];
            }

            return student;
        }
    }
}
