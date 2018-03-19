using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S8L67
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-

            Console.WriteLine("Enter a line of number seperated by (-):");
            string input = Console.ReadLine();

            List<int> numbers = new List<int>(Array.ConvertAll(input.Split("-"), Convert.ToInt32));

            int[] numbersCheck = new int[numbers.Count];
            numbers.CopyTo(numbersCheck);

            numbers.Sort();

            bool checkForward = true;
            bool checkBackwards = true;

            for (int i = 0; i < numbers.Count && (checkForward || checkBackwards); i++)
            {
                if (numbers[i] != numbersCheck[i])
                {
                    checkForward = false;
                }
                if(numbers[numbers.Count - i - 1] != numbersCheck[i])
                {
                    checkBackwards = false;
                }
            }
            if (checkForward || checkBackwards)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }

            // 2-

            Console.WriteLine("Enter a line of number seperated by (-):");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            numbers.Clear();
            numbers.AddRange(Array.ConvertAll(input.Split("-"), Convert.ToInt32));

            for (int i=0; i<numbers.Count; i++)
            {
                if (numbers.IndexOf(numbers[i]) != i)
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
            }

            // 3-

            Console.WriteLine("Enter a time: ");
            input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                numbers.Clear();
                numbers.AddRange(Array.ConvertAll(input.Split(":"), Convert.ToInt32));
                if (numbers[0] >= 0 && numbers[0] <= 23 && numbers[0] >= 0 && numbers[1] <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid time");
            }
            else
            {
                Console.WriteLine("Invalid time");
            }


            // 4-

            Console.WriteLine("Please write a few words:");
            input = Console.ReadLine();

            PascalCase(input);

            // 5- 

            Console.WriteLine("Please write a word:");
            input = Console.ReadLine();

            int count = 0;

            foreach (var value in input.ToLower())
            {
                if (value == 'a' || value == 'e' || value == 'i' || value == 'o' || value == 'u')
                    count++;
            }

            Console.WriteLine("There are {0} vowels in {1}", count, input);
        }

        static public string PascalCase(string input, string seperator = " ")
        {
            var list = input.ToLower().Split(seperator);
            var sb = new StringBuilder();

            foreach (var value in list)
            {
                sb
                    .Append(value[0].ToString().ToUpper())
                    .Append(value.Substring(1));
            }
            Console.WriteLine(sb);
            return "";
        }
    }
}
