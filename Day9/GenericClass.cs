using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.GenericClass
{
    public class MyOwnArray<T>
    {
        private T[] array;
        public MyOwnArray(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int position)
        {
            return array[position];
        }
        public void setItem(int position, T value)
        {
            array[position] = value;
        }
    }

    internal class GenericClass
    {
        public static void Main(string[] args)
        {
            MyOwnArray<int> intArray = new MyOwnArray<int>(5);
            for (int i = 0; i < 5; i++)
            {
                intArray.setItem(i, i + 1);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray.getItem(i));
            }
            Console.WriteLine("------------");
            MyOwnArray<string> stringArray = new MyOwnArray<string>(5);
            for (int i = 0; i < 5; i++)
            {
                stringArray.setItem(i, $"String - {i + 1} Value : {i}");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(stringArray.getItem(i));
            }
            Console.ReadLine();
        }
    }
}
