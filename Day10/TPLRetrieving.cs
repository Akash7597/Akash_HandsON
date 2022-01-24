using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day10.TPLRetrieving
{
    internal class TPLRetrieving
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Main method start execution ThreadId:" +
                $"({Thread.CurrentThread.ManagedThreadId})");

            var task1 = Task.Factory.StartNew<string>(() =>
             {
                 Console.WriteLine($"first task is executing using threadId:" +
                     $"({Thread.CurrentThread.ManagedThreadId})");
                 Task.Delay(2000);
                 return "I am the result of long running task1";
             });

            var task2 = new Task<string>(() =>
            {
                Console.WriteLine($"second task is executing using threadId:" +
                    $"({Thread.CurrentThread.ManagedThreadId})");
                Task.Delay(2000);
                return "I am the result of long running task2";
            });
            Task<string> task3 = new Task<string>(() =>
            {
                Console.WriteLine($"Third task is executing using threadId:" +
                    $"({Thread.CurrentThread.ManagedThreadId})");
                Task.Delay(2000);
                return "I am the result of long running task3";
            });
            task2.Start();
            task3.Start();

            var result1=task1.Result;
            var result2=task2.Result;
            var result3 = task3.Result;

            Console.WriteLine($"Result of Task1:{result1}");
            Console.WriteLine($"Result of Task2:{result2}");
            Console.WriteLine($"Result of Task3:{result3}");
            Console.WriteLine("{press any key to complete");
            Console.ReadLine();
            Console.WriteLine($"Main method is completed :({Thread.CurrentThread.ManagedThreadId})");
            Console.ReadLine();
        }
    }
}
