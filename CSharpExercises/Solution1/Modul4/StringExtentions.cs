using System.Linq;

namespace Modul4
{
    public static class StringExtentions
    {
        public static string Remove(this string str, string rem)
        {
            return str.Replace(rem, "");
        }

        static public string RemoveAll(this string str, string rem)
        {
            while (str.Contains(rem))
                str = str.Remove(rem);
            return str;
        }

        static public string RemoveAll(this string str, char rem)
        {
            return str.RemoveAll(rem.ToString());
        }

        static public string Trim(this string str, string rem)
        {
            rem.ToList().ForEach(c => str = str.RemoveAll(c));
            return str;
        }
    }
}
