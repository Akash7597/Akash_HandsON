using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.ObjectInitialization
{
    class Employee
    {
        public int EmpID, DeptNo, Salary;
        public string EName, Job;
        public static int TotalEmployee;

        public Employee()
        {
            TotalEmployee += 1;
        }
    }
    internal class ObjectInitialization
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                EmpID = 1,
                DeptNo = 101,
                Salary = 50000,
                EName = "Akash",
                Job = "Developer",
            };
            Employee e2 = new Employee()
            {
                EmpID = 2,
                DeptNo = 102,
                Salary = 50000,
                EName = "Vikas",
                Job = "Developer",
            };
            Console.WriteLine($"Total Employee:{Employee.TotalEmployee}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Employee Details:\n Employee ID:{e1.EmpID}\n" +
                                $"Department No:{e1.DeptNo}\nSalary:{e1.Salary}\nName:{e1.EName}\nJob:{e1.Job}\n");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Employee Details:\n Employee ID:{e2.EmpID}\n Department NO:{e2.DeptNo}\n" +
                                 $"Salary:{e2.Salary}\nName:{e2.EName}\nJob:{e2.Job}\n");

            Console.ReadLine();
    
        }
    }
}
