using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestContains : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();

            //var customersIDs = lstCustomers.Select(customer => customer.Id);

            //if (customersIDs.Contains(1))
            //{
            //    Console.WriteLine("ther is a Customer with ID = 1");
            //}
            //else
            //{
            //    Console.WriteLine("ther is not a Customer with ID = 1");
            //}

            var customersNames = lstCustomers.Select(customer => customer.Name);

            if (customersNames.Contains("Customer 0"))
            {
                Console.WriteLine("ther is a Customer with name = 0");
            }
            else
            {
                Console.WriteLine("ther is not a Customer with name = 0");
            }
        }
    }
}
