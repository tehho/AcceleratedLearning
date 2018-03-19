using System;
using System.Collections.Generic;

namespace S5L48
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-
            int counter = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("{0} numbers are divisible by 3.", counter);

            // 2-
            string input = "";
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number:");
                input = Console.ReadLine();
                if (input.Equals("OK"))
                {
                    break;
                }

                try
                {
                    int value = int.Parse(input);
                    sum += value;
                    Console.WriteLine("Total sum is: {0}", sum);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not a valid number!");
                }
            }

            // 3-
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }

            Console.WriteLine("The factoriol for {0} is {1}", number, sum);

            // 4-
            int answer = new Random().Next(1, 10);
            int guess = 0;
            int guesses = 0;
            while (guess != answer && guesses < 4)
            {
                Console.WriteLine("Guess a number between 1-10:");
                guess = int.Parse(Console.ReadLine());
                guesses++;
            }
            if (guess == answer)
            {
                Console.WriteLine("You won in {0} guesses!", guesses);
            }
            else
            {
                Console.WriteLine("You lost! Better luck next time!");
            }

            // 5-
            Console.WriteLine("Enter numbers divided by ','.");
            input = Console.ReadLine();
            int maxValue = int.MinValue;
            foreach(var value in input.Split(","))
            {
                try
                {
                    int tempValue = int.Parse(value);
                    if (tempValue > maxValue)
                        maxValue = tempValue;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("The max value inputed was {0}!", maxValue);
            
        }
    }
}
