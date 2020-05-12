using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awp
{
    public class MySQL
    {
        public static MySqlConnection conn;

        public static void Connection(string serv, string login, string pass, string db, string port)
        {
            ucDB ucDB1 = new ucDB();

            string myConnectionString = $"Server={serv}; Port={port}; Uid={login}; Pwd={pass}; Database={db}";
            conn = new MySqlConnection(myConnectionString);
            Task.Run(() =>
            {
                try
                {
                    conn.Open();
                    ucDB1.successfulConnection(db);
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