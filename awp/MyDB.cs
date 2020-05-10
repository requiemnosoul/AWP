using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awp
{
    public class MyDB
    {
        public static MySqlConnection conn;

        public static void Connection(string serv, string login, string pass, string db)
        {
            string myConnectionString = "server=" + serv + ";uid=" + login + ";pwd=" + pass + ";database=" + db;
            conn = new MySqlConnection(myConnectionString);
            Task.Run(() =>
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Nice");
                    //conn.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
        public static void myDump(string path)
        { 
            string command = $"/c mysqldump.exe -u {ucDB.login} -h {ucDB.serv} -p{ucDB.pass} {ucDB.db} > {path}";
            Process.Start("CMD.exe",command);
        }
    }
}