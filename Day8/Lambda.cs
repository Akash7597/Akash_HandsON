using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Lambda
{
    internal class Lambda
    {
        public static void Main(string[] args)
        {
            
            Func<int, int> square = no => no * no;
            Console.WriteLine(square(4));
            Func<int, int, int> calculate = (no1, no2) => no1 + no2;
            Console.WriteLine($"Total : {calculate(10, 20)}");
            var numbers = new List<int>() { 10, 15, 20, 35, 40, 30, 45, 50 };
            var SquaredNumbers = numbers.Select(no => no * no);
            foreach (var no in SquaredNumbers)
            {
                Console.Write($"{no}\t");
            }
            Console.WriteLine("\n------------");
            var evenNumbers = numbers.FindAll(no => (no % 2) == 0);
            foreach (var no in evenNumbers)
            {
                Console.Write($"{no}\t");
            }
            Console.ReadLine();
        }
       
    }
}

