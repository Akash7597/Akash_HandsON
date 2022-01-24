using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Serialization.JsonSerialization
{
    public class Department
    {
        public int DeptNo { get; set; }
        public string DName { get; set; }
        public string Location { get; set; }
    }
    public class JsonSerialization
    {
        public static void Main(string[] args)
        {
            var dept = new Department()
            {
                DeptNo = 10,
                DName="Sales",
                Location="Rajasthan"
            };
            var jsonData = JsonConvert.SerializeObject(dept);
            Console.WriteLine("JSon Serialization Successful");
            Console.WriteLine($"Data:\n{jsonData}");

            var department = JsonConvert.DeserializeObject<Department>(jsonData);

            Console.WriteLine("Json De-Serialization Successfull");
            Console.WriteLine($"Department#:{department.DeptNo}");
            Console.WriteLine($"Department Name:{department.DName}");
            Console.WriteLine($"Location:{department.Location}");
            Console.ReadLine();
        }
    }
}
