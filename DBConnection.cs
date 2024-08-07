using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Singleton
{
    internal class DBConnection
    {
       private static DBConnection? instance;
       private SqlConnection connection; 
       private DBConnection()
        {
            string connectionString = "Data Source=server;Initial Catalog=database;User ID=username;Password=password";
            connection = new SqlConnection(connectionString);

        }

        public void OpenConnection() 
        {
            connection.Open();
            Console.WriteLine("The connection is established");
        }
        public static DBConnection GetInstance()
        {
            if (instance == null)
            { 
                instance = new DBConnection();
            }
            return DBConnection.instance;
        }
    }
}
