using System;
using System.Linq;
using System.IO;


namespace Modul9
{
    static class StringExtentions
    {
        public static string ToCapitilize(this string str)
        {
            if (str.Length == 0)
                return "";
            string temp = "";
            temp += str.Substring(0, 1).ToUpper();
            temp += str.Substring(1).ToLower();
            return temp;
        }
    }

    class Program
    {
        public delegate string CustomFormatString(string str);

        public delegate void MyAction();

        private static event MyAction SpacePressed;


        private static void Main(string[] args)
        {
            Events();

            //WatchAFolder("C:/TMP/");

            //Delegates();

            PressAnyKeyToContinue();
        }

        private static void Events()
        {
            SpacePressed += () => PrintNewline("");

            SpacePressed += () => Console.BackgroundColor = ConsoleColor.Yellow;
            SpacePressed += () => Console.ForegroundColor = ConsoleColor.Blue;

            SpacePressed += Separator;

            SpacePressed += GiveCoffee;
            SpacePressed += GiveCoffee;
            
            SpacePressed += Console.ResetColor;


            while (true)
            {
                var key = Console.ReadKey();

                if (key.KeyChar == 'q')
                    break;

                if (key.KeyChar == ' ')
                    SpacePressed();

                if (key.KeyChar == 'c')
                    Console.Clear();

            }
        }

        static void Separator()
        {
            PrintNewline("--------------");
        }
        static void GiveCoffee()
        {
            PrintNewline("Give me coffee");
        }


        private static void WatchAFolder(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                PrintNewline("Directory can't be Null or Empty.");
                return;
            }

            if (!Directory.Exists(path))
            {
                PrintNewline("Directory does not exist.");
                return;
            }

            var watcher = new FileSystemWatcher()
            {
                Path = path,
                IncludeSubdirectories = true,
                Filter = "*.txt",
            };

            watcher.Changed += OnCreated;
            watcher.Created += OnCreated;
            watcher.Deleted += OnCreated;
            watcher.Renamed += OnRenamed;

            watcher.EnableRaisingEvents = true;

            Console.WriteLine($"Press 'q' to quit the sample");
            while (true)
            {
                if (Console.ReadKey().KeyChar == 'q')
                    break;
            }
        }

        private static void OnCreated(object source, FileSystemEventArgs args)
        {
            Log($"File: {args.FullPath} {args.ChangeType.ToString()}");
        }

        private static void OnRenamed(object source, RenamedEventArgs args)
        {
            Log($"File: {args.OldFullPath} changed name to {args.FullPath}");
        }


        private static void Delegates()
        {
            AskUserAndRespond(ConvertToUpper);

            AskUserAndRespond((item) =>
            {
                if (item.Length == 0)
                    return "";
                string temp = item.Substring(0, 1).ToUpper();
                temp += item.Substring(1).ToLower();
                return temp;
            });

            AskUserAndRespond(ConvertToThreeTimes);
            AskUserAndRespond(ConvertToStarInbetween);
        }

        private static void AskUserAndRespond(CustomFormatString del)
        {
            string input = GetInputWithMessage("Enter a string to convert: ");
            string answer = del(input);
            PrintNewline(answer);
        }

        private static void PressAnyKeyToContinue()
        {
            Console.ReadKey();
        }

        static string ConvertToUpper(string str)
        {
            return str.ToUpper();
        }

        static string ConvertToThreeTimes(string str)
        {
            return str + str + str;
        }

        static string ConvertToStarInbetween(string str)
        {
            var list = str.ToArray();
            var ret = string.Join("*", list);
            return ret;
        }


        private static string GetInputWithMessage(string message)
        {
            Print(message);
            return GetInput();
        }

        private static string GetInput()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var str = Console.ReadLine();
            Console.ResetColor();
            return str;
        }

        private static void Log(string message)
        {
            PrintFile($"C:/TMP/statestik.log", $"{DateTime.Now.ToLongTimeString()} {message}");
            PrintNewline($"{DateTime.Now.ToLongTimeString()} {message}");
        }

        private static void PrintFile(string path, string message)
        {
            using (var writer = new StreamWriter(path,true))
            {
                writer.WriteLine(message);
            }
        }

        static void PrintNewline(string message)
        {
            Print(message + "\n");
        }

        static void Print(string message)
        {
            Console.Write(message);
        }
    }
}