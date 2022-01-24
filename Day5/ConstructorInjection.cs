using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.ConstructorInjection
{
    public interface IService
    {
        void GetData();
    }
    public class FakeService : IService
    {
        public void GetData()
        {
            Console.WriteLine("Fetching the Data From Collections");
        }
    }
    public class DBService : IService
    {
        public void GetData()
        {
            Console.WriteLine("Fetching the Data from Database Server");
        }
    }
    class DependencyService
    {
        private readonly IService service;
        public DependencyService(IService service)
        {
            this.service = service;
        }
        public void FetchData()
        {
            service.GetData();
        }
    }
    internal class ConstructorInjection
    {
        public static void Main(string[] args)
        {
            var fs = new FakeService();
            var ds1 = new DependencyService(fs);
            ds1.FetchData();
            Console.WriteLine("---------");
            var dbs = new DBService();
            var ds2 = new DependencyService(dbs);
            ds2.FetchData();
            Console.ReadLine();
        }
    }
}
