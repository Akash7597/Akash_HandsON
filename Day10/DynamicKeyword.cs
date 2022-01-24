using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.DynamicKeyword
{
    class TestDynamic
    {
        public dynamic MyProperty { get; set; }
    }

    internal class DynamicKeyword
    {
        public static void Main(string[] args)
        {
            dynamic value;
            value = 100;
            Console.WriteLine($"Value : {value}");
            value = "C#.NET";
            Console.WriteLine($"Updated Value : {value}");
            var td1 = new TestDynamic() { MyProperty = 1000 };
            Console.WriteLine(td1.MyProperty);
            var td2 = new TestDynamic() { MyProperty = ".NET - Rocks" };
            Console.WriteLine(td2.MyProperty);
            Console.ReadLine();
        }
    }
}
