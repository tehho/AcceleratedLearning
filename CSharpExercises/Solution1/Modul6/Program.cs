using System;
using System.Collections.Generic;

namespace Modul6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            list.Add(new Circle("Bob", 8));
            list.Add(new Circle("Lisa", 30));
            list.Add(new Square("Bob", 8));
            list.Add(new Square("Lisa", 30));
            list.Add(new Triangle("Bob", 8));
            list.Add(new Triangle("Lisa", 30));

            ListSayHello(list);

            Console.WriteLine();

            ListWriteMath(list);
            
            Console.ReadKey(); 
        }

        static void ListSayHello(List<Circle> list)
        {
            foreach (var item in list)
            {
                item.SayHello();
            }
        }

        static void ListWriteMath(List<Circle> list)
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
