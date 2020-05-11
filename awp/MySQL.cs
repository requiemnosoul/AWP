using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awp
{
    public class MySQL
    {
        static ucDB ucDB1 = new ucDB();
        public static MySqlConnection conn;

        public static void Connection(string serv, string login, string pass, string db, string port)
        {
            string myConnectionString = $"Server={serv}; Port={port}; Uid={login}; Pwd={pass}; Database={db}";
            conn = new MySqlConnection(myConnectionString);
            Task.Run(() =>
            {
                try
                {
                    conn.Open();
                    //ucDB1.successfulConnection(db);
                    ucDbTab ucDbTab1 = new ucDbTab();
                    ucDbTab1.Location = new Point(7,43);
                    ucDbTab1.Size = new Size(606,365);
                    ucDbTab1.BringToFront();
                    MessageBox.Show("Nice");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
        public static void myDump(string serv, string login, string pass, string db, string path)
        { 
            string command = $"/c mysqldump.exe -u {login} -h {serv} -p{pass} {db} > {path}";
            MessageBox.Show(command);
            Process.Start("CMD.exe",command);
        }
    }
}