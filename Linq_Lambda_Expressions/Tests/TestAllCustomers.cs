using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestAllCustomers : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();

            foreach (var item in lstCustomers)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
