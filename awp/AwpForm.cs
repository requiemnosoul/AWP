using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace awp
{
    public partial class AwpForm : Form
    {
        private readonly Queue<Button> _currentButton = new Queue<Button>();
        public AwpForm()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
            panelMenu.Controls.Add(sidePanel);       
            sidePanel.BringToFront();
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

        void drawingUC(Control[] f)
        {
            for (int i = 0; i < 3; i++)
            {
                this.Controls.Add(f[i]);
                f[i].Width = 600;
                f[i].Height = 420;
                f[i].Left = 200;
                f[i].Top = 30;
                f[i].BringToFront();
            }
        }

        void ActiveButton(Button b, Panel p)
        {
            p.Height = b.Height;
            p.Top = b.Top;
            p.Visible = true;
            b.BackColor = this.BackColor;//FromArgb(140,140,140);
            if (_currentButton.Contains(b)==false)
                _currentButton.Enqueue(b);
            if (_currentButton.Count > 1)
                _currentButton.Dequeue().BackColor = panelMenu.BackColor;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as Button, sidePanel);
        }

        private void dbButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as Button, sidePanel);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as Button, sidePanel);
        }
    }
}