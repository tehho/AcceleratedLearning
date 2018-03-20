using System;

namespace Modul6
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public double Diameter => Radius * 2;
        public override double Area => Radius * Radius * System.Math.PI;
        public override double Circumfrens => Diameter * Math.PI;

        public Circle()
            : base()
        {
            Radius = 5.0;
        }
        public Circle(double x)
            : base(x)
        {
            Radius = 5.0;
        }
        public Circle(double x, double y)
            : base(x, y)
        {
            Radius = 5.0;
        }
        public Circle(double x, double y, double radius)
            : base(x, y)
        {
            Radius = radius;
        }
        public Circle(Vector2 position)
            : base(position)
        {
            Radius = 5.0;
        }
        public Circle(Vector2 position, double radius)
            : base(position)
        {
            Radius = radius;
        }

        public override void SayHello()
        {
            Console.WriteLine($"I'm a circle with the position {Position} and radius of {Math.Round((Radius), 2)}!");
        }
        public override void WriteArea()
        {
            Console.WriteLine($"I have radius {Math.Round(Radius, 2)} and an area of {Math.Round(Area, 2)}.");
        }
        public override void WriteCircumfrens()
        {
            Console.WriteLine($"I have radius {Math.Round(Radius, 2)} and an circumfrens of {Math.Round(Circumfrens, 2)}.");
        }
    }
}
