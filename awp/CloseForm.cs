using System;
using System.Windows.Forms;

namespace awp
{
    public partial class CloseForm : Form
    {
        private readonly Form main;
        public CloseForm(Form f)
        {
            main = f;   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.WindowState = FormWindowState.Minimized;
            main.ShowInTaskbar = false;
            this.Close();
        }
    }
}