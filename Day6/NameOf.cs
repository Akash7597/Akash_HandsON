using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.NameOf
{
    internal class NameOf
    {
        public static void Main(string[] args)
        {
            string a = "Akash";
            Console.WriteLine($"a varible got modified");
            Console.WriteLine($"{nameof(a)} Got Modified");

            Console.WriteLine(nameof(List<int>));

            var num = new List<int> { 1, 2, 3, 4 };

            Console.WriteLine(nameof(num));
            Console.WriteLine(nameof(num.Count));
            Console.ReadLine();
        }
    }
}
