using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class TypeCasting
    {
        public static void Main(string[] args)
        {
            int i = 12;
            double d = i;//Implicit Casting
            double d1 = 10.5;
            int i2 = (int)1;//explicit casting
            Console.WriteLine($"{i},{d},{d1},{i2}");
            Console.ReadLine();

        }
    }
}
