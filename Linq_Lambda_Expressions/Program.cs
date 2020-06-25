using Linq_Lambda_Expressions.Testes;
using Linq_Lambda_Expressions.Tests;
using System;

namespace Linq_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //ITest test = new TestAllCustomers();
            //ITest test = new TestSelect();
            //ITest test = new TestSingle();
            //ITest test = new TestLast();
            //ITest test = new TestTake();
            //ITest test = new TestSkip();
            ITest test = new TestJoin();
            test.Test();

            Console.ReadLine();
        }
    }
}
