using Day8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
Employee1.cs;

namespace Day8.EmployeeService
{
    

    internal class EmployeeService
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee()
            {
                Empno = 101,
                Ename = "Sekhar",
                Salary = 10000,
                Deptno = 10
            });
            Employees.Add(new Employee()
            {
                Empno = 102,
                Ename = "Sri",
                Salary = 14000,
                Deptno = 10
            });
            Employees.Add(new Employee()
            {
                Empno = 103,
                Ename = "Srinivas",
                Salary = 40000,
                Deptno = 20
            });
            Employees.Add(new Employee()
            {
                Empno = 104,
                Ename = "Raj",
                Salary = 50000,
                Deptno = 20
            });
            Employees.Add(new Employee()
            {
                Empno = 105,
                Ename = "Lucky",
                Salary = 15000,
                Deptno = 20
            });
            return Employees;
        }
    }
}
