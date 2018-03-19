using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithDifferentTypes();

            PressENTERToContinue();
        }

        static void StringCreation()
        {
            List<string> fruits = GetFruits();

            PrintConcatenation(fruits);

            PrintUsingPlaceholders(fruits);

            PrintInterpolation(fruits);
            
            int oranges = fruits.Count((fruit) => fruit.Equals("orange"));

            PrintColor($"There are {oranges} oranges in the list", ConsoleColor.Green);
        }

        static void PrintInterpolation(List<string> fruits)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < fruits.Count; i++)
            {
                 sb.Append(fruits[i]);
                if (i < fruits.Count - 1)
                    sb.Append(", ");
            }

            PrintColor($"You entered {fruits.Count} fruits: {sb.ToString()}", ConsoleColor.Green);
        }

        static void PrintUsingPlaceholders(List<string> fruits)
        {
            string format = "You entered {0} fruits: {1}";

            PrintColor(String.Format(format, fruits.Count, String.Join(", ", fruits)), ConsoleColor.Green);
        }

        static void PrintConcatenation(List<string> fruits)
        {
            string str = "You entered " + fruits.Count + " fruits: ";

            for (int i = 0; i < fruits.Count; i++)
            {
                str += fruits[i];
                if (i != fruits.Count - 1)
                    str += ", ";
            }
            PrintColor(str, ConsoleColor.Green);
        }

        static List<string> GetFruits()
        {
            List<string> fruits = new List<string>();

            int size = -1;
            while (size < 1)
            {
                Console.Write("How many fruits do you want to add: ");
                if (!int.TryParse(Console.ReadLine(), out size))
                    size = 0;
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter fruit{0}: ", i + 1);
                fruits.Add(Console.ReadLine().Trim().ToLower());
            }
            return fruits;
        }

        static void WorkingWithDifferentTypes()
        {
            string name;
            int age;
            char favoritCharacter;

            int randomQuestion = new Random().Next(0,6);
            
            if (randomQuestion % 3 == 0)
            {
                name = GetName();
                if (randomQuestion % 2 == 0)
                {
                    favoritCharacter = GetFavoritLetter();
                    age = GetAge();
                }
                else
                {
                    age = GetAge();
                    favoritCharacter = GetFavoritLetter();
                }
            }
            else if (randomQuestion % 3 == 1)
            {
                age = GetAge();
                if (randomQuestion % 2 == 0)
                {
                    name = GetName();
                    favoritCharacter = GetFavoritLetter();
                }
                else
                {
                    favoritCharacter = GetFavoritLetter();
                    name = GetName();
                }
            }
            else
            {
                favoritCharacter = GetFavoritLetter();
                if (randomQuestion % 2 == 0)
                {
                    name = GetName();
                    age = GetAge();
                }
                else
                {
                    age = GetAge();
                    name = GetName();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();


            ConsoleColor[] tempColor = new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Cyan };

            PrintRainbow("Your name is: " + name);
            CheckFavoritCharacter(favoritCharacter);
            CheckAge(age);
            CheckSpecialPerson(name, age);
        }

        private static void CheckSpecialPerson(string name, int age)
        {
            if (name == "Andreas Antonsson" && age == 25)
            {
                Console.Beep(440, 500);
                Console.Beep(523, 500);
                Console.Beep(659, 500);
            }
        }

        static void CheckAge(int age)
        {
            if ( age > 64)
            {
                PrintColor("You already retiered", ConsoleColor.Red);
            }
            else
            {
                age = 65 - age;
                PrintColor("You retire in " + age +" years", ConsoleColor.Green);
            }
        }

        static void CheckFavoritCharacter(char favoritChar)
        {
            if ((int)favoritChar <= (int)'9' && (int)favoritChar >= (int)'0')
            {
                PrintColor("You like numbers", ConsoleColor.Green);
            }
            else if (((int)favoritChar <= (int)'z' && (int)favoritChar >= (int)'a') || (int)favoritChar >= (int)'A' && (int)favoritChar <= (int)'Z')
            {
                PrintColor("You like letters", ConsoleColor.DarkCyan);
            }
            else
            {
                PrintColor("You are pretty special aren't you", ConsoleColor.Magenta);
            }

        }

        static void RespondToUserInput()
        {
            string name;
            int age;

            char favoritLetter;

            name = GetName();
            age = GetAge();
            favoritLetter = GetFavoritLetter();

            Console.WriteLine();
            Console.WriteLine("Thank you!");
            Console.WriteLine();


            ConsoleColor[] tempColor = new ConsoleColor[] { ConsoleColor.Green, ConsoleColor.Cyan };

            PrintColor("Your name is: " + name, tempColor);
            PrintColor("Your age is: " + age, ConsoleColor.Green);
            PrintColor("Your favorit letter is: " + favoritLetter, ConsoleColor.Green);
        }

        static char GetFavoritLetter()
        {
            Console.Write("What's your favorit letter: ");
            return (char)Console.ReadLine()[0];
        }

        static int GetAge()
        {
            bool parsed = true;
            int age;
            do
            {
                if (parsed)
                    Console.Write("What's your age: ");
                else
                    Console.Write("Please enter a correct age: ");
                parsed = int.TryParse(Console.ReadLine(), out age);
            }
            while (!parsed);
            return age;
        }

        static string GetName()
        {
            Console.Write("What's your name: ");
            return Console.ReadLine();
        }

        static void PrintRainbow(string str)
        {
            List<ConsoleColor> colors = new List<ConsoleColor>();

            ConsoleColor[] rainbow = new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.DarkMagenta};

            int size = str.Length / rainbow.Length;
            int overflow = str.Length % rainbow.Length;

            if (overflow == 0)
            {
                foreach (var item in rainbow)
                {
                    for (int i = 0; i < size; i++)
                    {
                        colors.Add(item);
                    }
                }
            }
            else if (overflow <= 2)
            {
                
                colors.Add(rainbow[0]);
                foreach (var item in rainbow)
                {
                    for (int i = 0; i < size; i++)
                    {
                        colors.Add(item);
                    }
                }
                colors.Add(rainbow[rainbow.Length - 1]);
            }
            else
            {
                size++;
                foreach (var item in rainbow)
                {
                    for (int i = 0; i < size; i++)
                    {
                        colors.Add(item);
                    }
                }
            }
            PrintColor(str, colors.ToArray());
        }

        static void PrintColor(string str, ConsoleColor color)
        {
            ConsoleColor tempColor = Console.ForegroundColor;
            Console.ForegroundColor = color;

            Console.Write(str);

            Console.ForegroundColor = tempColor;
        }

        static void PrintColor(string str, ConsoleColor[] color)
        {

            for (int i = 0; i < str.Length; i++)
            {
                PrintColor(str[i].ToString(), color[i % color.Length]);
            }
        }

        static void Print(string str)
        {
            Console.WriteLine(str);
        }

        static void PressENTERToContinue()
        {

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }
    }
}
