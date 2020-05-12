using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace awp
{
    public partial class ucDB : UserControl
    {
        public static string serv = "192.168.0.10", login = "user338", pass = "3228", db = "db1", port = "3306";
        public ucDB()
        {
            InitializeComponent();
            textBox1.Text = serv;
            textBox2.Text = port;
            textBox3.Text = login;
            textBox4.Text = pass; 
            textBox5.Text = db;
            
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboDBMS.Text != "")
            {
                serv = textBox1.Text;
                port = textBox2.Text;
                login = textBox3.Text;
                pass = textBox4.Text;
                db = textBox5.Text;
                ConnectionDB();
            }
            else
            {
                MessageBox.Show("Select a DBMS");
            }
        }

        public void successfulConnection(string db)
        {
            MessageBox.Show("Nice");
            //panelAddConnection.Visible = false;
            ucDbTab ucDbTab1 = new ucDbTab();
            ucDbTab1.Location = new Point(7,43);
            ucDbTab1.Size = new Size(606,365);
            ucDbTab1.BringToFront();
        }
        
        void ConnectionDB()
        {
            MySqlConnection c = new MySqlConnection();
            switch (comboDBMS.Text)
            {
                case "MySQL":
                    MySQL.Connection(serv, login, pass, db, port);
                    break;
                case "MS SQL Server":
                    MsSQL.Connection(serv, login, pass, db, port);
                    break;
            }
        }

        string standartPort(string DBMS)
        {
            string stdPort;
            switch (DBMS)
            {
                case "MySQL":
                    stdPort = "3306";
                    break;
                case "MS SQL Server":
                    stdPort = "1433";
                    break;
                default:
                    stdPort = "";
                    break;
            }
            return stdPort;
        }

        private void comboDBMS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(checkPort.Checked == false)
                textBox2.Text = standartPort(comboDBMS.Text); 
            textBox1.Enabled = true; 
            textBox3.Enabled = true; 
            textBox4.Enabled = true; 
            textBox5.Enabled = true;
        }

        private void checkPort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPort.Checked) { textBox2.Enabled = true; textBox2.Text = ""; }
            else { textBox2.Enabled = false; textBox2.Text = standartPort(comboDBMS.Text); }
        }

        private void buttonAddConnection_Click(object sender, EventArgs e)
        {
            panelAddConnection.Visible = true;
        }
    }
}