using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestLast : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();

            //var lastCustomer = lstCustomers.Last();
            //var errorCustomer = lstCustomers.Last(customer => customer.Id < 0);
            var errorCustomer = lstCustomers.LastOrDefault(customer => customer.Id < 0);
            Console.WriteLine(errorCustomer != null ? errorCustomer.Name : "No Customer");

            var customerWithAge = lstCustomers.LastOrDefault(customer => customer.Age < 40);
            Console.WriteLine(customerWithAge != null ? customerWithAge.Name : "No Customer > 40");
        }
    }
}
