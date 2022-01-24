using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day10.TPL
{
    internal class TPL
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Main method start executing ThreadID:({Thread.CurrentThread.ManagedThreadId})");

            //Method of creating and starting thread
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"First Task Executed by ThreadId:({Thread.CurrentThread.ManagedThreadId})");
            });
            //2nd method creating task
            var task=new Task(() =>
            {
                Console.WriteLine($"Second task is ececuted by threadid:({Thread.CurrentThread.ManagedThreadId})");
            });
            task.Start();//starting thread
            Console.WriteLine($"Press any key to start");
            Console.ReadLine();
            Console.WriteLine($"Main Method start execution complete using threadId:({Thread.CurrentThread.ManagedThreadId})");
            Console.ReadLine();
        }
    }
}
