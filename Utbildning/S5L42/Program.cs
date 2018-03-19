using System;

namespace S5L42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1-10:");
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid input!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            int firstNumber;
            int secondNumber;

            Console.WriteLine("Please enter the first number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The number are equal.");
            }
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine("The first number is the largest!");
            }
            else
            {
                Console.WriteLine("The second number is the largest!");
            }

            int width;
            int height;

            Console.WriteLine("Please enter the width:");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height:");
            height = int.Parse(Console.ReadLine());

            if (width == height)
            {
                Console.WriteLine("The number are equal. The picture is a square.");
            }
            else if (width > height)
            {
                Console.WriteLine("The picture is in landscape mode!");
            }
            else
            {
                Console.WriteLine("The picture is in portrait mode");
            }

            int speedLimit;
            int speed;

            Console.WriteLine("Please enter the speedlimit:");
            speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the speed of the car:");
            speed = int.Parse(Console.ReadLine());
            if (speed > speedLimit)
            {
                int points = ((speed - speedLimit) / 5) + 1;
                if (points > 12)
                {
                    Console.WriteLine("Licence Suspended");
                }
                else
                {
                    Console.WriteLine("You have {0} points removed from you Licence", points);
                }
            }
            else
            {
                Console.WriteLine("OK speed!");
            }
        }
    }
}
