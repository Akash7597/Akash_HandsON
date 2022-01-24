using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.StaticNonStaticTask
{
    class Students
    {
        public int studentId;
        public string name, courseName;
        public decimal fees;
        public static int totalStudents;
    }

    internal class StaticNonStaticTask
    {
        public static void Main(string[] args)
        {
            Students s1 = new Students();
            Students.totalStudents += 1;
            s1.studentId = 101;
            s1.name = "Akash";
            s1.courseName = "C#";
            s1.fees = 10000;
            Students s2 = new Students();
            Students.totalStudents += 1;
            s2.studentId = 102;
            s2.name = "Vikas";
            s2.courseName = "ASP.NET Core";
            s2.fees = 18000;
            Console.WriteLine($"Total Student Details :{Students.totalStudents}");
            Console.WriteLine($"S1 : {s1.studentId}, {s1.name}, {s1.courseName}, {s1.fees}");
            Console.WriteLine($"S2 : {s2.studentId}, {s2.name}, {s2.courseName}, {s2.fees}");
            Console.ReadLine();
        }
    }
}
