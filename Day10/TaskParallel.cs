using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.TaskParallel
{
    internal class TaskParallel
    {
        public static int total = 0;
        static void Addvalue()
        {
            for(int i=0;i<1000;i++)
            {
                total += 1;
            }
        }
        static void RemoveValue()
        {
            for(int i=0;i<1000;i++)
            {
                total -= i;
            }
        }
        public static void Main(string[] args)
        {
            var task1 = new Task(Addvalue);
            var task2 = new Task(RemoveValue);

            task1.Start();
            task2.Start();
            Task.WaitAll(new Task[] { task1, task2 });
            Console.WriteLine($"Total Value after executing both Task:{total}");
            Console.ReadLine();
        }
    }
}
