using System;

namespace S5L31
{
    abstract public class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw (new InvalidOperationException("connectionString"));

            ConnectionString = connectionString;
            Timeout = new TimeSpan(0, 0, 0, 2);
        }

        abstract public void Open();
        abstract public void Close();

    }
}
