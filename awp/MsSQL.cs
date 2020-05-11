using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awp
{
    public class MsSQL
    {
        public static  SqlConnection conn;

        public static void Connection(string serv, string login, string pass, string db, string port)
        {
            string ConnectionString = $"Data Source={serv},{port};Initial Catalog={db};User id={login};Password={pass};";
            conn = new SqlConnection(ConnectionString);
            Task.Run(() =>
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Nice");
                    //conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        public static void msDump()
        {
            
        }
    }
}