using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenLogic;
using SomerenModel;

namespace SomerenUI
{
    public partial class DrinksForm : Form
    {
        public DrinksForm()
        {
            InitializeComponent();
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            DisplayDrinks();
        }

        public void DisplayDrinks()
        {
            pnlDrinks.Dock = DockStyle.Fill;

            try
            {
                DrinkService drinkService = new DrinkService();
                List<Drink> drinks = drinkService.DrinksSortedByName();

                listViewDrinks.Items.Clear();

                foreach (Drink d in drinks)
                {
                    string stockInfo = (d.StockAmount < 10) ? "Stock nearly depleted!" : "Stock sufficient";
                    string[] items = { d.DrinkNumber.ToString(), d.DrinkName.ToString(), d.SellingPrice.ToString(), (d.DrinkType) ? "Alcoholic" : "Non-Alcoholic", d.StockAmount.ToString(), stockInfo, d.TimesOrdered.ToString() };
                    ListViewItem li = new ListViewItem(items);
                    listViewDrinks.Items.Add(li);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the Drinks: " + e.Message);
            }
            
        }

        private void buttonAddDrinks_Click(object sender, EventArgs e)
        {
            CreateDrink createDrink = new CreateDrink(this);
            createDrink.Show();
        }

        private void buttonEditDrinks_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            if (listViewDrinks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a Drink to edit", "No drink selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (listViewDrinks.SelectedItems.Count > 1)
            {
                MessageBox.Show("Select only one Drink to edit", "Mutliple drinks selected!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedRow = listViewDrinks.SelectedItems[0];
            Drink drink = drinkService.GetDrinkByNumber(int.Parse(selectedRow.SubItems[0].Text));
            EditDrink editDrink = new EditDrink(this, drink);
            editDrink.Show();
        }

        private void buttonDeleteDrinks_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            var selectedRows = listViewDrinks.SelectedItems;
            foreach (ListViewItem item in selectedRows)
            {
                int id = int.Parse(item.SubItems[0].Text);
                drinkService.DeleteDrink(id);
            }
            DisplayDrinks();
        }
    }
}
