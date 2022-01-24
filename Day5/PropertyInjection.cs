using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.PropertyInjection
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
        public IService Service
        {
            set
            {
                this._service = value;
            }
        }
        public void FetchData()
        {
            _service.GetData();
        }
    }
    internal class PropertyInjection
    {
        public static void Main(string[] args)
        {
            var fs = new FakeService();
            var ds1 = new DependencyService();
            ds1.Service = fs;
            ds1.FetchData();
            Console.WriteLine("---------");
            var dbs = new DBService();
            var ds2 = new DependencyService();
            ds2.Service = dbs;
            ds2.FetchData();
        }
    }
}
