using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.OutModeArgument
{
    class OuterClass
    {
        //Called Method
        public void OuterMethod(out int no)
        {
            
            no = 1000;
            Console.WriteLine($"After Updating Number within the OuterMethod: {no}");
        }
    }
    internal class OutModeArgument
    {
        public static void Main(string[] args)
        {
            int no = 1009;
            OuterClass oc = new OuterClass();
            oc.OuterMethod(out no);
            Console.WriteLine($"After OuterMethod Invoked : {no}");
            Console.ReadLine();
        }       
    }
}
