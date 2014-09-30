using System;

namespace CircleApp
{
    class Circle
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetDiameter()
        {
            return 2*Radius;
        }

        public double GetPerimeter()
        {
            return 2*Math.PI*Radius;
        }

        public double GetArea()
        {
            return Math.PI*Radius*Radius;
        }
    }
}
