using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.NullOperator
{
    class Employee
    {
        public int Empno { get; set; }
        public string EName { get; set; }
        public decimal Salary { get; set; }
        public string job { get; set; }
        public decimal? commission { get; set; }
    }
    class company
    {
        public List<Employee> Employees;
        public company()
        {
            Employees = new List<Employee>()
            {
                new Employee()
                {
                    Empno = 1,
                    EName = "Akash",
                    Salary = 100000,
                    job = "Developer",
                    commission = null
                },
                new Employee()
                {
                    Empno = 2,
                    EName = "Vikas",
                    Salary = 1000000,
                    job = "Developer",
                    commission = null
                },
                new Employee()
                {
                    Empno = 3,
                    EName = "Priya",
                    Salary = 1000000,
                    job = "CA",
                    commission = 500
                },
            };
        }
    }
    internal class NullOperator
    {
        public static void Main(string[] args)
        {
            company com = new company();
            decimal? totalSalary = 0;
            var emp = com.Employees.SingleOrDefault(e => e.Empno == 101);
            //BEFORE NULL OPERATOR
            /*if (emp != null)
            {
                if (emp.commission != null)
                {
                    totalSalary = emp.Salary + emp.commission;
                }
                else
                {
                    totalSalary = emp.Salary;
                }
            }*/

            totalSalary = emp?.commission + emp?.Salary ?? emp?.Salary;
            Console.WriteLine($"{emp?.Empno} is earning a Total Salary of Rs. {totalSalary}");
            Console.ReadLine();
        }
    }
}
