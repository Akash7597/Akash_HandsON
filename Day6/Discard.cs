using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Discard
{
    internal class Discard
    {
        public static void Result(int x, int y, out int sum, out int dif, out int multiply, out int div)
        {
            sum = x + y;
            dif = x - y;
            multiply = x * y;
            div = x / y;
        }
        public static void Main(string[] args)
        {
            int no1 = 10;
            int no2 = 20;
            Result(no1, no2, out int _, out int _, out int product, out int _);
            Console.WriteLine($"Product of {no1} and {no2} = {product}");
            Console.ReadLine();
        }
    }
}
