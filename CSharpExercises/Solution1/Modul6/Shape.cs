using System;

namespace Modul6
{
    public abstract class Shape
    {
        public Vector2 Position { get; set; }
        public virtual double Area { get; }
        public virtual double Circumfrens { get; }

        public Shape()
        {
            Position = new Vector2(0, 0);
        }
        public Shape(double x)
        {
            Position = new Vector2(x, x);
        }
        public Shape(double x, double y)
        {
            Position = new Vector2(x, y);
        }
        public Shape(Vector2 position)
        {
            Position = position;
        }


        public abstract void SayHello();
        public abstract void WriteArea();
        public abstract void WriteCircumfrens();


    }
}
