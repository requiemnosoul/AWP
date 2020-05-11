using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace awp
{
    public partial class ucDump : UserControl
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
            sfd.FileName = "dump_" + DateTime.Now.ToShortDateString().Replace(".", "_");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sfd.FileName = "\"" + sfd.FileName + "\"";
                MySQL.myDump(serv, login, pass, db, sfd.FileName);
            }
        }
    }
}