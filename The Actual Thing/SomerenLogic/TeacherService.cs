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
    public class TeacherService
    {
        TeacherDao teacherdb;

        public TeacherService()
        {
            teacherdb = new TeacherDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teacher = teacherdb.GetAllTeachers();
            return teacher;
        }

        public List<Teacher> GetSupervisors(int activityId)
        {
            return teacherdb.GetSupervisors(activityId);
        }

        public List<Teacher> GetNonSupervisors(int activityId)
        {
            return teacherdb.GetNonSupervisors(activityId);
        }

        public void UpdateIsSupervisor(int Id, int isSupervisor)
        {
            teacherdb.UpdateIsSupervisor(Id, isSupervisor);
        }

        public void InsertSupervisorEntry(int teacherId, int activityId)
        {
            teacherdb.InsertSupervisorEntry(teacherId, activityId);
        }

        public void DeleteSupervisorEntry(int teacherId, int activityId)
        {
            teacherdb.DeleteSupervisorEntry(teacherId, activityId);
        }

    }
}
