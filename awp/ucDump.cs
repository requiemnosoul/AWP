using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace awp
{
    internal partial class ucDump : UserControl
    {
        public ucDump()
        {
            InitializeComponent();
        }

        private void dumpButton_Click(object sender, EventArgs e)
        {
            string serv = ucDB.serv, login = ucDB.login, pass = ucDB.pass, db = ucDB.db;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL files (*.sql)|*.sql";
            sfd.FileName = db + "_dump_" + DateTime.Now.ToShortDateString().Replace(".", "_");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sfd.FileName = "\"" + sfd.FileName + "\"";
                MySQL.myDump(serv, login, pass, db, sfd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(combo.Text != "")
                listBox1.Items.Add(combo.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            string temp = "";
            using (StreamReader sr = new StreamReader(@"log.txt"))
            {
                temp = sr.ReadToEnd();
            }

            using (StreamWriter sw = new StreamWriter(String.Format(@"auto_dump.bat")))
            {
                sw.WriteLine(temp);
            }

            MessageBox.Show("Bat файл помещен в каталог программы");
        }
    }
}