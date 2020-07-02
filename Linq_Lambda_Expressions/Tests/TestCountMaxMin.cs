using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestCountMaxMin : ITest
    {
        public void Test()
        {
            var lstOrders = DataBase.DataBase.GetOrders();

            var ordersCount = lstOrders.Count;
            Console.WriteLine("Ordersn Count: " + ordersCount);

            var maxTotalvalue = lstOrders.Max(order => order.TotalValue);
            Console.WriteLine("Total Max Value: " + maxTotalvalue.ToString("C2"));

            var minTotalValue = lstOrders.Min(order => order.TotalValue);
            Console.WriteLine("Total Min Value: " + minTotalValue.ToString("C2"));

            var firstCustomerorders = lstOrders.Where(order => order.CustomerID == 0);
            Console.WriteLine("First Customer Orders Count: " + firstCustomerorders.Count());            
            Console.WriteLine("First Customer Order Max: " + firstCustomerorders.Max(order => order.TotalValue.ToString("C2")));
            Console.WriteLine("First Customer Order Min: " + firstCustomerorders.Min(order => order.TotalValue.ToString("C2")));
        }
    }
}
