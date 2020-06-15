using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestSingle : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();

            //var customerWithAge = lstCustomers.Single(customer => customer.Age == 19);
            //var customerWithAge = lstCustomers.Single(customer => customer.Age == 10);
            //var customerWithAge = lstCustomers.SingleOrDefault(customer => customer.Age == 10);

            //Console.WriteLine(customerWithAge != null ? customerWithAge?.Id + " - " + customerWithAge?.Name + " Age: " + customerWithAge?.Age : "Não existe esta condição");


            //var customerWithFirst = lstCustomers.First(customer => customer.SecondAge == 19);
            var customerWithsingle = lstCustomers.Single(customer => customer.SecondAge == 19);
        }
    }
}
