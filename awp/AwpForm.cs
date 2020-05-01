using System;
using System.Drawing;
using System.Windows.Forms;

namespace awp
{
    public partial class AwpForm : Form
    {
        private string loginMyDB, passMyDB, nameMyDB;

        public AwpForm()
        {
            InitializeComponent();
            var connSQL = new Control []{ new ucMySQL(), new ucMsSQL(), new ucHome() };
            notifyIcon1.Visible = true;
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            drawingUC(connSQL);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Form close = new CloseForm(this);
                close.Show();
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void AwpForm_MouseDown(object sender, MouseEventArgs e) // Перемещение формы по экрану
        {
            base.Capture = false;
            var m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void drawingUC(Control[] f)
        {
            for (int i = 0; i < 2; i++)
            {
                this.Controls.Add(f[i]);
                f[i].Width = 600;
                f[i].Height = 420;
                f[i].Left = 200;
                f[i].Top = 30;
            }
        }
    }
}