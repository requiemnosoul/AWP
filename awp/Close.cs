using System;
using System.Windows.Forms;

namespace awp
{
    public partial class Close : Form
    {
        public Close()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}