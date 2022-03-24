using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class OrderDAO : BaseDao
    {
        public void CreateOrder(Order order)
        {
            //method inserts into the database an order object created through the UI
            int studentId = order.Student.Id;
            int drinkId = order.Drink.DrinkNumber;

            string orderDate = $"{DateTime.Today.Year}{DateTime.Today.Month:00}{DateTime.Today.Day}";

            string query = "INSERT INTO Orders VALUES(@Student, @Drink, @Date)";   

            SqlParameter[] sqlParameters = { new SqlParameter("@Student", studentId),
                                             new SqlParameter("@Drink", drinkId),
                                             new SqlParameter("@Date", orderDate)
                                           };

            ExecuteEditQuery(query, sqlParameters);
        }

        public int GetNumberOfOrders(DateTime startDate, DateTime endDate)
        {
            //method gets the amount of orders on an specific set of dates
            string orderSDate = $"{startDate.Year}{startDate.Month:00}{startDate.Day}"; //20220317
            string orderEDate = $"{endDate.Year}{endDate.Month:00}{endDate.Day}";

            string query = $"SELECT COUNT(Id) AS [OrderCount] FROM Orders WHERE Order_Date BETWEEN(CONVERT(date, '{orderSDate}')) AND (CONVERT(date, '{orderEDate}'))";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadInt(ExecuteSelectQuery(query, sqlParameters));

        }

        private int ReadInt(DataTable dataTable)
        {
            DataRow dr = dataTable.Rows[0];
            return (int)dr["OrderCount"];
        }
    }
}
