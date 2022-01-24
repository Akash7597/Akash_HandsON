using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.OCP
{
    public class Logger
    {
        public void WriteLogToSystem(String content)
        {
            Console.WriteLine("Log Message has to write in system");

        }
    }
    public class ErrorLogger:Logger
    {
        public void WriteLogToFile(string content)
        {
            Console.WriteLine("Log message has written to the file");
        }
        public void WriteLogToDB(string content)
        {
            Console.WriteLine("Log message has been writen in database");
        }
    }
     public class OCP
    {
        public static void Main(string[] args)
        {
            var e1=new ErrorLogger();
            e1.WriteLogToSystem("ocp Demo");
            e1.WriteLogToFile("OCP Demo");
            e1.WriteLogToDB("OCP Demo");
            Console.ReadLine();
        }
    }
}
