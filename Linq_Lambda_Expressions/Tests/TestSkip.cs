using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestSkip : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();

            var lstSkipCustomers = lstCustomers.Skip(10);

            foreach (var item in lstSkipCustomers)
            {
                Console.WriteLine(item.Name);
            }

            var lstSkipWhileCustomers = lstCustomers.SkipWhile(c => c.Age != 40);

            foreach (var item in lstSkipWhileCustomers)
            {
                Console.WriteLine("SkipWhile: " + item.Name + " Age: " + item.Age);
            }
        }
    }
}
