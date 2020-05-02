using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace awp
{
    public class MyDB
    {
        public static MySqlConnection conn;
        public static void Connection(string serv, string login, string pass, string db)
        {
            string myConnectionString = "server="+serv+";uid="+login+";pwd="+pass+";database="+db;
            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                MessageBox.Show("Успешно!");
                //conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}