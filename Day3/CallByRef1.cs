using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.CallByRef1
{
    internal class CallByRef1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before Swwap: {a},{b}");
            swap(ref a, ref b);
            Console.WriteLine($"After Swap: {a},{b}");
            Console.ReadLine();
        }
        public static void swap(ref int a, ref int b)
        {
            int c = b;
            b = a;
            a = c;
        }
    }
}
