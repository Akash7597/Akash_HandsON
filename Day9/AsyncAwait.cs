using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day9.AsyncAwait
{
    internal class AsyncAwait
    {
        public static async Task<int> Method1Async()
        {
            int counter = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Method 1 is Incrementing Counter.... " +
                    $"Thread ID : ({Thread.CurrentThread.ManagedThreadId})");
                    counter += 1;
                    Thread.Sleep(1000);
                }
            });
            return counter;
        }
        public static void Method2(int counter)
        {
            Console.WriteLine("Method2 is Processing...." +
            $"(Thread ID : { Thread.CurrentThread.ManagedThreadId})");
            Console.WriteLine($"Received the Counter Value : {counter}");
        }
        public static async Task CallMethodAsync()
        {
            Console.WriteLine("Invoking Method1Async...." +
            $"( Tread ID : { Thread.CurrentThread.ManagedThreadId})");
            var counter = await Method1Async();
            Method2(counter);
        }

        public static async Task Main(string[] args)
        {
            Console.WriteLine("Executing the Main Method..( Thread Id : { Thread.CurrentThread.ManagedThreadId})");
            await CallMethodAsync();
            Console.WriteLine("Execution of Main Method Completed.( Thread Id : { Thread.CurrentThread.ManagedThreadId})");
        }
    }
}
