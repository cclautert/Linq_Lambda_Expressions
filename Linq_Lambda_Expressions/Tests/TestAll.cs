using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestAll : ITest
    {
        public void Test()
        {
            var lstCustomers = DataBase.DataBase.GetCustomers();

            var allCustomersWithIDGraterThanZero = lstCustomers.All(customer => customer.Id >= 0);

            if (allCustomersWithIDGraterThanZero)
            {
                Console.WriteLine("All customers are with ID equal or greater than zero.");
            }
            else
            {
                Console.WriteLine("All customers are not with ID equal or greater than zero");
            }


            var allCustomersWithAgeGraterThanTwenty = lstCustomers.All(customer => customer.Age > 20);

            if (allCustomersWithAgeGraterThanTwenty)
            {
                Console.WriteLine("All customers are with Age greater than 20.");
            }
            else
            {
                Console.WriteLine("All customers are not with Age greater than 20");
            }
        }
    }
}
