using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.StringImmutable1
{
    internal class StringImmutable1
    {
        public static void Main(string[] args)
        {
            string s1 = "C#";
            string s2 = s1;
            Console.WriteLine($"s1 == s2 : {(s1 == s2)}");
            Console.WriteLine($"Object Reference : {object.ReferenceEquals(s1, s2)}");
            Console.WriteLine($"S1 Object Address : {s1.GetHashCode()}");
            Console.WriteLine($"S2 Object Address : {s2.GetHashCode()}");
            Console.ReadLine();
        }
    }
}
