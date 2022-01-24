using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.MethodInjection
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
        private IService _service;
        public void FetchData(IService service)
        {
            _service = service;
            _service.GetData();
        }
    }
    internal class MethodInjection
    {
        public static void Main(string[] args)
        {
            var fs = new FakeService();
            var ds1 = new DependencyService();
            ds1.FetchData(fs);
            Console.WriteLine("---------");
            var dbs = new DBService();
            var ds2 = new DependencyService();
            ds2.FetchData(dbs);
            Console.ReadLine();
        }
    }
}
