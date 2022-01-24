using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.MutilevelInheritance
{
    class BaseClass
    {
        public BaseClass(string name)
        {
            Console.WriteLine($"Base class parameterized constructor invoked:{name}");
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass() : base("Akash")
        {
            Console.WriteLine($"Derived class zero argument constructor invoked");
        }
        public DerivedClass(string name) : base(name)
        {
            Console.WriteLine($"Derived class Parameterized constructor invoked: {name}");
        }
    }
    internal class MutilevelInheritance
    {
        public static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();   
            Console.ReadLine();
        }
    }
}
