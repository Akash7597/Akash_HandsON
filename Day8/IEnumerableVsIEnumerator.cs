using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.IEnumerableVsIEnumerator
{
    internal class IEnumerableVsIEnumerator
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i + 1);
            }
            IEnumerable<int> iEnumerableNumbers = numbers;
            foreach (var no in iEnumerableNumbers)
            {
                Console.Write($"{no}\t");
            }
            IEnumerator<int> iEnumeratorNumbers = numbers.GetEnumerator();
            //foreach (var no in iEnumeratorNumbers)
            //{
            // Console.Write($"{no\t}");
            //}
            Console.WriteLine("\n---------------------------");
            while (iEnumeratorNumbers.MoveNext())
            {
                Console.Write($"{iEnumeratorNumbers.Current}\t");
            }
            Console.ReadLine();
        }
    }
}
