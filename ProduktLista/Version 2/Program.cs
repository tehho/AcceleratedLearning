using System;
using System.Collections.Generic;

namespace Version_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<string> list = new List<string>();

            Console.WriteLine("Skriv in produkter. Avsluta med att skriva in 'exit'.");
            Console.WriteLine();

            while (true)
            {
                input = Console.ReadLine();
                if (input.Trim().ToLower().Equals("exit"))
                    break;
                list.Add(input);
            }

            Console.WriteLine();
            Console.WriteLine("Du angav följande produkter: ");
            Console.WriteLine();

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(" * {0}", item);
            }
        }
    }
}
