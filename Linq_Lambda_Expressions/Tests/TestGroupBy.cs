using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestGroupBy : ITest
    {
        public void Test()
        {            
            var lstOrders = DataBase.DataBase.GetOrders();

            var totalOrders = lstOrders.GroupBy(order => order.CustomerID)
                .Select(order => new
                {
                    CustomerID = order.Key,
                    TotalValue = order.Sum(order => order.TotalValue).ToString("C2"),
                    AverageValues = order.Average(order => order.TotalValue).ToString("C2"),
                    CountOrders = order.Count()
                });

            foreach (var item in totalOrders)
            {
                Console.WriteLine(item);
            }
        }
    }
}
