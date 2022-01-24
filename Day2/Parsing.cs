using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Parsing
{
    internal class Parsing
    {
        public static void Main(string[] args)
        {
            int empno;
            string ename;
            decimal salary;
            DateTime hireDate;
            Console.Write("Enter Employee id # :");
            empno = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name :");
            ename = Console.ReadLine();
            Console.Write("Salary :");
            
            salary = decimal.Parse(Console.ReadLine());
            hireDate = DateTime.Now; //Assigns current date and time
            Console.WriteLine("------------------------");
            Console.WriteLine($"Employe Number : {empno}\nEmployee Name : {ename}\n" +
            $"Salary : {salary}\nHiredate : {hireDate}");
            Console.ReadLine();
        }
    }
}
