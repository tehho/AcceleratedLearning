using System;
using System.IO;

namespace PrintLibrary
{
    public class FileLogger : ILogger
    {
        private string _file;

        public FileLogger(string file)
        {
            _file = file;
        }

        public void NewFile()
        {
            File.Delete(_file);
        }

        public void Log(string str)
        {
            ReadToFile($"{GetDateAndTime()}: {str}");
        }

        public void LogError(string str)
        {
            ReadToFile($"{GetDateAndTime()}: ERROR - {str}");
        }

        public void Seperator()
        {
            ReadToFile("----------");
        }

        private string GetDateAndTime()
        {   
            return $"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToLongTimeString()}";
        }

        private void ReadToFile(string str)
        {
            File.AppendAllText(_file, str);
        }
    }
}
