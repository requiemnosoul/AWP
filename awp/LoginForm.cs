using System;
using System.Windows.Forms;

namespace awp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form awp = new AwpForm();
            awp.Show();
            this.Hide();
        }
    }
}