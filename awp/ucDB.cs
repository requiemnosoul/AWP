using System;
using System.Windows.Forms;

namespace awp
{
    public partial class ucDB : UserControl
    {
        
        public static string serv = "192.168.31.186", login = "root", pass = "root", db="lr2";
        public ucDB()
        {
            InitializeComponent();
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            serv = textBox1.Text;
            login = textBox3.Text;
            pass = textBox4.Text;
            db = textBox5.Text;
            string DBMS = comboDBMS.Text;
            switch (DBMS)
            {
                case "MySQL":
                    MySQL.Connection(serv, login, pass, db);
                    MessageBox.Show(DBMS);
                    break;
                case "MS SQL Server":
                    MsSQL.Connection(serv,login,pass,db);
                    MessageBox.Show(DBMS);
                    break;
            }
            MessageBox.Show("Ок");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}