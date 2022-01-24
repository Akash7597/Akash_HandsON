using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.SingleDimensionalArray
{
    internal class SingleDimensionalArray
    {
        public static void Main(string[] args)
        {
            int[] num = new int[5];
            num[0] = 10;
            num[1] = 100;
            num[2] = 20;
            num[3] = 200;
            num[4] = 30;
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"{num[i]}");
            }
            Console.WriteLine("------------");
            string[] names = new string[] { "Akash", "Kumar", "Vikas" };
            Console.WriteLine($"Total Names : {names.Length}");
            Console.ReadLine();

        }
    }
}
