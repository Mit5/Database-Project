using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int Id { get; set; } //order Id
        public Student Student { get; set; } //purchaser student object
        public Drink Drink { get; set; } //purchased drink object
        public DateTime OrderDate { get; set; } //date of purchase

        public Order()
        {

        }

        public Order(Student student, Drink drink)
        {
            this.Student = student;
            this.Drink = drink;
        }
    }
}
