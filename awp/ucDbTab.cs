using System;
using System.Windows.Forms;

namespace awp
{
    internal partial class ucDbTab : UserControl
    {
        private string[] connArray; 
        private string sql = "select version()";
        public ucDbTab(string DBMS, string [] connArr)
        {
            InitializeComponent();
            connArray = connArr; 
            txtDBMS.Text = DBMS;
            txtDB.Text = connArr[4];
            txtSV.Text = MySQL.myCommand(sql,connArr);
            txtHost.Text = connArr[0];
            txtUser.Text = connArr[2];
            txtLD.Text = "Not have";
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            string serv = connArray[0], login = connArray[2], pass = connArray[3], db = connArray[4];
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL files (*.sql)|*.sql";
            //ofd.FileName = db + "_dump_" + DateTime.Now.ToShortDateString().Replace(".", "_");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.FileName = "\"" + ofd.FileName + "\"";
                MySQL.myRestoreDump(serv, login, pass, db, ofd.FileName);
            }
        }

        private void buttonDump_Click(object sender, EventArgs e)
        {
            string serv = connArray[0], login = connArray[2], pass = connArray[3], db = connArray[4];
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL files (*.sql)|*.sql";
            sfd.FileName = db + "_dump_" + DateTime.Now.ToShortDateString().Replace(".", "_");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sfd.FileName = "\"" + sfd.FileName + "\"";
                MySQL.myDump(serv, login, pass, db, sfd.FileName);
            }
        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTime.Checked)
                groupBoxTime.Enabled = true;
            else
                groupBoxTime.Enabled = false;
        }
    }
}