using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Property
{
    class Product
    {
        //Private Members
        private string _ProductID;
        private string _ProductName;
        private decimal _Price;
        //Constructor
        public Product(string pid, string pname, decimal price)
        {
            _ProductID = pid;
            _ProductName = pname;
            _Price = price;
        }
        //Read-Only Properties
        public string ProductID
        {
            get
            {
                return _ProductID;
            }
        }
        public string ProductName
        {
            get
            {
                return _ProductName;
            }
        }
        //Read-Write Property
        public decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (_Price < value)
                {
                    throw new Exception("Error: New Price cant be more thn the Current Price");
                }
                else
                {
                    _Price = value;
                }
            }
        }
        public void ShowProduct()
        {
            Console.WriteLine($"Product ID : {_ProductID}\nProduct Name :{ _ProductName}\nPrice: Rs.{ _Price}");
        }
    }
    internal class Property
    {
        public static void Main(string[] args)
        {
            Product tv = new Product("TV101", "LG Golden Eye", 18500);
            //tv.ProductName = "Akash LED"; Error: Product Name is Read-Only
            tv.Price = 5000;
            tv.ShowProduct();
            Console.ReadLine();
        }
    }
}
