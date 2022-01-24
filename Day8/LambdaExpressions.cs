using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.LambdaExpressions
{
    internal class LambdaExpressions
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>(); //create a list of string values
            names.Add("Akash");
            names.Add("Kumar");
            names.Add("Vikas");
            string result = names.Find(SearchName);
            if (result == null)
                Console.WriteLine("Name not Found...");
            else
                Console.WriteLine("Name Found...");

            Console.ReadLine();
        }
        private static bool SearchName(string name)
        {
            var result = name.Equals("Akash");
            Console.WriteLine($"Result : {result} ");
            return result;
        }

    }
}
