using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.AnonymousMethod
{
    internal class AnonymousMethod
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>(); //create a list of string values
            names.Add("Akash");
            names.Add("Kumar");
            names.Add("Golu");
            string result = names.Find(
            delegate (string name)
            {
                return name.Equals("Akash");
            }
            );
            if (result == null)
                Console.WriteLine("Name not Found...");
            else
                Console.WriteLine("Name Found...");
            Console.ReadLine();

        }
    }
}
