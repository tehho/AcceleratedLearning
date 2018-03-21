using System;
using System.IO;

namespace Modul7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CreateFileTest();
        }

        private static void CreateFileTest()
        {
            try
            {
                var fileName = GetFileName();

                ThrowIfFileExists(fileName);

                var input = GetTestInput();

                WriteToFile(fileName, input);
            }
            catch (FileNotFoundException fnfe)
            {
                PrintError("The file already exists");
            }
            catch (ArgumentException ae)
            {
                PrintError("The filename is not valid");
            }
            catch (DirectoryNotFoundException dnfe)
            {
                PrintError("Input output exception!");
            }
            catch (UnauthorizedAccessException uae)
            {
                PrintError("You're not autorized to create this file!");
            }
            catch (Exception e)
            {
                PrintError(e.Message);
            }
        }

        private static void WriteToFile(string fileName, string input)
        {
            File.WriteAllText(fileName, input);
        }

        private static string GetTestInput()
        {
            Console.WriteLine($"Enter a text:");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadLine();
            Console.ResetColor();
            return input;
        }

        private static void ThrowIfFileExists(string fileName)
        {
            if (File.Exists(fileName))
            {
                throw new FileNotFoundException();
            }
        }

        private static string GetFileName()
        {
            Console.WriteLine("Enter a file name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string fileName = Console.ReadLine();
            Console.ResetColor();
            return fileName;
        }

        private static void ChocolateTryCatchTest(int pieces)
        {
            try
            {
                var people = ChocolateQuary(pieces);
                var piece = pieces / (decimal) people;
                ChocolatePresent(piece);
            }
            catch (DivideByZeroException dbze)
            {
                PrintError("Zero people can't divide a chocolate. Take all for yourself!");
            }
            catch (Exception e)
            {
                PrintError(e.Message);
            }
        }

        private static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void ChocolateTest(int pieces)
        {
            decimal people = ChocolateQuary(pieces);
            ChocolatePresent(pieces / people);
        }

        private static void ChocolatePresent(decimal pieces)
        {
            Console.WriteLine($"Everyone gets {Math.Round(pieces, 2)} pieces");
        }

        private static int ChocolateQuary(int pieces)
        {
            Console.WriteLine($"The chocolate contains {pieces} pieces");
            Console.Write($"How many want to share: ");

            Console.ForegroundColor = ConsoleColor.Green;
            int people = int.Parse(Console.ReadLine());

            Console.ResetColor();

            return people;
        }

    }
}
