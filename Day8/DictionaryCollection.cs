using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.DictionaryCollection

{
    internal class DictionaryCollection
    {
        public static void Main(string[] args)
        {
            var dayOfWeek = new Dictionary<int, string>();
            //Adding New Item / Updating an Item
            //dayOfWeek { { 1, "Sunday"}, .. }
            dayOfWeek[1] = "Sunday";
            dayOfWeek[2] = "Monday";
            dayOfWeek[3] = "Tuesday";
            dayOfWeek[4] = "Wednesday";
            dayOfWeek[5] = "Thrusday";
            dayOfWeek[6] = "Friday";
            dayOfWeek[7] = "Saturday";
            //foreach (KeyValuePair<int,string>day in dayOfWeek)
            //{
            // Console.WriteLine($"{day.Key} : {day.Value}");
            //}
            foreach (var day in dayOfWeek)
            {
                Console.WriteLine($"{day.Key} : {day.Value}");
            }
            //Removing an Item
            dayOfWeek.Remove(1);
            Console.ReadLine();
        }
    }
}
