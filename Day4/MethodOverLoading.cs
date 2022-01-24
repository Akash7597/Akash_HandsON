using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.MethodOverLoading
{
    class Parent
    {
        public virtual void Property()
        {
            Console.WriteLine("Use property for business");
        }
    }
    class Children : Parent
    {
        public override void Property()
        {
            //base.Property();
            Console.WriteLine("use property for school");
        }
    }
    internal class MethodOverLoading
    {
        public static void Main(string[] args)
        {
            Children c = new Children();
            c.Property();
            Console.ReadLine();
        }
    }
}
