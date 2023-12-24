using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection(@"Data Source=localhost;Initial Catalog=bd;Integrated Security=True");
        
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if(connection.State != System.Data.ConnectionState.Closed) 
            { 
                connection.Close();
            }
        }

        public MySqlConnection getConnection() 
        {
            return connection;
        }
    }
}
