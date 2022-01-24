using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.SealedClass
{
    class BaseClass
    {
        public void dog()
        {
            Console.WriteLine("Barking");
        }
    }
    interface Iface
    {
        void says();
    }
    sealed class ABC : BaseClass
    {
        public void says()
        {
            Console.WriteLine("End of converstion");
        }
    }
    internal class SealedClass
    {
        public static void Main(string[] args)
        {
            ABC A = new ABC();
            A.dog();
            A.says();
            Console.ReadLine();
        }
    }
}
