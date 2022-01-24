using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.AutoPropertyInitialisers
{
    class employees
    {
        //without auto property
        /*private Guid _Id;
        public employees()
        {
            _Id = Guid.NewGuid();
        }
        public Guid Id { get { return _Id; } }*/

        
        public Guid Id { get; } = Guid.NewGuid();//with auto property
        public string EName { get; set; }
        public decimal salary { get; set; }

    }

    internal class AutoPropertyInitialisers
    {
        public static void Main(string[] args)
        {
            employees emp = new employees() { EName = "Akash", salary = 100000 };
            Console.WriteLine($"Employee#:{emp.Id}");
            Console.WriteLine($"Employee Name:{emp.EName}");
            Console.WriteLine($"salary:{emp.salary}");

            Console.ReadLine();

        }
    }
}
