using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace Day9.BasicMultiThreading
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
        internal class BasicMultiThreading
        {
            public static void Main(string[] args)
            {
                    ThreadClass tc = new ThreadClass();
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    tc.Task1();
                    tc.Task2();
                    tc.Task3();
                    stopwatch.Stop();
                    Console.WriteLine($"Time taken to execute the Tasks :{ (stopwatch.ElapsedMilliseconds / 1000)}seconds" );
                    Console.ReadLine();
            }
        }
}
