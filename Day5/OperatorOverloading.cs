using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.OperatorOverloading
{
    class complex
    {
        public int x, y;
        public complex() { }

        public complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static complex operator +(complex obj1, complex obj2)
        {
            var obj = new complex();
            obj.x = obj1.x + obj2.x;
            obj.y = obj1.y + obj2.y;
            return obj;
        }
    }
    internal class OperatorOverloading
    {
        public static void Main(string[] args)
        {
            var c1 = new complex(10, 20);
            var c2 = new complex(100, 200);
            var c3 = c1 + c2;
            //var c4= c2 + c3;

            Console.WriteLine($"C1 Object: {c1.x},{c1.y}");
            Console.WriteLine($"C2 object: {c2.x},{c2.y}");
            Console.WriteLine($"C3 object: {c3.x},{c3.y}");
            Console.ReadLine();
        }
    }
}
