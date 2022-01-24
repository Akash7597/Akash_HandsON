using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day10.TPLWait
{
    internal class TPLWait
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Main Method starts executing ThreadId:" +
                $"({Thread.CurrentThread.ManagedThreadId})");
            var task1 = Task.Factory.StartNew(() =>
              {
                  for(int i=0;i<5;i++)
                  {
                      Task.Delay(5000);
                      Console.WriteLine($"First Task has been exectuted for {i+1} times using ThreadId:" +
                          $"({Thread.CurrentThread.ManagedThreadId}) ");
                  }
              });
            task1.Wait();

            var task2 = new Task(() =>
            {
                for (int i=0;i<3;i++)
                {
                    Task.Delay(5000);
                    Console.WriteLine($"Second task has been executed for {i+1} times using ThreadId:" +
                        $"({Thread.CurrentThread.ManagedThreadId})");
                }     
            });
            task2.Start();
            task2.Wait();
            Console.WriteLine("press any key to continue");
            Console.ReadLine();
            Console.WriteLine($"Main method execution complete using ThreadId:" +
                $"({Thread.CurrentThread.ManagedThreadId})");
            Console.ReadLine();
        }
    }
}
