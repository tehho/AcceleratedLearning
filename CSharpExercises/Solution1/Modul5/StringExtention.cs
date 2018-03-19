namespace Modul5
{
    public static class StringExtention
    {
        static public string Fill(this string str, char fillValue, int size)
        {
            string temp = str;
            while(temp.Length <= size)
            {
                temp += fillValue;
            }
            return temp;
        }
    }
}
