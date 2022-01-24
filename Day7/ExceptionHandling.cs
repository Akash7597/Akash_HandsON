using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.ExceptionHandling
{
    internal class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Two Numbers");
                int no1 = int.Parse(Console.ReadLine());
                int no2 = int.Parse(Console.ReadLine());
                var result = (float)no1 / no2;
                Console.WriteLine($"{no1} / {no2} = {result}");
            }
            catch (FormatException fex)
            {
                Console.WriteLine($"Format Error : {fex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Completed...");
            }

        }
    }
}
