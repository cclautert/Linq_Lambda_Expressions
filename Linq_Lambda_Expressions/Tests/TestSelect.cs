using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestSelect : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();

            var firstQueryCustomers = from customer in lstCustomers
                                      //select customer.Name ;
                                      //select new { customer.Id, customer.Name };
                                      select new { customer.Id, NameCustomer = customer.Name };

            foreach (var item in firstQueryCustomers)
            {
                //Console.WriteLine(item.NameCustomer);
            }

            var secondQuerywithLambda = lstCustomers
                                        //.Select(c => c.Name);
                                        //.Select(c => new { c.Id, c.Name });
                                        //.Select(c => new { c.Id, nameCustomer = c.Name });
                                        .Select(c => new { Description = "Customer Name: " + c.Name + " Age: " + c.Age});

            foreach (var item in secondQuerywithLambda)
            {
                //Console.WriteLine(item.nameCustomer);
                Console.WriteLine(item.Description);
            }
        }
    }
}
