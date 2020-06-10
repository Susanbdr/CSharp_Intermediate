using System;

namespace CSharp_Intermediate
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;

        private readonly string _command;
        public DbCommand(DbConnection dbConnection, string command)
        {
            if(string.IsNullOrWhiteSpace(command))
                throw new InvalidOperationException();

            this._dbConnection = dbConnection ?? throw new InvalidOperationException();
            this._command = command;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();

            Console.WriteLine("The command is: " + _command);

            _dbConnection.CloseConnection();
        }
    }
}