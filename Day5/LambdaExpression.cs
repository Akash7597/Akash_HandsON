using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.LambdaExpression
{
    internal class LambdaExpression
    {
        public static void Main(string[] args)
        {
            var addition = (int no1, int no2) => no1 + no2; //Lambda Expression
            Console.WriteLine($"Result : {addition.Invoke(10, 20)}");

        }
    }
}
