using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller1
{
    internal class Connection
    {
        private string connectionString;
        private SqlConnection connection;

        public bool SQLServerConnection()
        {
            connectionString = @"Data Source=SNCTP06LABF06\SQLEXPRESS;Initial Catalog=db_tcc;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            return true;
        }

        public void Open()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public SqlCommand CreateCommand()
        {
            return connection.CreateCommand();
        }
    }
}
