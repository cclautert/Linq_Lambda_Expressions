using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestOrderBy : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();
            var lstOrders = DataBase.DataBase.GetOrders();

            var CustomerOrders = lstCustomers.Join(
                        lstOrders, 
                        customer => customer.Id, 
                        order => order.CustomerID, 
                        (customer, order) => new { CustomerID = customer.Id, Name = customer.Name, Age = customer.Age, TotalValue = order.TotalValue, Createdate = order.Createdate }
                    );
            
            //foreach (var item in CustomerOrders.OrderBy(order => order.TotalValue))
            //{
            //    Console.WriteLine("Customer: " + item.Name + " Total: " + item.TotalValue.ToString("C2"));
            //}

            //foreach (var item in CustomerOrders.OrderByDescending(order => order.TotalValue))
            //{
            //    Console.WriteLine("Customer: " + item.Name + " Total: " + item.TotalValue.ToString("C2"));
            //}

            //foreach (var item in CustomerOrders.OrderBy(customer => customer.Name).ThenBy(order => order.TotalValue))
            //{
            //    Console.WriteLine("Customer: " + item.Name + " Total: " + item.TotalValue.ToString("C2"));
            //}

            foreach (var item in CustomerOrders.OrderBy(customer => customer.Name).ThenByDescending(order => order.TotalValue))
            {
                Console.WriteLine("Customer: " + item.Name + " Total: " + item.TotalValue.ToString("C2"));
            }
        }
    }
}
