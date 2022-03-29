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
        public List<Student> GetParticipants(int activityId)
        {
            string query = "SELECT student_Name,student_LastName, student_Id,participant FROM Activity AS P JOIN Students AS S ON P.StudentId = S.Student_ID WHERE ActivityID = @Id";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", activityId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Student> GetNonParticipants(int activityId)
        {
            string query = "SELECT student_Name,student_LastName, student_Id,participant FROM Students WHERE student_Id NOT IN(SELECT StudentID FROM ActivityParticipants WHERE ActivityID = @Id)";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", activityId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateIsParticipant(int studentId, int isParticipant)
        {
            string query = "UPDATE ActivityParticipants SET [Participant] = @Participant WHERE [student_Id] = @Id";
            SqlParameter[] sqlParameters = { new SqlParameter("Id", studentId), new SqlParameter("Participant", isParticipant) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void InsertParticipantEntry(int studentId, int activityId)
        {
            string query = "INSERT INTO ActivityParticipants VALUES(@StudentId, @ActivityId)";
            SqlParameter[] sqlParameters = { new SqlParameter("StudentId", studentId), new SqlParameter("@ActivityId", activityId) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteParticipantEntry(int studentId, int activityId)
        {
            string query = "DELETE FROM ActivityParticipants WHERE (StudentID = @studentId AND ActivityID = @ActivityId)";
            SqlParameter[] sqlParameters = { new SqlParameter("StudentId", studentId), new SqlParameter("@ActivityId", activityId) };
            ExecuteEditQuery(query, sqlParameters);
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

        public int GetNumberOfOSudents(DateTime startDate, DateTime endDate)
        {
            string orderSDate = $"{startDate.Year}{startDate.Month:00}{startDate.Day}"; //20220317
            string orderEDate = $"{endDate.Year}{endDate.Month:00}{endDate.Day}";

            string query = $"SELECT COUNT (DISTINCT(Student_Id)) AS [NoOfStudents] FROM Orders";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadInt(ExecuteSelectQuery(query, sqlParameters));

        }

        private int ReadInt(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            return (int)dr["NoOfStudents"];
        }
    }
}
