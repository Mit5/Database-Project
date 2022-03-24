using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Student
    { 
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullName { get { return $"{Name} {LastName}"; } }

        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}
