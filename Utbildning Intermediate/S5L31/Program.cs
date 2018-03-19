using System;
using System.Collections.Generic;

namespace S5L31
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = new DbCommand(new OracleConnection("oracle_mainframe"), "This is an instruction");

            command.Execute();
        }
    }
}
