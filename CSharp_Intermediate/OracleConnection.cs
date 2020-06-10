using System;

namespace CSharp_Intermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening Oracle Database Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing Oracle Database Connection");
        }
    }
}