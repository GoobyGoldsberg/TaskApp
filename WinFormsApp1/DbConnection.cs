using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DbConnection
    {   
        private string _connectionString = "server=127.0.0.1;uid=root;pwd=Darknes221;database=testdb";
        private static MySqlConnection? connection;


        public MySqlConnection GetConnection()
        {   
            if (connection == null)
            {
                connection = new();
                connection.ConnectionString = _connectionString;
            }
            
            return connection;
        }

        public void ConnectToDb()
        {
            try
            {
                GetConnection().Open();
                
                Console.WriteLine("Connected to Db");
                
            }
            catch
            {
                
            }
        }
    }
}
