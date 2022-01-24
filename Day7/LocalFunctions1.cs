using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.LocalFunctions1
{
    internal class LocalFunctions1
    {
        public static void Main(string[] args)
        {
            int no1 = 10;
            int no2 = 20;
            int add(int n1, int n2)
            {
                return n1 + n2;
            }
            int result = add(no1, no2);
            Console.WriteLine($"Sum of {no1} and {no2} = {result}");
            void FirstSetOfTask()
            {
                Console.WriteLine("Set of Instructions to Complete Task1");
            }
            void SecondSetOfTask()
            {
                Console.WriteLine("Set of Instructions to Complete Task2");
            }
            void ThirdSetOfTask()
            {
                Console.WriteLine("Set of Instructions to Complete Task3");
            }
            FirstSetOfTask();
            SecondSetOfTask();
            ThirdSetOfTask();
            Console.ReadLine();
        }
        //public static void AnotherMethod()
        //{
        // FirstSetOfTask(); Error
        //}
        //We cannot access the Local Functions outside of the Function where it has been defined.

    }
}
