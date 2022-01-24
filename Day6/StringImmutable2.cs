using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.StringImmutable2
{
    internal class StringImmutable2
    {
        public static void Main(string[] args)
        {
            string s1 = "C#";
            string s2 = s1;
            Console.WriteLine($"Value of S1 : {s1}");
            Console.WriteLine($"Value of S2 : {s2}");
            Console.WriteLine($"S1 Object Address : {s1.GetHashCode()}");
            Console.WriteLine($"S2 Object Address : {s2.GetHashCode()}");
            s1 += ".NET";
            Console.WriteLine("----------------");
            Console.WriteLine($"Value of S1 : {s1}");
            Console.WriteLine($"Value of S2 : {s2}");
            Console.WriteLine($"S1 Object Address : {s1.GetHashCode()}");
            Console.WriteLine($"S2 Object Address : {s2.GetHashCode()}");
            Console.ReadLine();
        }
    }
}
