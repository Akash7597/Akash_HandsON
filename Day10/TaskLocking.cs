using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.TaskLocking
{
    internal class TaskLocking
    {
        public static readonly object codeLock = new object();
        public static int total = 0;
        static void AddValues()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (codeLock)
                {
                    total += 1;
                }
            }
        }
        static void RemoveValues()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (codeLock)
                {
                    total -= 1;
                }
            }
        }
        public static void Main(string[] args)
        {
            var task1 = new Task(AddValues);
            var task2 = new Task(RemoveValues);
            task1.Start();
            task2.Start();
            Task.WaitAll(new Task[] { task1, task2 });
            Console.WriteLine($"Total Value after both Task1 and Task2 Executed : {total}");
            Console.ReadLine();
        }
    }
}
