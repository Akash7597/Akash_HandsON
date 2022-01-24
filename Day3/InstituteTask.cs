using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.InstituteTask
{
    class Institute
    {
        private string CourseName;
        private Decimal Fees;

        public void SetCourse(String CName, Decimal Fs)
        {
            this.CourseName = CName;
            this.Fees = Fs;
        }
        public string GetCourse()
        {
            return $"{CourseName},{Fees}";
        }
        public void GetDiscount(decimal Percentage, out decimal Discount)
        {
            Discount = Percentage * 10;
        }
        public void UpdateCourseFees(ref decimal Fs, Decimal Discount)
        {
            Fs -= Discount;
        }
        public string GetCourseName()
        {
            return CourseName;
        }
        public decimal GetCourseFees()
        {
            return Fees;
        }

    }
    internal class InstituteTask
    {
        public static void Main(string[] args)
        {
            Institute I = new Institute();
            I.SetCourse("MCA", 25000);
            string CourseName = I.GetCourseName();
            decimal Fees = I.GetCourseFees();

            Console.WriteLine($"CourseName:{CourseName}");
            Console.WriteLine($"CourseFees:{Fees}");

            Console.WriteLine("Enter your Percentage:");
            decimal.TryParse(Console.ReadLine(), out decimal Percentage);

            I.GetDiscount(Percentage, out decimal Discount);
            Console.WriteLine($"Congreats,your Discount is{Discount}");

            I.UpdateCourseFees(ref Fees, Discount);
            Console.WriteLine($"After Discount:{Fees}");
            Console.ReadLine();
        }
    }
}
