using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.ListCollection

{
    internal class ListCollection
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30 };
            //To add an item to the list
            numbers.Add(40);
            numbers.Insert(1, 15);
            numbers.ForEach(no => Console.WriteLine($"{no}"));
            Console.WriteLine("---------------");
            //To remove an item from the list
            numbers.RemoveAt(2); // Remove the item based on the index of the item
                                 //numbers.Remove(15); //Remove the item based on the item / object
            numbers.ForEach(no => Console.WriteLine($"{no}"));
            Console.WriteLine("---------------");
            var less30 = from no in numbers
                         where no < 30
                         select no;
            foreach (var no in less30)
            {
                Console.WriteLine(no);
            }
            var employees = new EmployeeService().GetEmployees();
            IEnumerable<Employee> dept10Employees = from emp in employees
                                                    where emp.Deptno == 10
                                                    select emp;
            foreach (var emp in dept10Employees)
            {
                Console.WriteLine($"Employee # : {emp.Empno}\n" +
                $"Employee Name : {emp.Ename}\nSalary : {emp.Salary}\n" +
                $"Department # : {emp.Deptno}");
            }

        }
    }
}
