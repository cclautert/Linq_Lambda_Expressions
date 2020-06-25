using Linq_Lambda_Expressions.Model;
using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestJoin : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();
            var Orders = DataBase.DataBase.GetOrders();

            /*
            var lstCustomersOrders = lstCustomers.Join(
                Orders, 
                customer => customer.Id,
                order => order.CustomerID,
                //( customer, order ) => new { Customer = customer,  Order = order}
                (customer, order) => new { Name = customer.Name, TotalValue = order.TotalValue, Createdate = order.Createdate }
                );

            foreach (var item in lstCustomersOrders)
            {
                //Console.WriteLine("The Customer:" + item.Customer.Name + " purchased: " + item.Order.TotalValue.ToString("C2") +
                //" in: " + item.Order.Createdate.ToString("dd/mm/yyy"));

                Console.WriteLine("The Customer:" + item.Name + " purchased: " + item.TotalValue.ToString("C2") +
                                    " in: " + item.Createdate.ToString("dd/mm/yyy"));
            }*/

            var lstCustomersOrders = lstCustomers.GroupJoin(
                Orders,
                customer => customer.Id,
                order => order.CustomerID,
                ( customer, allOrders ) => new { Customer = customer, AllOrders = allOrders }                
                );

            foreach (var item in lstCustomersOrders)
            {
                Console.WriteLine("The Customer:" + item.Customer.Name + " purchased: ");

                foreach (var order in item.AllOrders)
                {
                    Console.WriteLine("Total Value: " + order.TotalValue.ToString("C2") +
                        " in: " + order.Createdate.ToString("dd/mm/yyy"));
                }

                
            }
        }
    }
}
