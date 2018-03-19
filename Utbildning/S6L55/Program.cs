using System;
using System.Collections.Generic;

namespace S6L55
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-
            List<string> peopleWhoLiked = new List<string>();

            while (true)
            {
                Console.WriteLine("Who liked your post?");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    break;
                peopleWhoLiked.Add(input);

            }

            if (peopleWhoLiked.Count == 1)
            {
                Console.WriteLine("{0} liked your post!", peopleWhoLiked[0]);
            }
            else if (peopleWhoLiked.Count == 2)
            {
                Console.WriteLine("{0} and {1} liked your post!", peopleWhoLiked[0], peopleWhoLiked[1]);
            }
            else if (peopleWhoLiked.Count != 0)
            {
                Console.WriteLine("{0} and {1} and {2} more liked your post!", peopleWhoLiked[0], peopleWhoLiked[1], peopleWhoLiked.Count - 2);
            }

            // 2-
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            List<char> tempList = new List<char>();

            foreach (var character in name)
            {
                tempList.Add(character);
            }

            tempList.Reverse();

            name = "";
            foreach (var character in tempList)
            {
                name += character;
            }

            Console.WriteLine("Hello {0}!", name);

            // 3-
            List<int> numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Input 5 unique numbers:");
                string input = Console.ReadLine();
                try
                {
                    int number = int.Parse(input);
                    if (numbers.Contains(number))
                    {
                        throw (new Exception("Number does already exist!"));
                    }
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            numbers.Sort();

            Console.WriteLine("Your input was: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // 4-

            numbers.Clear();
            while (true)
            {
                Console.WriteLine("Enter a number (Type Quit to exit loop): ");
                string input = Console.ReadLine();

                if (input.Equals("Quit"))
                    break;

                try
                {
                    int number = int.Parse(input);
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            List<int> listOfDubbles = new List<int>();

            foreach (var number in numbers)
            {
                if (listOfDubbles.Contains(number))
                {
                    continue;
                }

                if (Contains2Number(numbers, number))
                {
                    listOfDubbles.Add(number);
                }
            }

            foreach (var number in listOfDubbles)
            {
                Console.WriteLine(number);
            }

            // 5- 
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    int[] list = Array.ConvertAll(input.Split(","), int.Parse);
                    if (list.Length >= 5)
                    {
                        int min1 = int.MaxValue;
                        int min2 = int.MaxValue;
                        int min3 = int.MaxValue;

                        foreach (var value in list)
                        {
                            if (value < min3)
                            {
                                min3 = value;
                                if (min3 < min2)
                                {
                                    Swap(ref min2, ref min3);
                                    if (min2 < min1)
                                    {
                                        Swap(ref min1, ref min2);
                                    }
                                }
                            }
                        }
                        Console.WriteLine("{0} {1} {2}", min1, min2, min3);
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void Swap(ref int value1, ref int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }
        static public bool Contains2Number(List<int> list, int number)
        {
            if (!list.Contains(number))
                return false;

            int pos = list.IndexOf(number);
            int pos2 = list.LastIndexOf(number);
            return pos != pos2;
        }
    }
}
