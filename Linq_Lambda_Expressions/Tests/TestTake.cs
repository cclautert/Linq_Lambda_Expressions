using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestTake : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();

            var FirstTenCustomers = lstCustomers.Take(10);

            foreach (var item in FirstTenCustomers)
            {
                //Console.WriteLine(item.Name);
            }

            //var takeWhileCustomers = lstCustomers.TakeWhile(customer => customer.Age != 40);
            var takeWhileCustomers = lstCustomers.TakeWhile(customer => customer.Age == 40);

            foreach (var item in takeWhileCustomers)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
