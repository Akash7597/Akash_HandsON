using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Tuple
{
    internal class Tuple
    {
        public static (int Total, int avg, string result) GetStudentResult(int math, int phy, int csc)
        {
            int total = math + phy + csc;
            var avg = total / 3;
            var result = ((math < 60) || (phy < 60) || (csc < 60)) ? "fail" : "Pass";
            return (total, avg, result);
        }
        public static void Main(string[] args)
        {
            var report = GetStudentResult(80, 70, 60);
            var r = GetStudentResult(20, 10, 30);
            Console.WriteLine($"Total:{report.Total}");
            Console.WriteLine($"Average:{report.avg}");
            Console.WriteLine($"result:{report.result}");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Total:{r.Total}");
            Console.WriteLine($"Average:{r.avg}");
            Console.WriteLine($"result:{r.result}");
            Console.ReadLine();
        }
    }
}
