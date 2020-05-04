using System;
using System.Collections.Generic;
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
            //TODO add start uc
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

        private void AwpForm_MouseDown(object sender, MouseEventArgs e) // Перемещение формы по экрану
        {
            base.Capture = false;
            var m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        void ActiveButton(Button b, Panel p, UserControl uc)
        {
            uc.BringToFront();
            p.Height = b.Height;
            p.Top = b.Top;
            p.Visible = true;
            b.BackColor = this.BackColor;
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
            ActiveButton(sender as Button, sidePanel, ucHome1);
        }

        private void dbButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as Button, sidePanel, ucDB1);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as Button, sidePanel, ucSettings1);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as Button, sidePanel, ucAbout1);
        }
    }
}