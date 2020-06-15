using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using Linq_Lambda_Expressions.Model;

namespace Linq_Lambda_Expressions.DataBase
{
    public class DataBase
    {
        public DataBase()
        {
            
        }

        public static List<Customer> GetCustomers()
        {
            var lstCustomers = new List<Customer>();
            for (int i = 0; i <= 50; i++)
            {
                var objCustomer = new Customer();
                objCustomer.Id = i;
                objCustomer.Name = $"Customer {i}";
                objCustomer.Age = 19 + i;

                lstCustomers.Add(objCustomer);
            }

            return lstCustomers;
        }

        public static List<Order> GetOrders()
        {
            var lstOrders = new List<Order>();
            int CustomerID = 0;
            for (int i = 0; i <= 1000; i++)
            {
                var objOrder = new Order();

                if (CustomerID > 50)
                    CustomerID = 0;

                objOrder.Id = CustomerID;
                objOrder.CustomerID = i;
                objOrder.Createdate = DateTime.Now;
                objOrder.TotalValue = 19 * i;

                lstOrders.Add(objOrder);

                CustomerID++;
            }

            return lstOrders;
        }
    }
}
