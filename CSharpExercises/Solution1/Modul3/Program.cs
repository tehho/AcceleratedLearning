using System;
using System.Collections.Generic;
using System.Linq;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            OneLineOfCode(GetNumber());

            PressENTERToContinue();
        }

        static void OneLineOfCode(int value)
        {
            Console.WriteLine(value == 20 ? "Equal to 20" : value < 20 ? "Lower than 20" : "Higher than 20");
        }

        static void GuessingGame()
        {
            int answer = new Random().Next(1, 100);
            int guess = 0;
            Console.WriteLine("Guess a number from 1-100!");
            while (guess != answer)
            {
                guess = GetNumber();

                if (guess == answer)
                    break;
                
                if (guess < answer)
                {
                    PrintRed("The answer is higher!");
                }
                else
                {
                    PrintBlue("The answer is lower!");
                }
            }
            PrintGreen($"You guessed the right answer: {guess}");
        }

        static void PrintGreen(string str)
        {
            PrintColor(str, ConsoleColor.Green);
        }

        static void PrintBlue(string str)
        {
            PrintColor(str, ConsoleColor.DarkCyan);
        }

        static void PrintRed(string str)
        {
            PrintColor(str, ConsoleColor.Red);
        }

        static void PrintColor(string str, ConsoleColor color)
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ForegroundColor = temp;
        }

        static void IfStatement2()
        {
            int number = GetNumber();
            int compairTo = GetCompairTo();

            Compair(number, compairTo);

        }

        private static void Compair(int number, int compairTo)
        {
            if (number < compairTo)
                Console.WriteLine($"{number} is lower then {compairTo}");
            else if (number > compairTo)
                Console.WriteLine($"{number} is higher then {compairTo}");
            else
                Console.WriteLine($"{number} is equal to {compairTo}");
        }

        private static int GetCompairTo()
        {
            int number;
            bool test = true;
            do
            {
                if (test)
                    Console.Write("Enter a number to compair to: ");
                else
                    Console.Write("Enter a number to compair to: ");

                test = int.TryParse(Console.ReadLine(), out number);
            }
            while (!test);
            return number;
        }

        static int GetNumber()
        {
            int number;
            bool test = true;
            do
            {
                if (test)
                    Console.Write("Enter a number: ");
                else
                    Console.Write("Enter a number: ");

                test = int.TryParse(Console.ReadLine(), out number);
            }
            while (!test);
            return number;
        }

        static void ForeachWithBreak()
        {
            List<string> names = GetNames();
            string surname = GetSurname();
            string keyword = GetKeyword(names);
            
            bool ifKeyword = !names.Contains("Allow" + keyword);

            foreach (var name in names)
            {
                if (ifKeyword && (name.ToLower() == keyword))
                {
                    break;
                }
                else if (!name.ToLower().Equals("allow" + keyword))
                {
                    PrintName(name, surname);
                }
            }

        }

        static string GetKeyword(List<string> names)
        {
            List<string> temp = names.Where(name => name.Contains("ChangeKeyword")).ToList();

            if (temp.Count != 0)
                return temp[0].Remove("ChangeKeyword");

            return "zelda";
        }

        static void ForEachTest()
        {
            List<string> names = GetNames();

            string surname = GetSurname().Trim();

            Console.WriteLine();

            foreach (var name in names)
            {
                PrintName(name, surname);
            }
        }

        static void PrintName(string name, string surname)
        {
            if (name != "")
                Console.WriteLine($"{name.ToCapitilize()} {surname.ToCapitilize()}");
        }

        static string GetSurname()
        {
            Console.Write("Enter surname: ");
            string name = Console.ReadLine();

            if (name == "")
                return "Andersson";

            return name;
        }

        static List<string> GetNames()
        {
            Console.Write("Enter names in a list (like Maria, Peter,Lisa): ");
            string str = Console.ReadLine();

            if (str == "")
                return new List<string>();

            List<string> ret = str.Split(",").ToList();
            ret.RemoveAll((name) => name == "");

            ret = ret.Select((name) => (name.Trim())).ToList();

            return ret;
        }

        static void WhileTest()
        {

            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("Times to repeat: ");
            int repeat = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            while (i < repeat)
            {
                Console.WriteLine($"Your name is {name}");
                i++;
            }

            Console.WriteLine();

            i = 0;
            while (true)
            {
                Console.WriteLine($"Your name is {name}");
                if (++i == repeat)
                    break;
            }

        }

        static void IfStatement()
        {
            DateTime bedtime = GetBedTime();
            DateTime wakeup = GetWakeupTime();


            Console.WriteLine();

            TimeSpan sleepdelta = wakeup - bedtime;

            if (sleepdelta.Hours < 7)
            {
                Console.WriteLine($"You only slept {sleepdelta.Hours} hours. Go back to bed!");
            }
            else if (sleepdelta.Hours > 11)
            {
                Console.WriteLine($"You've slept {sleepdelta.Hours} hours. That's a lot.");
            }
            else
            {
                Console.WriteLine($"You have slept well.");
            }
        }

        static TimeSpan GetTime(string time)
        {
            string[] temp = time.Split(":");
            if (temp.Length == 1)
            {
                return new TimeSpan(Convert.ToInt32(temp[0]), 0, 0);
            }
            if (temp.Length == 2)
            {
                return new TimeSpan(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]), 0);
            }
            else
            {
                return new TimeSpan(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2]));
            }
        }

        static DateTime GetBedTime()
        {
            Console.Write("When did you go to bed: ");
            string temp = Console.ReadLine();
            DateTime yesterday = DateTime.Now - new TimeSpan(1, 0, 0, 0);
            DateTime dt = new DateTime(yesterday.Year, yesterday.Month, yesterday.Day) + GetTime(temp);
            return dt;

        }

        static DateTime GetWakeupTime()
        {
            Console.Write("When did you wake up: ");
            string temp = Console.ReadLine();
            DateTime today = DateTime.Now;
            DateTime dt = new DateTime(today.Year, today.Month, today.Day) + GetTime(temp);
            return dt;
        }

        static void PressENTERToContinue()
        {
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}
