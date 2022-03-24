using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class CreateDrink : Form
    {
        DrinksForm DrinksForm;
        public CreateDrink(DrinksForm drinksForm)
        {
            InitializeComponent();
            DrinksForm = drinksForm;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new DrinkService();
                string name = textBoxName.Text;
                double price = double.Parse(textBoxPrice.Text);
                bool type = comboBoxType.SelectedItem.ToString() == "Alcoholic";
                int stock = int.Parse(textBoxStock.Text);
                Drink drink = new Drink()
                {
                    DrinkNumber = 0,
                    DrinkName = name,
                    Price = price,
                    SellingPrice = price,
                    DrinkType = type,
                    StockAmount = stock,
                    TimesOrdered = 0
                };
                drinkService.CreateDrink(drink);
                DrinksForm.DisplayDrinks();
                Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
