using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.JaggedArrays
{
    internal class JaggedArrays
    {
        public static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[4] { 1, 2, 3, 4 };
            array[1] = new int[2] { 10, 20 };
            array[2] = new int[3] { 100, 200, 300 };
            for (int rowIndex = 0; rowIndex < array.Length; rowIndex++)
            {
                Console.WriteLine($"Row Index : {rowIndex}");
                for (int columnIndex = 0; columnIndex < array[rowIndex].Length; columnIndex++)
                {
                    Console.Write($"{array[rowIndex][columnIndex]} \t");
                    if (array[rowIndex].Length - 1 == columnIndex)
                        Console.WriteLine();
                }
                Console.WriteLine("------------------------");
            }
            Console.ReadLine();

        }
    }
}
