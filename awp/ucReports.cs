using System;
using System.Windows.Forms;

namespace awp
{
    internal partial class ucReports : UserControl
    {
        public ucReports()
        {
            InitializeComponent();
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
    }
}