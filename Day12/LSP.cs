using System;
namespace LearnCS3
{
 class Rectangle
 {
 public virtual int Width { get; set; }
 public virtual int Height { get; set; }
 public int CalculateArea()
 {
 return Width + Height;
 }
 }
 class Square : Rectangle
 {
 public override int Width
 {
 get => base.Width;
 set
 {
 base.Width = value;
 base.Height = value;
 }
 }
 public override int Height
 {
 get => base.Height; set
 {
 base.Height = value;
 base.Width = value;
 }
 }
 }
 public class IsALimitDemo
 {
 public static void Main(string[] args)
 {
 Rectangle rectangle = new Square();
 rectangle.Height = 100;
 rectangle.Width = 20;
 Console.WriteLine($"Area of Rectangle : {rectangle.CalculateArea()}");
 }
 }
}