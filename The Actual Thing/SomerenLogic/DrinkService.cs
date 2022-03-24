using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkdb.GetAllDrinks();
            return drinks;
        }

        public void DecreaseStockOfDrink(Drink drink)
        {
            drink.StockAmount--;
            drinkdb.EditDrink(drink);
        }

        public bool HasStock(Drink drink)
        {
            return drink.StockAmount > 0;
        }

        public List<Drink> DrinksSortedByName()
        {
            List<Drink> drinks = drinkdb.AllDrinksByName();
            return drinks;
        }

        public Drink GetDrinkByNumber(int drinkNumber)
        {
            return drinkdb.GetDrinkByNumber(drinkNumber);
        }

        public void DeleteDrink(int drinkNumber)
        {
            drinkdb.DeleteDrink(drinkNumber);
        }

        public void CreateDrink(Drink drink)
        {
            drinkdb.CreateDrink(drink);
        }

        public void EditDrink(Drink drink)
        {
            drinkdb.EditDrink(drink);
        }
    }
}
