using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.GenericsClass1
{
    class Employee
    {
        public int Empno { get; set; }
        public string Ename { get; set; }
        public decimal Salary { get; set; }
    }
    class Department
    {
        public int Deptno { get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }
    }
    public class DBService<T>
    {
        public void Add(T t)
        {
            Console.WriteLine($"Adding Record to Table : {typeof(T)}");
        }
    }

    internal class GenericsClass1
    {
        public static void Main(string[] args)
        {
            DBService<Employee> employee = new DBService<Employee>();
            employee.Add(new Employee());
            DBService<Department> department = new DBService<Department>();
            department.Add(new Department());
            Console.ReadLine();
        }
    }
}
