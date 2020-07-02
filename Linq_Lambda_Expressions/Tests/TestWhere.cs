using Linq_Lambda_Expressions.Model;
using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestWhere : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();
            var lstOrders = DataBase.DataBase.GetOrders();

            //var ageCustomers = lstCustomers.Where(customer => customer.Age > 40);

            //foreach (var item in ageCustomers)
            //{
            //    Console.WriteLine("Customer: " + item.Name + " Age: " + item.Age);
            //}            

            //var ageCustomers = lstCustomers.Where(customer => customer.Age > 40).Where(customer => customer.Age < 51);

            //foreach (var item in ageCustomers)
            //{
            //    Console.WriteLine("Customer: " + item.Name + " Age: " + item.Age);
            //}

            //var ageCustomers = lstCustomers.Where(customer => customer.Age > 40 && customer.Age < 51);

            //foreach (var item in ageCustomers)
            //{
            //    Console.WriteLine("Customer: " + item.Name + " Age: " + item.Age);
            //}

            var firstCustomerorders = lstOrders.Where(order => ValidateOrders(order));

            foreach (var item in firstCustomerorders)
            {
                Console.WriteLine("Customer: " + item.CustomerID + " Total: " + item.TotalValue.ToString("C2"));
            }
        }

        private static bool ValidateOrders(Order order)
        {
            return (order.CustomerID == 1 && order.TotalValue > 1000 && order.TotalValue < 3000) || (order.CustomerID == 2);
        }
    }
}
