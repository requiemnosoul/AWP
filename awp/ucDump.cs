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

        private string serv, login, pass, db;
        private void dumpButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL files (*.sql)|*.sql";
            sfd.FileName = "dump_" + DateTime.Now.ToShortDateString().Replace(".", "_");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MySQL.myDump(serv, login, pass, db, sfd.FileName);
            }
        }
    }
}