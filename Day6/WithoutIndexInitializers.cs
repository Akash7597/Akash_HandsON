using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.WithoutIndexInitializers
{
    class Employee
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public decimal Salary { get; set; }
    }
    internal class WithoutIndexInitializers
    {
        public static void Main(string[] args)
        {
            Dictionary<int, List<Employee>> Employees = new Dictionary<int, List<Employee>>()
            {
                {10, new List<Employee>()
                {
                     new Employee(){ Empno=101, Ename ="Akash", Salary=20000},
                     new Employee(){ Empno=102, Ename ="Kumar", Salary=10000},
                }
                },
                {20, new List<Employee>()
                    {
                         new Employee(){ Empno=104, Ename ="Vikas", Salary=25000},
                         new Employee(){ Empno=103, Ename ="Kumar", Salary=15000}
                    }
                },
            };
            Employees.TryGetValue(20, out var employees);
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee # :{employee.Empno}");
                Console.WriteLine($"Employee Name :{employee.Ename}");
                Console.WriteLine($"Salary : Rs. {employee.Salary}");
                Console.ReadLine();
            }
        }
    }
}
