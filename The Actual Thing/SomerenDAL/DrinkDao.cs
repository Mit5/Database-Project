using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT * FROM Drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesOnlyDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Drink> AllDrinksByName()
        {
            string query = "SELECT drink_number, drink_name, price, selling_price, drink_type, stock_amount, O.[Count] AS [times_ordered] FROM Drinks LEFT JOIN (SELECT Drink_Id, COUNT(*) AS [Count] FROM Orders GROUP BY Drink_Id) AS O ON O.Drink_Id = drink_number ORDER BY drink_name;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public Drink GetDrinkByNumber(int drinkNumber)
        {
            string query = $"SELECT * FROM Drinks WHERE drink_number={drinkNumber}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesOnlyDrinks(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public void DeleteDrink(int drinkNumber)
        {
            string query = $"DELETE FROM Drinks WHERE drink_number = {drinkNumber}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void CreateDrink(Drink drink)
        {
            int drinkType = (drink.DrinkType) ? 1 : 0;
            string query = $"INSERT INTO Drinks VALUES ('{drink.DrinkName}', {drink.Price}, {drink.SellingPrice}, {drinkType}, {drink.StockAmount})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void EditDrink(Drink drink)
        {
            int drinkType = (drink.DrinkType) ? 1 : 0;
            string query = $"UPDATE Drinks SET drink_name = '{drink.DrinkName}', price = {drink.Price}, selling_price = {drink.SellingPrice}, drink_type = {drinkType}, stock_amount = {drink.StockAmount} WHERE drink_number = {drink.DrinkNumber};";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkNumber = (int)dr["drink_number"],
                    DrinkName = (string)dr["drink_name"],
                    Price = (double)dr["price"],
                    SellingPrice = (double)dr["selling_price"],
                    DrinkType = ((int)dr["drink_type"] == 0) ? false : true,
                    StockAmount = (int)dr["stock_amount"],
                    TimesOrdered = (dr["times_ordered"] == DBNull.Value) ? 0 : (int)dr["times_ordered"]
                };
                drinks.Add(drink);
            }
            return drinks;
        }

        private List<Drink> ReadTablesOnlyDrinks(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    DrinkNumber = (int)dr["drink_number"],
                    DrinkName = (string)dr["drink_name"],
                    Price = (double)dr["price"],
                    SellingPrice = (double)dr["selling_price"],
                    DrinkType = ((int)dr["drink_type"] == 0) ? false : true,
                    StockAmount = (int)dr["stock_amount"],
                    TimesOrdered = 0
                };
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
