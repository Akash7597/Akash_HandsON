using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day7.ThrowsException
{
    class Name
    {
        private string _FirstName;
        public string FirstName
        {
            set
            {
                if (value.Length > 2)
                {
                    var result = Regex.Match(value, "/^[A-Za-z]+$/{2,}");
                    if (result.Success)
                        _FirstName = value;
                    else
                        throw new Exception("Error while Providing the Value for FirstName");
                }
                else
                {
                    throw new Exception("First Name Length Cant Be Less Than 2 Charecters");
                }
            }
            get
            {
                return _FirstName;
            }
        }
        private string _LastName;
        public string LastName
        {
            set
            {
                if (value.Length > 2)
                {
                    var result = Regex.Match(value, "/^[A-Za-z]+$/{2,}");
                    if (result.Success)
                        _LastName = value;
                    else
                        throw new Exception("Error while Providing the Value for Last Name");
                }
                else
                {
                    throw new Exception("Last Name Length Cant Be Less Than 2 Charecters");
                }
            }
            get
            {
                return _LastName;
            }
        }
    }
    internal class ThrowsException
    {
        public static void Main(string[] args)
        {
            try
            {
                Name name = new Name();
                Console.Write("Enter Value for First Name :");
                name.FirstName = Console.ReadLine();
                Console.Write("Enter Value for Last Name :");
                name.LastName = Console.ReadLine();
                Console.WriteLine($"Guest Name : {name.FirstName} {name.LastName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
