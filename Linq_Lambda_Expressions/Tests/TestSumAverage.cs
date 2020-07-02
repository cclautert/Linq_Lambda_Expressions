using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestSumAverage : ITest
    {
        public void Test()
        {
            var lstOrders = DataBase.DataBase.GetOrders();

            var sumTotalValues = lstOrders.Sum(order => order.TotalValue);
            Console.WriteLine("Sum TotalValue: " + sumTotalValues.ToString("C2"));

            var averageTotalValues = lstOrders.Average(order => order.TotalValue);
            Console.WriteLine("Average TotalValue: " + averageTotalValues.ToString("C2"));
            Console.WriteLine("Count Total Orders: " + lstOrders.Count());
            Console.WriteLine("Average Total Values: " + (sumTotalValues/lstOrders.Count()).ToString("C2"));

            var firstCustomer = lstOrders.Where(order => order.CustomerID == 0);

            Console.WriteLine("first Customer Sum TotalValue: " + firstCustomer.Sum(order => order.TotalValue).ToString("C2"));
            Console.WriteLine("first Customer Average TotalValue: " + firstCustomer.Average(order => order.TotalValue).ToString("C2"));
        }
    }
}
