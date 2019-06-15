using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Infra.MySQLContext
{
    public class MySQLContexts : IDisposable
    {
        public const string ConnectionString = "Server=LAPTOP-SLILPRNP;Database=dbmetupitau;Uid=root;Pwd=root;";
        public MySqlConnection Connection { get; set; }

        public MySQLContexts()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        public void Dispose()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
                Connection.Close();
        }
    }
}
