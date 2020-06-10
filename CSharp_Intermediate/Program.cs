using System;
using System.Threading;

namespace CSharp_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
          var dbCommand = new DbCommand(new OracleConnection("Oracle"), "Run" );

          dbCommand.Execute();
        }
    }
}
