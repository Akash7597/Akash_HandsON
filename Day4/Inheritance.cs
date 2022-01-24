using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Inheritance
{
    internal class Inheritance
    {
        class ParentClass
        {
            public ParentClass()
            {
                Console.WriteLine("Parent class zero argument constructor invoked");
            }
        }
        class ChildClass : ParentClass
        {
            public ChildClass()
            {
                Console.WriteLine("Child class zero argument constructor invoked");
            }
        }
        public static void Main(string[] args)
        {

            ChildClass c1 = new ChildClass();
            Console.ReadLine();
        }
    }
}
