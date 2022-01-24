using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.CallByValue
{
    class Name
    {
        private string _FirstName, _LastName;
        public void SetName(string fname, string lname)
        {
            _FirstName = fname;
            _LastName = lname;
        }
        public string GetName()
        {
            return $"{ _FirstName} { _LastName}";
        }
    }
    internal class CallByValue
    {
        public static void Main(string[] args)
        {
            Name name = new Name();
            name.SetName("Akash", "Kumar");
            string Fullname = name.GetName();
            Console.WriteLine($"Name:{Fullname}");
            Console.ReadLine();

        }
    }
}
