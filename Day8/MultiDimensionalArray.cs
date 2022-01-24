using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.MultiDimensionalArray
{
    internal class MultiDimensionalArray
    {
        public static void Main(string[] args)
        {
            int[,] data = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            for (int r = 0; r < 3; r++)
            {
                Console.Write("[ ");
                for (int c = 0; c < 2; c++)
                {
                    Console.Write($"{data[r, c]} ");
                }
                Console.WriteLine("]");
            }
            Console.ReadLine();

        }
    }
}
