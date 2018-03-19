using System;
using System.Collections.Generic;
using System.Linq;
using PrintLibrary;

namespace Modul4
{

    class Program
    {
        static ILogger logger;
        static void Main(string[] args)
        {
            logger = new ConsoleLogger(GetSettingErrorMessages());

            Validation();
        }

        static char GetSeperator()
        {
            logger.Log("Which seperator do you want to use (default is ,)?");
            string value = Readline();
            if (value != "")
                return value[0];

            return ',';
        }
        static bool GetSettingErrorMessages()
        {
            Console.WriteLine("Do you want to show errors (default is yes)?");
            string value = Readline();

            if (value == "")
                return true;

            if (value.ToLower() == "yes")
                return true;
            
            return false;
        }

        static void Validation()
        {

            List<string> names = GetValidNames();

            logger.Seperator();

            PrintList(SUPERLIST(names));
        }

        static List<string> GetValidNames()
        {
            bool isNotValid = true;
            List<string> names = new List<string>();

            char seperator = GetSeperator();

            while (isNotValid)
            {
                names = GetNames(seperator);
                isNotValid = false;
                foreach(var name in names)
                {
                    if(!IsNameValid(name))
                    {
                        isNotValid = true;
                        logger.LogError("A persons name can only be 2 to 9 letters long.");
                    }
                }
            }
            
            return names;
        }

        static bool IsNameValid(string name)
        {
            return (name.Length < 10 && name.Length > 1);
        }

        static void CreatingMethods()
        {
            List<string> names = GetNames(',');
            
            PrintList(SUPERLIST(names));
        }

        static List<string> SUPERLIST(List<string> list)
        {
            return list.Where(item => item.Trim() != "")
                       .Select(item => "SUPER-"+item.ToUpper())
                       .ToList();
        }

        static void PrintList(List<string> list)
        {
            list.ForEach(item => logger.Log($"***{item.Trim()}***"));
        }

        static List<string> GetNames(char seperator)
        {
            logger.Log("Enter a list of names: ");
            List<string> list = Readline().Split(seperator)
                                          .Where(name => name != "")
                                          .ToList();
            while (list.Count == 0)
            {
                logger.LogError("The list don't contain any names");
                logger.Log("Enter a list of names: ");

                list = Readline().Split(",")
                                .Where(name => name != "")
                                .ToList();
            }
            return list;
        }

        static string Readline()
        {
            return Console.ReadLine();
        }

        static void NewLine()
        {
            Console.WriteLine();
        }

        static void WriteLine(string str)
        {
            Write(str);
            NewLine();
        }

        static void Write(string str)
        {
            Console.Write(str);
        }
    }
}
