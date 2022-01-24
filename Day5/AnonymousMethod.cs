using System;
namespace LearnCS.AnonymousMethod
{
    public class Demo
    {
        //static int add(int no1, int no2)
        //{
        // return no1 + no2;
        //}
        public static void Main(string[] args)
        {
            //var result = add(10, 20);
            //Console.WriteLine($"Result : {result}");
            var addition = delegate (int no1, int no2)
            {
                return no1 + no2;
            };
            Console.WriteLine($"Result : {addition.Invoke(10, 20)}");
        }
    }
}