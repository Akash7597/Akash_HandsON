using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Day10.TPLCancellation
{
    internal class TPLCancellation
    {
        public static void Main(string[] args)
        {
            var can = new CancellationTokenSource();
            var t1 = new Task(() =>
            {
                for(var i=0;i<100;i++)
                {
                    if(can.Token.IsCancellationRequested)
                    {
                        break;
                    }
                    Console.WriteLine($"Task is executed:{i+1} times");
                    Thread.Sleep(1000);
                }
            },can.Token);
            t1.Start();
            Console.WriteLine($"Press any key if you think there is some delay:");
            Console.ReadLine();
            can.Cancel();
            Console.WriteLine($"Main Method program is completed");
            Console.ReadLine();
        }
    }
}
