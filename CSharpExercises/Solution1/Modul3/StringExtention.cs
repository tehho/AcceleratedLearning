namespace Modul3
{
    public static class StringExtention
    {
        public static string ToCapitilize(this string str)
        {
            if (str == "")
                return "";

            string temp = str[0].ToString().ToUpper();

            temp += str.Substring(1).ToLower();

            return temp;

        }

        public static string Remove(this string str, string rem)
        {
            return str.Replace(rem, "");
        }
    }
}
