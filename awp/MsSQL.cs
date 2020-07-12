using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace awp
{
    internal class MsSQL
    {
        public static  SqlConnection conn;

        public static void Connection(string serv, string login, string pass, string db, string port)
        {
            ucDB ucDB1 = new ucDB();
            
            string ConnectionString = $"Data Source={serv},{port};Initial Catalog={db};User id={login};Password={pass};";
            conn = new SqlConnection(ConnectionString);
            Task.Run(() =>
            {
                try
                {
                    conn.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
        public static void msDump(string serv, string login, string pass, string db, string path)
        { 
            string command = $"/c sqldumper.exe -u {login} -h {serv} -p{pass} {db} > {path}";
            Process.Start("CMD.exe",command);
        }
        public static void msRestoreDump(string serv, string login, string pass, string db, string path)
        { 
            string command = $"/c mssql.exe -u {login} -h {serv} -p{pass} {db} < {path}";
            Process.Start("CMD.exe",command);
        }

        public static string msCommand(string sql,string [] connArr)
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