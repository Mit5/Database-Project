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
    public partial class EditDrink : Form
    {
        DrinksForm DrinkForm;
        Drink drinkToEdit;

        public EditDrink(DrinksForm drinksForm, Drink drink)
        {
            InitializeComponent();
            DrinkForm = drinksForm;
            drinkToEdit = drink;
            DisplayDrinkToEdit();
        }

        private void DisplayDrinkToEdit()
        {
            textBoxNumber.Text = drinkToEdit.DrinkNumber.ToString();
            textBoxName.Text = drinkToEdit.DrinkName;
            textBoxPrice.Text = drinkToEdit.Price.ToString();
            textBoxStock.Text = drinkToEdit.StockAmount.ToString();
            comboBoxType.SelectedItem = (drinkToEdit.DrinkType) ? comboBoxType.Items[0] : comboBoxType.Items[1];
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            string name = textBoxName.Text;
            double price = double.Parse(textBoxPrice.Text);
            bool type = comboBoxType.SelectedItem.ToString() == "Alcoholic";
            int stock = int.Parse(textBoxStock.Text);
            Drink drink = new Drink()
            {
                DrinkNumber = drinkToEdit.DrinkNumber,
                DrinkName = name,
                Price = price,
                SellingPrice = price,
                DrinkType = type,
                StockAmount = stock
            };
            drinkService.EditDrink(drink);
            DrinkForm.DisplayDrinks();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
