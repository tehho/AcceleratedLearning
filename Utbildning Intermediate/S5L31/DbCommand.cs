using System;

namespace S5L31
{
    public class DbCommand
    {
        DbConnection _connection;
        string _instructions;

        public DbCommand(DbConnection dbConnection, string instructions)
        {
            if (dbConnection == null)
                throw (new InvalidOperationException("dbConnection"));

            if (String.IsNullOrWhiteSpace(instructions))
                throw (new InvalidOperationException(instructions));
            
            _connection = dbConnection;
            _instructions = instructions;
        }

        public void Execute()
        {
            _connection.Open();

            Console.WriteLine(_instructions);

            _connection.Close();
        }

    }
}
