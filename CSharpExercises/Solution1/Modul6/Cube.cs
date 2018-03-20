using System;

namespace Modul6
{
    public class Cube
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public ConsoleColor Color { get; }

        public Cube()
        {
            X = 0;
            Y = 0;
            Z = 0;

            var c = Console.ForegroundColor;
            Console.ResetColor();
            Color = Console.ForegroundColor;
            Console.ForegroundColor = c;
        }

        public Cube(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;

            var c = Console.ForegroundColor;
            Console.ResetColor();
            Color = Console.ForegroundColor;
            Console.ForegroundColor = c;
        }
        public Cube(double x, double y, double z, ConsoleColor color)
        {
            X = x;
            Y = y;
            Z = z;

            Color = color;
        }

        public double CalculateVolume()
        {
            return Math.Abs(X * Y * Z);
        }
        public double CalculateArea()
        {
            return 2 * ( Math.Abs(X * Y) + Math.Abs(X * Z) + Math.Abs(Y * Z));
        }
    }
}
