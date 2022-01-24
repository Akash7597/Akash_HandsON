using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.DefaultMethod
{
    interface IFace
    {
        public void MyDefaultMethod()
        {
            Console.WriteLine("MyDefault of interface has been implemented at interface");
        }
        void AbstractMethod();
    }
    class DerivedClass1:IFace
    {
        public void AbstractMethod()
        {
            Console.WriteLine("Abstract method of interface has been implemented at derived class");
        }
    }

    class DerivedClass2 : IFace
    {
        public void AbstractMethod()
        {
            Console.WriteLine("Abstract method of interface has been implemented at derived class");
        }
        public void MyDefaultMethod()
        {
            Console.WriteLine("MyDefault of interface has been implemented at Derived class");
        }
    }

    public class DefaultMethod
    {
       public static void Main(string[] args)
        {
            IFace dc1=new DerivedClass1();
            dc1.MyDefaultMethod();

            DerivedClass2 dc2=new DerivedClass2();
            dc2.MyDefaultMethod();
            dc2.AbstractMethod();
        }
    }
}
