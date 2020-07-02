using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestAny : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();
            var lstOrders = DataBase.DataBase.GetOrders();

            var bigOrders = lstOrders.Where(order => order.TotalValue > 50000);

            //if (bigOrders.Any())
            //{
            //    Console.WriteLine("Quantas Orders: " + bigOrders.Count());
            //}
            //else
            //    Console.WriteLine("Não");

            Console.WriteLine("Quantas Orders: " + bigOrders != null ? bigOrders.Count() : 0 );
        }
    }
}
