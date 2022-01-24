using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace day10Practice
{
    [Serializable]
    public class Employee
    {
        public int Empno { get; set; }
        public string EName { get; set; }
        public int Deptno { get; set; }
        [NonSerialized]
        public decimal Salary;
    }
    public class Serilaization
    {
        public static void Main(string[] args)
        {
            var emp = new Employee()
            {
                Empno = 101,
                EName = "Akash",
                Deptno = 10,
                Salary = 100000

            };
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("emp.binary", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (stream)
                {
                    formatter.Serialize(stream, emp);
                    Console.WriteLine("Employee Object Successfully Serialized");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine("----------------------");
            var employee = new Employee();
            BinaryFormatter binaryformatter = new BinaryFormatter();
            FileStream filestream = new FileStream("emp.binary", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (filestream)
                {
                    employee = (Employee)binaryformatter.Deserialize(filestream);

                    Console.WriteLine("Employee Object Successfully De-Serialized");
                    Console.WriteLine($"Employee #{ employee.Empno}");
                    Console.WriteLine($"Employee Name #{ employee.EName}");
                    Console.WriteLine($"Employee Department #{ employee.Deptno}");
                    Console.WriteLine($"Employee salary #{ employee.Salary}");


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}