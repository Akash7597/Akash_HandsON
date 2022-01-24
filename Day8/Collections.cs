using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Collections
{
    internal class Collections
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(101);
            al.Add(10000);
            var total = 0;
            foreach (var item in al)
            {
                total += (int)item;

            }
            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
