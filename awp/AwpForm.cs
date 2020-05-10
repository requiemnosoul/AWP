using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Org.BouncyCastle.Utilities.Encoders;

namespace awp
{
    public partial class AwpForm : Form
    {
        private readonly Queue<IconButton> _currentButton = new Queue<IconButton>();
        public AwpForm()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
            panelMenu.Controls.Add(sidePanel);
            sidePanel.BringToFront();
            ucHome1.BringToFront();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Form close = new CloseForm(this);
                close.ShowDialog();
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

        private void AwpForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            var m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        void ActiveButton(IconButton b, Panel p, UserControl uc)
        {
            uc.BringToFront();
            p.Height = b.Height;
            p.Top = b.Top;
            p.Visible = true;
            b.BackColor = this.BackColor;
            b.IconColor = Color.FromArgb(10, 234, 246);
            if (_currentButton.Contains(b)==false)
                _currentButton.Enqueue(b);
            if (_currentButton.Count > 1)
            {
                _currentButton.Peek().BackColor = panelMenu.BackColor;
                _currentButton.Peek().IconColor = Color.White;
                _currentButton.Dequeue();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as IconButton, sidePanel, ucHome1);
        }

        private void dbButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as IconButton, sidePanel, ucDB1);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as IconButton, sidePanel, ucSettings1);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as IconButton, sidePanel, ucAbout1);
        }

        private void dumpButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as IconButton, sidePanel, ucDump1);
        }
    }
}