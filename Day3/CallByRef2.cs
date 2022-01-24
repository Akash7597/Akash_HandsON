using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.CallByRef2
{
    internal class CallByRef2
    {
        class Name
        {
            public string FirstName, LastName;
        }
        public static void Main(string[] args)
        {
            Name AB = new Name() { FirstName = "Akash", LastName = "kumar" };
            CallByRef2.updatedName(AB);
            Console.WriteLine($"After executing:{AB.FirstName},{AB.LastName}");
        }
        static void updatedName(Name AB)
        {
            Console.WriteLine($"Received FullName:{AB.FirstName},{AB.LastName}");
            AB.LastName = "Akodiya";
            Console.WriteLine($"After :{AB.FirstName},{AB.LastName}");
            Console.ReadLine();
        }
    }
}
