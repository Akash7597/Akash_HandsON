using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Constructor
{
    class Department
    {
        public decimal DeptNO;
        public string DName;
        public string Location;
        public static int TotalDepartment;// static member
        static Department() //Static constructor
        {
            TotalDepartment = 0;
        }
        public Department(decimal Dno, string Dname, string loc)// Non- Static constructor
        {
            DeptNO = Dno;
            DName = Dname;
            Location = loc;
            TotalDepartment += 1;

        }
    }
        internal class Constructor
    {
        public static void Main(string[] args)
        {
                Department d1 = new Department(1, "Akash", "Delhi");
                Department d2 = new Department(2, "Vikas", "Jaipur");
                Console.WriteLine($"TotalDepartMent:{Department.TotalDepartment}");
                Console.WriteLine("-------------");
                Console.WriteLine($"Department number:{d1.DeptNO}\nDepartName: {d1.DName}\nlocation:{d1.Location}");
                Console.WriteLine("---------------------");
                Console.WriteLine($"\nDepartment number:{d2.DeptNO}\nDepartName: {d2.DName}\nlocation:{d2.Location}");
                Console.ReadLine();
            }
    }
}
