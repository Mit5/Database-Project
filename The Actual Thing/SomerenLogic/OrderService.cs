using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class OrderService
    {
        OrderDAO orderdb;

        public OrderService()
        {
            orderdb = new OrderDAO();
        }
        public void CreateOrder(Order order)
        {
            //Method connects OrderDAO Object to insert order into database with the UI Layer
            orderdb.CreateOrder(order);
        }
        public int GetOrdersCount(DateTime startDate, DateTime endDate)
        {
            //Method connects orderDAO object to retrieve order count from database 
            return orderdb.GetNumberOfOrders(startDate, endDate);
        }
        //public int GetTurnOverservice(DateTime startDate, DateTime endDate)
        //{
        //    return orderdb.GetTurnOver(startDate, endDate);
        //}


    }
}
