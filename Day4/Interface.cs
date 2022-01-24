using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Interface
{
    interface Ifather
    {
        void Loan();
    }
    interface Imother
    {
        void Loan();
    }
    class child2 : Ifather, Imother
    {
        void Ifather.Loan()
        {
            Console.WriteLine("30% I child2 will pay");
        }
        void Imother.Loan()
        {
            Console.WriteLine("50% Child 2 will Pay");
        }
    }
    class child1 : Ifather, Imother
    {
        public void Loan()
        {
            Console.WriteLine("Remainning Child1 Will Pay");
        }
    }
    internal class Interface
    {
        public static void Main(string[] args)
        {
            child1 c1 = new child1();
            c1.Loan();

            child2 c2 = new child2();
            Ifather father = c2 as Ifather;
            Imother mother = c2 as Imother;
            father.Loan();
            mother.Loan();
            Console.ReadLine();
        }
    }
}
