using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenLogic;

namespace SomerenUI
{
    public partial class RegisterForm : Form
    {
        StudentService studService = new StudentService();
        OrderService orderService = new OrderService();
        DrinkService drinkService = new DrinkService();


        public RegisterForm()
        {
            InitializeComponent();
            DisplayStudents();
            DisplayDrinks();

            //keep check out button disabled
            checkoutbtn.Enabled = false;
        }
        private void DisplayStudents()
        {
            List<Student> studentList = null;
            //Allow slection of full row
            lstStudents.FullRowSelect = true;

            // clear the listview before filling it again
            EmptyStudentsLst();

            // fill the students listview with a list of students
            studentList = studService.GetStudents();

            foreach (Student s in studentList)
            {
                ListViewItem li = new ListViewItem(s.Id.ToString());
                li.SubItems.Add(s.Name);
                li.SubItems.Add(s.LastName);
                lstStudents.Items.Add(li);
            }
        }

        private void DisplayDrinks()
        {

            List<Drink> drinkList = null;

            //Allow slection of full row
            lstDrinks.FullRowSelect = true;

            // clear the listview before filling it again
            EmptyDrinksLst();

            // fill the List with a list of drinks
            drinkList = drinkService.GetDrinks();

            //adding drinks to the listview
            foreach (Drink d in drinkList)
            {
                ListViewItem li = new ListViewItem(d.DrinkNumber.ToString());
                li.SubItems.Add(d.DrinkName);
                li.SubItems.Add($"{d.Price}");
                li.SubItems.Add($"{d.StockAmount}");
                li.SubItems.Add((d.DrinkType) ? "Yes" : "No");
                lstDrinks.Items.Add(li);
            }

        }


        private void EmptyDrinksLst()
        {
            if (lstDrinks.Items.Count > 0)
            {
                lstDrinks.Items.Clear();
            }
        }

        private void EmptyStudentsLst()
        {
            if (lstStudents.Items.Count > 0)
            {
                lstStudents.Items.Clear();
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItems.Count > 0)
            {
                //allow to click check out button if a drink has been selected
                checkoutbtn.Enabled = (lstDrinks.SelectedItems.Count > 0);

                string studentName = $"{lstStudents.SelectedItems[0].SubItems[1].Text}";
                label3.Text = $"{studentName}";
            }
        }

        private void lstDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDrinks.SelectedItems.Count > 0)
            {
                //allow to click check out button if an student has been selected
                checkoutbtn.Enabled = (lstStudents.SelectedItems.Count > 0);

                //print the price of the drink
                lblPrice.Text = lstDrinks.SelectedItems[0].SubItems[2].Text;

                string drinkName = lstDrinks.SelectedItems[0].SubItems[1].Text;
                label2.Text = $"{drinkName}";
            }
        }

        private void checkoutbtn_Click(object sender, EventArgs e)
        {
            if (lstDrinks.SelectedItems.Count != 0)
            {
                //retrieve studentId from selected item and create an object by id
                int studentId = int.Parse(lstStudents.SelectedItems[0].SubItems[0].Text);
                Student student = studService.GetStudentById(studentId);

                //retrieve drink id from slected item and create an object by id
                int drinkId = int.Parse(lstDrinks.SelectedItems[0].SubItems[0].Text);
                Drink drink = drinkService.GetDrinkByNumber(drinkId);

                if(drinkService.HasStock(drink))
                {
                    //create order
                    Order order = new Order(student, drink);
                    orderService.CreateOrder(order);
                    drinkService.DecreaseStockOfDrink(drink);

                    MessageBox.Show("Order Created!");

                    lblPrice.Text = "...";
                    checkoutbtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Drink {drink.DrinkName} out of stock!");
                }


            }
            DisplayDrinks();
            DisplayStudents();
        }
    }
}

