using System;

namespace CSharp_Intermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public DateTime Started { get; set; }

        public override void OpenConnection()
        {
            Console.WriteLine("Open Sql Database Connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Close Sql Database Connection");
        }
    }
}