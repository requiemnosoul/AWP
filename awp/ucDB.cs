using System;
using System.Windows.Forms;

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
            MyDB.Connection(serv, login, pass, db);
            MessageBox.Show("Ок");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}