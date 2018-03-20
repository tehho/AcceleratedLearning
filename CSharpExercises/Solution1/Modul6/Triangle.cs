using System;
namespace Modul6
{
    public  class Triangle : Shape
    {
        public double Bas { get; set; }
        public double Height { get; set; }
        public override double Area { get { return (Bas * Height) / 2; } }
        public override double Circumfrens { get { return (Bas * Height) / 2; } }

        public Triangle(string name, double sida1, double sida2, double sida3)
            : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine($"I'm a triangle with the name {Name}!");
        }

        public override void WriteArea()
        {
            Console.WriteLine($"My name is {Name}. I have base {Math.Round(Bas, 2)} and a height of {Math.Round(Height, 2)} and an area of {Math.Round(Area, 2)}.");
        }

        public override void WriteCircumfrens()
        {
            Console.WriteLine($"My name is {Name}. I have base {Math.Round(Bas, 2)} and a height of {Math.Round(Height, 2)} and an circumfrens of {Math.Round(Circumfrens, 2)}.");
        }
    }
}