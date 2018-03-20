using System;
using System.Drawing;

namespace Modul6
{
    public class Square : Shape
    {
        public Vector2 Size { get; set; }

        public double Width => Size.X;
        public double Height => Size.Y;

        public override double Area => Width * Height;
        public override double Circumfrens => (Width + Height) * 2;

        public Square()
            : base()
        {
            Size = new Vector2(5);
        }
        public Square(double x, double y)
            : base(x, y)
        {
            Size = new Vector2(5);
        }
        public Square(double x, double y, double w, double h)
            : base(x, y)
        {
            Size = new Vector2(w, h);
        }
        public Square(Vector2 position, double w, double h)
            : base(position)
        {
            Size = new Vector2(w, h);
        }
        public Square(Vector2 position, Vector2 size)
            : base(position)
        {
            Size = new Vector2(size.X, size.Y);
        }

        public override void SayHello()
        {
            Console.WriteLine($"I'm a square with the position {Position}, height of {Height} and width of {Width}!");
        }

        public override void WriteArea()
        {

            System.Console.WriteLine($"I have an area of {Math.Round(Area, 2)}.");
        }

        public override void WriteCircumfrens()
        {
            System.Console.WriteLine($"I have an circumfrens of {Math.Round(Circumfrens, 2)}.");
        }
    }
}
