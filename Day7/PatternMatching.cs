using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.PatternMatching
{
    public class Employee
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public decimal Salary { get; set; }
    }
    public class Manager : Employee
    {
        public string Department { get; set; }
    }
    public class Salesman : Employee
    {
        public decimal Commission { get; set; }
    }

    internal class PatternMatching
    {
        public static void GetEmployee(Employee employee)
        {
            Console.WriteLine($"Employee # : {employee.Empno}");
            Console.WriteLine($"Employee Name : {employee.Ename}");
            Console.WriteLine($"Salary : Rs. {employee.Salary}");
            //Using Pattern Matching with is operator
            //if( employee is Manager manager)
            // Console.WriteLine($"Department : {manager.Department}");
            //if( employee is Salesman salesman)
            // Console.WriteLine($"Commission : Rs. {salesman.Commission}");
            //Using Pattern Matching with the case statement
            switch (employee)
            {
                case Manager manager:
                    Console.WriteLine($"Department : {manager.Department}");
                    break;
                case Salesman topSalesman when (topSalesman.Commission >
           topSalesman.Salary):
                    Console.WriteLine($"Commission : Rs. {topSalesman.Commission}");
                    Console.WriteLine("******** Top Salesman *********");
                    break;
                case Salesman salesman:
                    Console.WriteLine($"Commission : Rs. {salesman.Commission}");
                    break;
            }
            Console.WriteLine("------------------");
        }
        public static void Main(string[] args)
        {
            var manager = new Manager()
            {
                Empno = 101,
                Ename = "Golu",
                Salary = 100000,
                Department = "Development"
            };
            var salesman = new Salesman()
            {
                Empno = 102,
                Ename = "Akash",
                Salary = 20000,
                Commission = 5000
            };
            var salesman2 = new Salesman()
            {
                Empno = 103,
                Ename = "Vikas",
                Salary = 20000,
                Commission = 50000
            };
            GetEmployee(manager);
            GetEmployee(salesman2);
            GetEmployee(salesman);
            Console.ReadLine();
        }
    }
}
