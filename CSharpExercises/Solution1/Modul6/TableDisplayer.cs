using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Modul6
{
    public class TableDisplayer
    {
        private readonly List<Tuple<string, int>> _headers;

        public TableDisplayer(IEnumerable<Tuple<string, int>> headerSetup)
        {
            _headers = headerSetup.ToList();
        }

        public TableDisplayer(IEnumerable<string> headers)
        {
            _headers = new List<Tuple<string,int>>();
            foreach (var header in headers)
            {
                _headers.Add(new Tuple<string, int>(header, header.Length));
            }
        }

        public string CreateCell(string value, int size)
        {
            if (value.Length > size)
                return value.Substring(0, size - 3) + "...";

            while (value.Length < size)
            {
                value += " ";
            }

            return value;
        }
        

        public string CreateRow(IEnumerable<string> str)
        {
            var ret = "";
            
            for (var i = 0; i < Math.Min(str.Count(), _headers.Count); i++)
            {
                ret += CreateCell(str.ElementAt(i), _headers[i].Item2);
            }

            ret += "\n";

            return ret;
        }

        public string CreateTable(IEnumerable<string> str)
        {
            string ret = CreateRow(_headers.Select((item) => item.Item1));

            foreach (var item in str)
            {
                ret += CreateRow(item.Split(","));
            }

            return ret;
        }
            
    }
}