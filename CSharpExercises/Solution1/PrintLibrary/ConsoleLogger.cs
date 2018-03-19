using System;

namespace PrintLibrary
{

    public class ConsoleLogger : ILogger
    {
        private bool _logError;

        public ConsoleLogger()
        {
            _logError = true;
        }

        public ConsoleLogger(bool logError)
        {
            _logError = logError;
        }

        public void ChangeColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void ResetColor()
        {
            Console.ResetColor();
        }

        public void Log(string str)
        {
            Console.WriteLine($"{GetDateAndTime()}: {str}");
        }
        public void Seperator()
        {
            Console.WriteLine();
        }

        public void LogError(string str)
        {
            ChangeColor(ConsoleColor.Red);

            Console.WriteLine($"{GetDateAndTime()}: ERROR - {str}");

            ResetColor();
        }

        private string GetDateAndTime()
        {
            return $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}";
        }
    }
}
