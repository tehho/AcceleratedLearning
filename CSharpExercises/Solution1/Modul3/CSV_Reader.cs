using System;
using System.IO;
using System.Collections.Generic;

namespace Modul3
{
    public class CSV_File
    {
        List<string[]> rows;

        public int Pos { get; set; }
        public int Size { get { return rows.Count; } }

        public CSV_File()
        {
            rows = new List<string[]>();
            Pos = 0;
        }

        public bool Open(string file)
        {
            if (Path.GetExtension(file) != ".csv")
            {
                Console.WriteLine("File not .csv");
                return false;
            }

            if (!File.Exists(file))
            {
                Console.WriteLine("File not found");
            }

            using (var sr = new StreamReader(file))
            {
                rows = new List<string[]>();

                while (!sr.EndOfStream)
                {
                    rows.Add(sr.ReadLine().Split(","));
                }
            }
            return true;
        }

        public string[] ReadRow(int pos)
        {
            if (pos >= Size)
            {
                throw new IndexOutOfRangeException();
            }

            return rows[pos];
        }

        public string[] ReadRow()
        {
            return ReadRow(Pos++);
        }
        

        public string[] ReadHeader()
        {
            return ReadRow(0);
        }

    }
}
