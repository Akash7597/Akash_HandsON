using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.SealedClass1
{
    class BaseClass
    {
        public void MyMethod()
        {
            Console.WriteLine("Messsage from C# Session:");
        }
    }
    interface IFace
    {
        void Says();
    }
    sealed class NotInheritableClass : BaseClass, IFace
    {
        public void Says()
        {
            Console.WriteLine("End of C# Fundamentals");
        }
    }
    //class OtherClass : NotInheritableClass
    //{
    //}
    internal class SealedClass1
    {
        public static void Main(string[] args)
        {
            NotInheritableClass nic = new NotInheritableClass();
            nic.MyMethod();
            nic.Says();
            Console.ReadLine();
        }
    }
}
