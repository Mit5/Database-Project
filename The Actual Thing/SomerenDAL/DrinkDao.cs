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
        //This method is for simply extracting all the Drinks from the database
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT * FROM Drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesOnlyDrinks(ExecuteSelectQuery(query, sqlParameters));
        }

        //This method is the main working horse of the entire Drinks tab of the application
        //A join clause is used to take information from both the Drinks and Orders tables. Afterwards, everything is ordered by the Drinks' names
        public List<Drink> AllDrinksByName()
        {
            string query = "SELECT drink_number, drink_name, price, selling_price, drink_type, stock_amount, O.[Count] AS [times_ordered] FROM Drinks LEFT JOIN (SELECT Drink_Id, COUNT(*) AS [Count] FROM Orders GROUP BY Drink_Id) AS O ON O.Drink_Id = drink_number ORDER BY drink_name;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //This method is used to quickly access an entry in the Drinks table for use in other methods
        public Drink GetDrinkByNumber(int drinkNumber)
        {
            string query = "SELECT * FROM Drinks WHERE drink_number=@drink_number";
            SqlParameter[] sqlParameters = { new SqlParameter("@drink_number",drinkNumber)};
            return ReadTablesOnlyDrinks(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public void DeleteDrink(int drinkNumber)
        {
            string query = "DELETE FROM Drinks WHERE drink_number = @drink_number";
            SqlParameter[] sqlParameters = { new SqlParameter("@drink_number", drinkNumber) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void CreateDrink(Drink drink)
        {
            int drinkType = (drink.DrinkType) ? 1 : 0;
            string query = $"INSERT INTO Drinks VALUES ('@drink_name', @drink_price, @selling_price, @drink_type, @stock_amount)";
            SqlParameter[] sqlParameters = { new SqlParameter("@drink_name", drink.DrinkName), new SqlParameter("@drink_price", drink.Price), new SqlParameter("@drink_name", drink.DrinkName), new SqlParameter("@selling_price", drink.SellingPrice), new SqlParameter("@drink_type", drinkType), new SqlParameter("@stock_amount", drink.StockAmount) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void EditDrink(Drink drink)
        {
            int drinkType = (drink.DrinkType) ? 1 : 0;
            string query = $"UPDATE Drinks SET drink_name = '@drink_name', price = @drink_price, selling_price = @selling_price, drink_type = @drink_type, stock_amount = @stock_amount WHERE drink_number = @drink_number;";
            SqlParameter[] sqlParameters = { new SqlParameter("@drink_name", drink.DrinkName), new SqlParameter("@drink_price", drink.Price), new SqlParameter("@drink_name", drink.DrinkName), new SqlParameter("@selling_price", drink.SellingPrice), new SqlParameter("@drink_type", drinkType), new SqlParameter("@stock_amount", drink.StockAmount), new SqlParameter("@drink_number",drink.DrinkNumber) };
            ExecuteEditQuery(query, sqlParameters);
        }

        //There are two different methods for reading a table
        //The first one reads information from both the Drinks and Orders table
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

        //The second one reads information only from the Drinks table
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
