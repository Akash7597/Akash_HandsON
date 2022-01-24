using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.BeforePMImplementation
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
    internal class BeforePMImplementation
    {
        public static void GetEmployee(Employee employee)
        {
            Console.WriteLine($"Employee # : {employee.Empno}");
            Console.WriteLine($"Employee Name : {employee.Ename}");
            Console.WriteLine($"Salary : Rs. {employee.Salary}");
            //Before C# 7.0
            if (employee is Manager)
            {
                var manager = (Manager)employee;
                Console.WriteLine($"Department : {manager.Department}");
            }
            var salesman = employee as Salesman;
            if (salesman != null)
            {
                Console.WriteLine($"Commission : {salesman.Commission}");
            }
            Console.WriteLine("------------------");
        }
        public static void Main(string[] args)
        {
            var manager = new Manager()
            {
                Empno = 101,
                Ename = "Akash",
                Salary = 100000,
                Department = "Development"
            };
            var salesman = new Salesman()
            {
                Empno = 102,
                Ename = "Vikas",
                Salary = 20000,
                Commission = 5000
            };
            GetEmployee(manager);
            GetEmployee(salesman);
            Console.ReadLine();
        }
    }
}
