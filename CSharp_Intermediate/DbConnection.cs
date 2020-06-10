using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Intermediate
{
    public abstract class DbConnection
    {
        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException();
                
            this.ConnectionString = connectionString;
        }
        public string ConnectionString { get; set; }
        public TimeSpan TimeSpan { get; set; }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
