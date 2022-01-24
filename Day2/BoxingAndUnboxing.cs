using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.BoxingAndUnboxing
{
    internal class BoxingAndUnboxing
    {
        public static void Main(string[] args)
        {
            int a = 10;// Value type
            object o; //Reference type

            int b = a;
            o = b;

            int c;
            c = (int)o;
            Console.WriteLine($"{a},{b},{c},{o}");
            Console.ReadLine();
        }
    }
}
