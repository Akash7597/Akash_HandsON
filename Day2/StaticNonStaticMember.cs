using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.StaticNonStaticMember
{
    class Test
    {
        public int a; //non static Member

        public static int b; //static Member
    }
    internal class StaticNonStaticMember
    {
        public static void Main(string[] args)
        {
            Test.b = 1;
            Test t1 = new Test();
            t1.a = 1000;
            Console.WriteLine($"{Test.b},{t1.a}");
            Console.ReadLine();
        }
    }
}
