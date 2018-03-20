using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Transactions;

namespace Modul6
{
    internal partial class Program
    {

        private static void Main(string[] args)
        {
            
            Address adress = new Address("Enbärsvägen", 71, "448 37", "Floda");
            Console.WriteLine(adress);
            Console.WriteLine(adress.GetFullAddress());

            Console.ReadKey(); 
        }

        private static void PersonTest()
        {
            var list = new List<Person>
            {
                new Person("Lisa", "Andersson", new DateTime(1992, 06, 08), Gender.Female, Sport.Tennis)
            };


            foreach (var person in list)
            {
                if (person.FirstName == "Lisa")
                {
                    Console.WriteLine(person);
                }
            }

            PrintSportEnum();

            var input = Console.ReadLine();
            if (IsSport(input))
            {
                Console.WriteLine($"Oh, I know {input}!");
            }
            else
            {
                Console.WriteLine($"Sorry i don't know {input}!");
            }
        }

        private static bool IsSport(string sport)
        {
            var list = Enum.GetNames(typeof(Sport)).Select((item) => item.ToLower());

            return list.Contains(sport.ToLower());
        }

        private static void PrintSportEnum()
        {
            var list = Enum.GetNames(typeof(Sport));
            foreach (var item in list)
            {
                Console.WriteLine($"* {item}");
            }
        }

        private static void ClassTest()
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
