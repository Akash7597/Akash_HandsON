using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.FuncDelegate
{
    internal class FuncDelegate
    {
        public static void Main(string[] args)
        {
            //ConvertMethod convert = new ConvertMethod(UpperCaseString);
            //Instantiate delegate to reference the uppercasestring method
            //Func<string, string> convert = new Func<string, string>(UpperCaseString);
            Func<string, string> convert = UpperCaseString;
            string name = "C# popularly called as csharp.net";
            //Console.WriteLine(convert.Invoke(name));
            Console.WriteLine(convert(name));
            Func<int, int, int> add = add2numbers;
            Console.WriteLine(add(10, 20));
            Func<int, string, decimal, string> ShowEmployee = ShowEmployeeDetails;
            Console.WriteLine(ShowEmployee(101, "Akash", 10000));
            Console.ReadLine();
        }
        private static string ShowEmployeeDetails(int empno, string ename, decimal salary)
        {
            return $"Employee # : {empno}\nEmployee Name : {ename}\nSalary : {salary}";
        }
        public static string UpperCaseString(string input)
        {
            return input.ToUpper();
        }
        public static int add2numbers(int no1, int no2)
        {
            //return $"Sum of {no1} and {no2} = {(no1 + no2)}";
            return no1 + no2;
        }

    }
}
