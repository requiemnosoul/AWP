using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace awp
{
    public partial class AwpForm : Form
    {
        public static List<Control> cnt = new List<Control>();
        private readonly Queue<IconButton> _currentButton = new Queue<IconButton>();
        internal AwpForm()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
            panelMenu.Controls.Add(sidePanel);
            sidePanel.BringToFront();
            ucHome1.BringToFront();
            foreach (Control control in panelMenu.Controls)
            {
                if(control is IconButton)
                    cnt.Add(control);
            }
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
            p.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            b.BackColor = Color.White;
            b.ForeColor = Color.FromArgb(53, 75, 101);
            b.IconColor = Color.FromArgb(53, 75, 101);
            if (_currentButton.Contains(b)==false)
                _currentButton.Enqueue(b);
            if (_currentButton.Count > 1)
            {
                _currentButton.Peek().BackColor = panelMenu.BackColor;
                _currentButton.Peek().IconColor = Color.White;
                _currentButton.Peek().ForeColor = Color.White;
                _currentButton.Dequeue();
            }
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
            sidePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }

        private void dumpButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as IconButton, sidePanel, ucDump1);
        }
        
        private void reportsButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender as IconButton, sidePanel, ucReports1);
        }
        
        string textAbout, textAwp;
        private int widthMenu;
        private void awpButton_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width > 60)
            {
                widthMenu = panelMenu.Width;
                panelMenu.Width = 55;
                awpButton.Padding = new Padding(10,0,0,0);
                awpButton.IconChar = IconChar.Bars;
                textAbout = aboutButton.Text;
                textAwp = awpButton.Text;
                aboutButton.Text = "";
                awpButton.Text = "";
                panel1.Location = new Point(panelMenu.Width - panel1.Width,panel1.Location.Y);
            }
            else
            {
                awpButton.Padding = new Padding(0,0,0,0);
                panelMenu.Width = widthMenu;
                panel1.Location = new Point(panelMenu.Width - panel1.Width,panel1.Location.Y);
                awpButton.IconChar = IconChar.None;
                awpButton.Text = textAwp;
                aboutButton.Text = textAbout;
            }
        }
    }
}