using System;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle aCircle = new Circle(Convert.ToDouble(Console.ReadLine()));
            //aCircle.radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Perimeter: " + aCircle.GetPerimeter());
            Console.WriteLine("Diameter: " + aCircle.GetDiameter());
            Console.WriteLine("Area: " + aCircle.GetArea());
            Console.ReadLine();
        }
    }
}
