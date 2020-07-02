using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestDistinct : ITest
    {
        public void Test()
        {            
            var lstOrders = DataBase.DataBase.GetOrders();

            foreach (var item in lstOrders)
            {
                Console.WriteLine("Customer: " + item.CustomerID);
            }

            var lstCustomersID = lstOrders.Select(order => order.CustomerID).Distinct();

            foreach (var item in lstCustomersID)
            {
                Console.WriteLine("Customer with Distinct: " + item);
            }
        }
    }
}
