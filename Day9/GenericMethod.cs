using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.GenericMethod
{
    internal class GenericMethod
    {
        public static void Swap<T>(ref T arg1, ref T arg2)
        {
            T temp;
            temp = arg1;
            arg1 = arg2;
            arg2 = temp;
        }
        public static void Main(string[] args)
        {
            int no1 = 100;
            int no2 = 200;
            Console.WriteLine($"Before Swap : {no1} , {no2}");
            Swap<int>(ref no1, ref no2);
            Console.WriteLine($"After Swap : {no1} , {no2}");
            string s1 = "C#.NET";
            string s2 = "Rocking";
            Console.WriteLine($"Before Swap : {s1} {s2}");
            Swap<string>(ref s1, ref s2);
            Console.WriteLine($"After Swap : {s1} {s2}");
            Console.ReadLine();
        }
    }
}
