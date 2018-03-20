using System;
namespace Modul6
{
    public  class Triangle : Shape
    {
        public double Bas { get; set; }
        public double Height { get; set; }
        public override double Area { get { return (Bas * Height) / 2; } }
        public override double Circumfrens { get { return (Bas * Height) / 2; } }

        public Triangle(double x, double y, double bas, double height)
            : base(x, y)
        {
            Bas = bas;
            Height = height;
        }
        public Triangle(Vector2 position, double bas, double height)
            : base(position)
        {
            Bas = bas;
            Height = height;
        }

        public override void SayHello()
        {
            Console.WriteLine($"I'm a triangle with the position {Position}, baseline {Math.Round(Bas,2)} and height {Math.Round(Height, 2)}!");
        }

        public override void WriteArea()
        {
            Console.WriteLine($"I have base {Math.Round(Bas, 2)} and a height of {Math.Round(Height, 2)} and an area of {Math.Round(Area, 2)}.");
        }

        public override void WriteCircumfrens()
        {
            Console.WriteLine($"I have base {Math.Round(Bas, 2)} and a height of {Math.Round(Height, 2)} and an circumfrens of {Math.Round(Circumfrens, 2)}.");
        }
    }
}