using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace awp
{
    public class MyDB
    {
        void connection(string login, string pass, string db)
        {
            MySqlConnection conn;
            string myConnectionString = String.Format("server=127.0.0.1;uid={0};pwd={1};database={2}",login,pass,db);
            try
            {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}