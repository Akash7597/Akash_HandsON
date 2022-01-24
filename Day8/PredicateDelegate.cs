using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.PredicateDelegate
{
    internal class PredicateDelegate
    {
        public static void Main(string[] args)
        {
            Predicate<int> IsGreater = new Predicate<int>(IsGreaterThan100);
            var no = 150;
            Console.WriteLine($"Is {no} > 100 ? {IsGreater(no)}");
            Console.ReadLine();
        }
        private static bool IsGreaterThan100(int value)
        {
            return value > 100;
        }
    }
}
