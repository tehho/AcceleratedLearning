using System;

namespace Modul6
{
    public class Vector2
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Length => Math.Sqrt(Dot(this));

        public Vector2()
        {
            X = 0;
            Y = 0;
        }

        public Vector2(double x)
        {
            X = x;
            Y = x;
        }
        public Vector2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public double Dot(Vector2 other)
        {
            return X * other.X + Y * other.Y;
        }

    }
}
