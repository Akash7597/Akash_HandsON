using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.WithIndexInitializers
{
    internal class WithIndexInitializers
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> Days = new Dictionary<int, string>()
            {
                [1] = "Sunday",
                [2] = "Monday",
                [3] = "Tuesday",
                [4] = "Wednesday",
                [5] = "Thrusday",
                [6] = "Friday",
                [7] = "Saturday"
            };
            var day = Days[2];
            var d = Days[2];
           //  var a= Days[8];
            Console.WriteLine($"Selected Day : {day}\n{d}");
            Console.ReadLine();
        }
    }
}
