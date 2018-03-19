using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace S8L67
{
    public class ReverseCompairer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            return (new CaseInsensitiveComparer().Compare(y,x));
        }
    }
}
