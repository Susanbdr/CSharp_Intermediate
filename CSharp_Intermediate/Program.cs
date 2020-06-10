using System;
using System.Threading;

namespace CSharp_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
          var sqlConnection = new SqlConnection(null);

          sqlConnection.OpenConnection();

          if(sqlConnection.TimeSpan.Milliseconds < 0)
              Console.WriteLine("Connection Timed-Out");
          else
            sqlConnection.CloseConnection();

          var oracleConnection = new OracleConnection("oracle");

          oracleConnection.OpenConnection();

          if(oracleConnection.TimeSpan.Milliseconds < 0)
              Console.WriteLine("Connection Timed-Out");
          else
              oracleConnection.CloseConnection();
        }
    }
}
