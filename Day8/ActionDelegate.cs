using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.ActionDelegate

{
    internal class ActionDelegate
    {
        //public delegate void GetName(string fn, string ln);
        public static void Main(string[] args)
        {
            //GetName GetFullName = new GetName(ShowFullName);
            Action<string, string> GetFullName = new Action<string, string>(ShowFullName);
            GetFullName("Akash", "Kumar");
            Console.ReadLine();
        }
        private static void ShowFullName(string fname, string lname)
        {
            Console.WriteLine($"Full Name : {fname} {lname}");
        }

    }
}
