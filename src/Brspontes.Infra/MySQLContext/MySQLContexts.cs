using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Infra.MySQLContext
{
    public class MySQLContexts : IDisposable
    {
        public const string ConnectionString = "Server=LAPTOP-SLILPRNP;Database=dbmetupitau;Uid=root;Pwd=root;";
        //public const string ConnectionString = "Server=remotemysql.com;Port=3306;Database=vO3cnarTA1;Uid=vO3cnarTA1;Pwd=AZMzdzRCxL;";
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
