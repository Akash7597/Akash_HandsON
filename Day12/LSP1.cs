using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public abstract class Shape
    { 
        public abstract void GetShape();
    }
    class Reactangle:Shape
    {
        public override void GetShape()
        {
            Console.WriteLine("I am A reactangle");
        }
    }
    class Square: Shape
    {
        public override void GetShape()
        {
            Console.WriteLine("i am a square");
        }
    }
    public class LSP1
    {
        public static void Main(string[] args)
        {
            Shape shape = new Reactangle();
            shape.GetShape();

            shape=new Square();
            shape.GetShape();
            Console.ReadLine();
        }
    }
}
