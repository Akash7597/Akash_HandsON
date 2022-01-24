using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day9.ThreadPool
{
    public class Threadpool 
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                ThreadPool.SetMinThreads(16, 10);
                ThreadPool.SetMaxThreads(32, 10);
                ThreadPool.QueueUserWorkItem(DoSomeWork, i);
                while (ThreadPool.PendingWorkItemCount != 0)
                {
                    Console.WriteLine($"Threads = {ThreadPool.ThreadCount}");
                    Console.WriteLine($"Completed = {ThreadPool.CompletedWorkItemCount}");
                    Console.WriteLine($"Pending = {ThreadPool.PendingWorkItemCount}");
                    Console.WriteLine();
                    Thread.Sleep(50);
                    Console.WriteLine("------------------------");
                }
            }
        }
        static void DoSomeWork(object o)
        {
            Console.WriteLine($"Important Executed Successfully by Thread Id : " +
            $"{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(100);
        }

    }
}
