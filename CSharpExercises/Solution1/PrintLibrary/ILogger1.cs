namespace PrintLibrary
{
    public interface ILogger
    {
        void Log(string str);
        void LogError(string str);

        void Seperator();
    }
}