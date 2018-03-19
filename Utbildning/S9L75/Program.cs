using System;
using System.IO;

namespace S9L75
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-

            string path = @"C:\Prodjects\Utbildning\Data\temp.txt";

            Console.WriteLine("There are {0} words in {1}", NumberOfWords(File.ReadAllText(path)), Path.GetFullPath(path));

            // 2-

             Console.WriteLine("The longest word in {1} is {0}", LongestWordIn(File.ReadAllText(path)), Path.GetFullPath(path));

        }

        static public int NumberOfWords(string input)
        {
            var list = input.Split(null);

            return list.Length;
        }

        static public string LongestWordIn(string input)
        {
            var list = input.Split(null);

            string ret = "";

            foreach (var value in list)
            {
                if (value.Length > ret.Length)
                    ret = value;
            }

            return ret;
        }
    }
}
