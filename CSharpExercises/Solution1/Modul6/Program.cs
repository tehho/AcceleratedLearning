using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Transactions;

namespace Modul6
{
    internal partial class Program
    {

        private static void Main(string[] args)
        {
            var list = new List<Shape>
            {
                new Circle(1, 1, 8),
                new Circle(new Vector2(2, 7), 30),
                new Square(1, 2, 6, 8),
                new Square(new Vector2(7), new Vector2(5, 7))
            };


            ListSayHello(list);

            Console.WriteLine();

            ListWriteMath(list);

            var cube = new Cube(2, 3, 4, ConsoleColor.Red);
            PrintCube(cube);
            
            Console.ReadKey(); 
        }

        private static void PrintCube(Cube cube)
        {
            Console.ForegroundColor = cube.Color;
            Console.WriteLine($"Volume {Math.Round(cube.CalculateVolume(), 2)}");
            Console.WriteLine($"Area {Math.Round(cube.CalculateArea(), 2)}");
            Console.ResetColor();
        }

        private static void ListSayHello(List<Shape> list)
        {
            foreach (var item in list)
            {
                item.SayHello();
            }
        }

        private static void ListWriteMath(List<Shape> list)
        {
            foreach (var item in list)
            {
                item.WriteArea();
                item.WriteCircumfrens();
                Console.WriteLine();
            }
        }

    }
}
