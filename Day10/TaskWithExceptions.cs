using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day10
{
    internal class TaskWithExceptions
    {
        public static void Main(string[] args)
        {
            var t1 = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if(i>5)
                    {
                        throw new Exception("Request time out");
                    }
                    Console.WriteLine($"task executed for {i+1} Times");
                    Thread.Sleep(2000);
                    //Console.ReadLine();
                }
            });
            try
            {
                t1.Start();
                t1.Wait();
            }
            catch (AggregateException ae)
            {
                ae.Handle(e =>
                {
                    Console.WriteLine($"Exception raised:{e.Message}");
                    return true;
                });
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            Console.WriteLine("Program execution  complete");
            Console.ReadLine();
        }
    }
}
