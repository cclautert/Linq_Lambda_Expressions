using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Lambda_Expressions.Model
{
    public class Order
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _CustomerID;
        public int CustomerID
        {
            get { return _CustomerID; }
            set { _CustomerID = value; }
        }

        private DateTime _Createdate;
        public DateTime Createdate
        {
            get { return _Createdate; }
            set { _Createdate = value; }
        }

        private decimal _TotalValue;
        public decimal TotalValue
        {
            get { return _TotalValue; }
            set { _TotalValue = value; }
        }

        public Customer Customer { get; set; }
    }
}
