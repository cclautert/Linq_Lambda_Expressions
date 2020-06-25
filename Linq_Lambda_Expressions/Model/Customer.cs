using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Lambda_Expressions.Model
{
    public class Customer
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private int _Age;
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        private int _SecondAge;
        public int SecondAge
        {
            get { Console.WriteLine("I'm this " + _Name); return _Age;  }
            set { _SecondAge = value; }
        }

        public IList<Order> Orders { get; set; }
    }
}
