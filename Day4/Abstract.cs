using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Abstract
{
    abstract class AbstractClass
    {
        public void MethodWithDefination()
        {
            Console.WriteLine("Method with defined at abstract class level");
        }
        public abstract void MethodWithoutDefination();
    }
    class DerivedClass : AbstractClass
    {
        public override void MethodWithoutDefination()
        {
            Console.WriteLine("Method Without defination of AC defined at Derived class");
        }
    }

    public class Abstract
    {
        public static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.MethodWithDefination();
            dc.MethodWithoutDefination();
            Console.ReadLine();
        }
    }
}
