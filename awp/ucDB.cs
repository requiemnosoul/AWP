using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace awp
{
    public partial class ucDB : UserControl
    {
        
        string serv = "192.168.31.171", login = "root", pass = "Nanaka810", db="mysql";
        public ucDB()
        {
            InitializeComponent();
        }
        private void buttonConnectMySQL_Click(object sender, EventArgs e)
        {
            serv = textBox1.Text;
            login = textBox3.Text;
            pass = textBox4.Text;
            db = textBox5.Text;
            MyDB.Connection(serv,login,pass,db);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MyDB.conn.Close();
            MessageBox.Show("Disconnect");
        }
    }
}