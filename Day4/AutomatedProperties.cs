using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.AutomatedProperties
{
    //class Name
    //{
    // private string _FirstName;
    // public string FirstName
    // {
    // set
    // {
    // _FirstName = value;
    // }
    // get
    // {
    // return _FirstName;
    // }
    // }
    // private string _LastName;
    // public string LastName
    // {
    // set
    // {
    // _LastName = value;
    // }
    // get
    // {
    // return _LastName;
    // }
    // }
    //}

    class Name
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }

    }
    internal class AutomatedProperties
    {
        public static void Main(string[] args)
        {
            Name N1 = new Name() { _firstName = "Akash", _lastName = "Kumar" };
            Console.WriteLine($"Full Name:{N1._firstName}{N1._lastName}");
            Console.ReadLine();
        }
    }
}
