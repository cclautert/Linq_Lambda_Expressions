using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestTarefa2 : ITest
    {
        public void Test()
        {
            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape", "strawberry" };

            var lstFruitsMinorEquals5 = fruits.Where(fruit => fruit.Length <= 5);

            foreach (var item in lstFruitsMinorEquals5)
            {
                Console.WriteLine(item);
            }
        }
    }
}
