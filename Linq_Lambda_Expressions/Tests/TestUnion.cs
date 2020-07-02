using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestUnion : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();
            var lstOrders = DataBase.DataBase.GetOrders();

            var firstCustomer = lstCustomers.FirstOrDefault();
            var lastCustomer = lstCustomers.LastOrDefault();

            var firstCustomerOrders = lstOrders.Where(order => order.CustomerID == firstCustomer.Id);
            var lastCustomerOrders = lstOrders.Where(order => order.CustomerID == lastCustomer.Id);

            var firstAndLastCustomer = firstCustomerOrders.Union(lastCustomerOrders);

            foreach (var item in firstAndLastCustomer)
            {
                Console.WriteLine("CustomerID: " + item.CustomerID + " Total Value: " + item.TotalValue.ToString("C2"));
            }
        }
    }
}
