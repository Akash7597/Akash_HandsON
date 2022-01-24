using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day10.ExecptionHandingTask
{
    internal class ExecptionHandingTask
    {
        public static void Main(string[] args)
        {
            var t1 = new Task(() =>
            {
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (i > 5)
                            throw new Exception("Requested time out");
                        Console.WriteLine($"Task Executed:{(i+1)} Times");
                        Thread.Sleep(2000);
                    }
                }
                catch (AggregateException ae)
                {

                    Console.WriteLine($"Error:{ae.Message}");
                }
            });
            t1.Start();
            t1.Wait();
            Console.WriteLine($"Program exception completed::");
            Console.ReadLine();
        }
    }
}
