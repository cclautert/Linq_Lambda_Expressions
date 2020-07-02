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
            //ITest test = new TestJoin();
            //ITest test = new TestSelectMany();
            //ITest test = new TestOrderBy();
            //ITest test = new TestWhere();
            //ITest test = new TestAny();
            //ITest test = new TestContains();
            //ITest test = new TestAll();
            //ITest test = new TestDistinct();]
            //ITest test = new TestTarefa2();
            //ITest test = new TestCountMaxMin();
            //ITest test = new TestSumAverage();
            //ITest test = new TestGroupBy();
            ITest test = new TestUnion();
            test.Test();

            Console.ReadLine();
        }
    }
}
