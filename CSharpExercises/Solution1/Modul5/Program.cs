using System;
using PrintLibrary;
using System.Text;

namespace Modul5
{
    public class Point
    {
        public int x, y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x_, int y_)
        {
            x = x_;
            y = y_;
        }
        public void Print()
        {
            Console.WriteLine($"{x} {y}");
        }
    }
    class Program
    {
        static private FileLogger logger;
        static private ConsoleLogger clogger;

        static void Main(string[] args)
        {
            ReferenceTypes();
        }

        private static void ReferenceTypes()
        {
            Point point = new Point(3,4);

            point.Print();
            ChangePoint(point);
            point.Print();
        }

        private static void ChangePoint(Point point)
        {
            point.x = 999;
            point.y = 888;
        }

        private static void WorkingWithObjects()
        {
            clogger = new ConsoleLogger();
            logger = new FileLogger("test.txt");
            logger.NewFile();

            StopWatch stopWatch = new StopWatch();

            logger.Log($"Cycles,StringSize,Time\n");
            clogger.Log($"Cycles,StringSize,Time");

            string test = GenerateString("a", 15);
            int cycles = 5;

            for (int i = 0; i < 5; i++)
            {
                stopWatch.Start();

                string temp = GenerateString(test, cycles);

                stopWatch.Stop();

                TimeSpan time = stopWatch.GetElapsedTime();

                logger.Log($"{cycles},{temp.Length},{time}\n");
                clogger.Log($"{cycles},{temp.Length},{time}");

                cycles *= 10;
            }


            logger.Log($"Cycles,StringSize,Time\n");
            clogger.Seperator();
            clogger.Log($"StringBuilder Cycles,StringSize,Time");
            test = GenerateString("a", 15);
            cycles = 5;

            for (int i = 0; i < 5; i++)
            {
                stopWatch.Start();

                string temp = GenerateStringWithStringbuilder(test, cycles);

                stopWatch.Stop();

                TimeSpan time = stopWatch.GetElapsedTime();

                logger.Log($"{cycles},{temp.Length},{time}\n");
                clogger.Log($"{cycles},{temp.Length},{time}");

                cycles *= 10;
            }
        }

        static void Print(int cycles, int strSize, TimeSpan time)
        {
            Console.WriteLine($"{cycles.ToString().Fill(' ', 10)} {strSize.ToString().Fill(' ', 20)} {time}");
        }

        static string GenerateStringWithStringbuilder(string str, int cycles)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < cycles; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }

        static string GenerateString(string str, int cycles)
        {
            string result = "";
            for (int i = 0; i < cycles; i++)
            {
                result = result + str;
            }
            return result;
        }
    }
}
