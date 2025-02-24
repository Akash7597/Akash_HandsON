﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.NamedParameters
{
    class Employee
    {
        private int _Empno, _Deptno;
        private string _Ename, _Job;
        private decimal _Salary, _Commission;
        public void SetEmployee(int eno, string ename, decimal salary, decimal comm = 0, int dno = 1000,
        string job = "Salesman")
        {
            _Empno = eno;
            _Ename = ename;
            _Salary = salary;
            _Commission = comm;
            _Deptno = dno;
            _Job = job;
        }
        public void ShowEmployee()
        {
            Console.WriteLine($"Employee # : {_Empno}\nEmployee Name : { _Ename}\nSalary: { _Salary}\n" +
                $"Commission : {_Commission}\nDepartment # : {_Deptno}\nJob : {_Job}");
            Console.WriteLine("--------------------------");
            
        }
    }
    internal class NamedParameters
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.SetEmployee(101, "Akash", 1500);
            emp1.ShowEmployee();
            Employee emp2 = new Employee();
            emp2.SetEmployee(102, "Vikas", 25000, dno: 2000, job: "Developer");
            emp2.ShowEmployee();
            Console.ReadLine();

        }
    }
}
