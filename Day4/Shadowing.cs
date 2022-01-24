using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Shadowing
{
    class Parent
    {
        public void Property()
        {
            Console.WriteLine("use for business");
        }
    }
    class Children : Parent
    {
        public new void Property()
        {
            Console.WriteLine("Use for charity");
        }
    }
    internal class Shadowing
    {
        public static void Main(string[] args)
        {
            Children c1 = new Children();
            c1.Property();
            Children c2 = new Children();
            c2.Property();
            Console.ReadLine();
        }
    }
}
