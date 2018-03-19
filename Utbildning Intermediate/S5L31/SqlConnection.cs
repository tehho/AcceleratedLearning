using System;

namespace S5L31
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void Close()
        {
            Console.WriteLine("SqlConnection Close");
        }

        public override void Open()
        {
            Console.WriteLine("SqlConnection Open");
        }
    }
}
