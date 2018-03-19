using System;

namespace S5L31
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Close()
        {
            Console.WriteLine("OracleConnection Close");
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnection Open");
        }
    }
}
