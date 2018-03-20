using System;
namespace Modul6
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public override double Area { get { return Side * Side; } }
        public override double Circumfrens { get { return Side * 4; } }

        public Square()
            : base()
        {
            Side = 5.0;
        }
        public Square(string name)
            : base(name)
        {
            Side = 5.0;
        }
        public Square(string name, double side)
            : base(name)
        {
            Side = side;
        }

        public override void SayHello()
        {
            Console.WriteLine($"I'm a square with the name {Name}!");
        }

        public override void WriteArea()
        {

            System.Console.WriteLine($"My name is {Name}. I have side {Math.Round(Side, 2)} and an area of {Math.Round(Area, 2)}.");
        }

        public override void WriteCircumfrens()
        {
            System.Console.WriteLine($"My name is {Name}. I have side {Math.Round(Side, 2)} and an circumfrens of {Math.Round(Circumfrens, 2)}.");
        }
    }
}
