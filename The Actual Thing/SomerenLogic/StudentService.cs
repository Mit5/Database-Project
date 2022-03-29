using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class StudentService
    {
        StudentDao studentdb;

        public StudentService()
        {
            studentdb = new StudentDao();
        }

        public List<Student> GetStudents()
        {
            List<Student> students = studentdb.GetAllStudents();
            return students;
        }

        public Student GetStudentById(int studentId)
        {
            Student student = studentdb.GetStudentById(studentId);
            return student;
        }
        public int GetStudentsCount(DateTime startDate, DateTime endDate)
        {
            return studentdb.GetNumberOfOSudents(startDate, endDate);
        }
        public List<Student> GetParticipants(int activityId)
        {
            return studentdb.GetParticipants(activityId);
        }

        public List<Student> GetNonParticipants(int activityId)
        {
            return studentdb.GetNonParticipants(activityId);
        }

        public void UpdateIsParticipant(int Id, int isParticipant)
        {
            studentdb.UpdateIsParticipant(Id, isParticipant);
        }

        public void InsertParticipantEntry(int studentId, int activityId)
        {
            studentdb.InsertParticipantEntry(studentId, activityId);
        }

        public void DeleteParticipantEntry(int studentId, int activityId)
        {
            studentdb.DeleteParticipantEntry(studentId, activityId);
        }
    }
}
