using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace awp
{
    public partial class ucDB : UserControl
    {
        Dictionary<IconButton,UserControl> tabs = new Dictionary<IconButton, UserControl>();

        public static string serv = "192.168.31.171", login = "root", pass = "Nanaka810", db = "mysql", port = "3306";

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
                serv = textBox1.Text;
                port = textBox2.Text;
                login = textBox3.Text;
                pass = textBox4.Text;
                db = textBox5.Text;
                ConnectionDB();
        }

        public void successfulConnection(string db)
        {
            MessageBox.Show("Nice");
            newConnTab(db);
        }

        public void errorConnection(string db)
        {
            
        }
        
        void ConnectionDB()
        {
            switch (comboDBMS.Text)
            {
                case "MySQL":
                    //MySQL c = new MySQL();
                    //MySQL.Connection(serv, login, pass, db, port);
                    ConnectionMySql(serv, login, pass, db, port);
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
            buttonConnect.Enabled = true;
        }

        private void checkPort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPort.Checked) { textBox2.Enabled = true; textBox2.Text = ""; }
            else { textBox2.Enabled = false; textBox2.Text = standartPort(comboDBMS.Text); }
        }

        private void buttonAddConnection_Click(object sender, EventArgs e)
        {
            panelAddConnection.BringToFront();
            activeTab(sender as IconButton);
        }
        public void newConnTab(string _db)
        {
            IconButton B = Clone(btnTabDb);
            B.Name = "btn_" + _db;
            B.Text = _db;
            B.Location = new Point(10+(tabs.Count * 120),6);
            B.Visible = true;
            B.FlatAppearance.BorderSize = 0;
            B.Click += btnTabDb_Click;
            Controls.Add(B);
            
            UserControl ucTab = new ucDbTab();
            ucTab.Name = "tab_" + _db;
            ucTab.Controls[0].Text += _db;
            ucTab.Location = new Point(7,43);
            Controls.Add(ucTab);
            
            buttonAddConnection.Location = new Point(130 + (tabs.Count * 120),6);

            tabs[B] = ucTab;
            btnTabDb_Click(B,EventArgs.Empty);
        }
        
        public static T Clone<T>(T controlToClone) where T : Control
        {
            T instance = Activator.CreateInstance<T>();
 
            PropertyInfo[] props = controlToClone.GetType().GetProperties();
 
            foreach (PropertyInfo pi in props)
            {
                if ((pi.CanWrite) && !(pi.Name == "WindowTarget") && !(pi.Name == "Capture"))
                {
                    pi.SetValue(instance, pi.GetValue(controlToClone, null), null);
                }
            }
            return instance;
        }
        
        private readonly Queue<IconButton> _currentTab = new Queue<IconButton>();
        private void btnTabDb_Click(object sender, EventArgs e)
        {
            tabs[sender as IconButton].BringToFront();
            activeTab(sender as IconButton);
        }

        void activeTab(IconButton b)
        {
            if(b.Name != "buttonAddConnection")
                b.BackColor = Color.White;
            b.IconColor = Color.Red;
            b.ForeColor = Color.Black;
            if (_currentTab.Contains(b)==false)
                _currentTab.Enqueue(b);
            if (_currentTab.Count > 1)
            {
                if (_currentTab.Peek().Name == "buttonAddConnection")
                    _currentTab.Peek().IconColor = Color.Pink;
                else
                    _currentTab.Peek().IconColor = Color.Yellow;
                _currentTab.Peek().BackColor = BackColor;
                _currentTab.Peek().ForeColor = Color.White;
                _currentTab.Dequeue();
            }
        }
        public void ConnectionMySql(string serv, string login, string pass, string db, string port)
        {
            string myConnectionString = $"Server={serv}; Port={port}; Uid={login}; Pwd={pass}; Database={db}";
            MySqlConnection conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                newConnTab(db);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}