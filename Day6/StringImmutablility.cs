using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.StringImmutablility
{
    internal class StringImmutablility
    {
        public static void Main(string[] args)
        {
            string s1 = "c#";
            string s2 = s1;
            string s3 = "Akash";
            string s4 = "vikas";

            Console.WriteLine($"s1==s2:{(s1 == s2)}");
            Console.WriteLine($"s3==s4:{(s3 == s4)}");
            Console.WriteLine($"object Reference:{object.ReferenceEquals(s1, s2)}");
            Console.WriteLine("-------------------------");

            s1 += ".Net";
            Console.WriteLine($"Value of S1:{s1}");
            Console.WriteLine($"Value of S2:{s2}");
            Console.WriteLine("---------------------");

            Console.WriteLine($"object Reference:{object.ReferenceEquals(s3, s4)}");
            Console.WriteLine("-------------------------");

            Console.WriteLine($"object Address:{s1.GetHashCode()}");
            Console.WriteLine($"object Address:{s2.GetHashCode()}");

            Console.WriteLine($"object Address:{s3.GetHashCode()}");
            Console.WriteLine($"object Address:{s4.GetHashCode()}");

            Console.ReadLine();
        }
    }
}
