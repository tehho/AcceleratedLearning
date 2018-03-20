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
        public Circle(string name)
            : base(name)
        {
            Radius = 5.0;
        }
        public Circle(string name, double radius)
            : base(name)
        {
            Radius = radius;
        }

        public override void SayHello()
        {
            Console.WriteLine($"I'm a circle with the name {Name}!");
        }
        public override void WriteArea()
        {
            System.Console.WriteLine($"My name is {Name}. I have radius {Math.Round(Radius, 2)} and an area of {Math.Round(Area, 2)}.");
        }
        public override void WriteCircumfrens()
        {
            System.Console.WriteLine($"My name is {Name}. I have radius {Math.Round(Radius, 2)} and an circumfrens of {Math.Round(Circumfrens, 2)}.");
        }
    }
}
