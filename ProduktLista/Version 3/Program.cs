using System;
using System.Collections.Generic;

namespace Version_3
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

                if (CheckInput(input))
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

        static public void PrintError(string e)
        {
            ConsoleColor c = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e);
            Console.ForegroundColor = c;
        }

        static public bool CheckInput(string input)
        {


            if (input.Length == 0)
            {
                PrintError("Du får inte ange ett tomt värde!");
                return false;
            }
            string[] temp = input.Split("-");
            if (temp.Length != 2)
            {
                PrintError("Du måste ange ett '-'. Tex XXX-200.");
                return false;
            }

            int i_temp;
            if (!int.TryParse(temp[1], out i_temp))
            {
                PrintError("Felaktigt format på den högra delen av produktnamnet!");
                return false;
            }

            if (i_temp < 200 || i_temp > 500)
            {
                PrintError("Den numeriska delen måste vara mellan 200 och 500!");
                return false;
            }

            bool test = true;
            foreach (var c_temp in temp[0])
            {
                test = true;
                for (var i = 'a'; i <= 'z' ; i++)
                {
                    if (c_temp == i)
                    {
                        test = false;
                    }
                }
            }
            if (test)
            {
                PrintError("Felaktigt format på den vänstrad delen av produktnamnet!");
                return false;
            }

            return true;
        }
    }
}
