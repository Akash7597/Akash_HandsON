using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace Day9.BasicMultiThreading1
{
    class ThreadClass
    {
        public void Task1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Task1 Executed for {i + 1} Times");
                Thread.Sleep(1000);
            }
        }
        public void Task2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Task2 Executed for {i + 1} Times");
                Thread.Sleep(1000);
            }
        }
        public void Task3()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Task3 Executed for {i + 1} Times");
                Thread.Sleep(1000);
            }
        }
    }
    internal class BasicMultiThreading1
    {
        public static void Main(string[] args)
        {
            ThreadClass tc = new ThreadClass();
            Thread thread1 = new Thread(new ThreadStart(tc.Task1));
            Thread thread2 = new Thread(new ThreadStart(tc.Task2));
            Thread thread3 = new Thread(new ThreadStart(tc.Task3));
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Normal;
            thread3.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadLine();
        }
    }
}
