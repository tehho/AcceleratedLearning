using System;
using System.Collections.Generic;

namespace PrintLibrary
{
    public class DisplayTable
    {
        List<string> header;

        List<List<object>> list;

        public DisplayTable(List<string> header)
        {
            this.header = header;
        }

        void Add(List<object> obj)
        {
            list.Add(obj);
        }
    }
}
