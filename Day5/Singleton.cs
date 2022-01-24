using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Singleton
{
    public sealed class MySingleTonClass
    {
        private static int c = 0;
        private static MySingleTonClass instance = null;

        public static MySingleTonClass GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new MySingleTonClass();
                return instance;
            }
        }
        private MySingleTonClass()
        {
            c++;
            Console.WriteLine($"MySingleTonClass instance is created {c} times");
        }
        public void MyMethod(string objectName)
        {
            Console.WriteLine($"my method of singleton class is invoked by {objectName}");
        }
    }

    internal class Singleton
    {
        public static void Main(string[] args)
        {
            var my1 = MySingleTonClass.GetInstance;
            my1.MyMethod("my1");

            Console.WriteLine("---------------");

            var my2 = MySingleTonClass.GetInstance;
            my2.MyMethod("my2");
            Console.ReadLine();
        }
    }
}
