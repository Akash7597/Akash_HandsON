using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Day9.ThreadSync
{
    class ThreadClass1
    {
        //public static object o;
        public void Task()
        {
            Console.WriteLine($"Executing Task of ThreadClass1 Started :{ Thread.CurrentThread.ManagedThreadId}");
            lock ("sl")
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"TC1 - Task Executed for {i + 1} times " +
                    $"using the Thread ID : {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine($"Executing Task of ThreadClass1 Completed :{ Thread.CurrentThread.ManagedThreadId}");
        }
    }
    class ThreadClass2
    {
        public void Task()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"TC2 - Task Executed for {i + 1} times " +
                $"using the Thread ID : {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
        }
    }
    internal class ThreadSync
    {
        public static void Main(string[] args)
        {
            ThreadClass1 tc1 = new ThreadClass1();
            ThreadClass2 tc2 = new ThreadClass2();
            Thread thread1 = new Thread(new ThreadStart(tc1.Task)); //Thread ID: 5
            Thread thread2 = new Thread(new ThreadStart(tc1.Task)); //Thread ID: 6
            Thread thread3 = new Thread(new ThreadStart(tc2.Task)); //Thread Id: 7
            thread1.Start();
            thread3.Start();
            thread2.Start();
            Console.ReadLine();
        }
    }
}
