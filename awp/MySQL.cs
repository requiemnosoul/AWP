using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awp
{
    internal class MySQL
    {
        public static void Connection(string serv, string login, string pass, string db, string port)
        {
            ucDB ucDB1 = new ucDB();
        
            string myConnectionString = $"Server={serv}; Port={port}; Uid={login}; Pwd={pass}; Database={db}";
            MySqlConnection conn = new MySqlConnection(myConnectionString);
            Task.Run(() =>
            {
                try
                {
                    conn.Open();
                    //ucDB1.newConnTab(db);
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
            Process.Start("CMD.exe",command);
        }
        public static void myRestoreDump(string serv, string login, string pass, string db, string path)
        { 
            string command = $"/c mysql.exe -u {login} -h {serv} -p{pass} {db} < {path}";
            Process.Start("CMD.exe",command);
        }

        public static string myCommand(string sql,string [] connArr)
        {
            string myConnectionString = $"Server={connArr[0]}; Port={connArr[1]}; Uid={connArr[2]}; Pwd={connArr[3]}; Database={connArr[4]}";
            MySqlConnection conn = new MySqlConnection(myConnectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            string result = cmd.ExecuteScalar().ToString();
            conn.Close();

            return result;
        }
    }
}