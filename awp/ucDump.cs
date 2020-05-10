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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL files (*.sql)|*.sql";
            sfd.FileName = "dump_" + DateTime.Now.ToShortDateString().Replace(".", "_");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MyDB.myDump(sfd.FileName);
                
            }
        }
    }
}