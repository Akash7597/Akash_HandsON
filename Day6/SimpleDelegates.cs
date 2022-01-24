using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.SimpleDelegates
{
    public delegate int calculate(int n1, int n2);
    public class calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int mul(int x, int y)
        {
            return x * y;
        }
    }
    internal class SimpleDelegates
    {
        public static void Main(string[] args)
        {
            var calc = new calculator();
            var add = new calculate(calc.add);
            var mul = new calculate(calc.mul);

            Console.WriteLine(add(10, 20));
            Console.WriteLine(mul(10, 20));
            Console.ReadLine();
        }
    }
}
