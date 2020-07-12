using System.Collections.Generic;
using System.ComponentModel;

namespace awp
{
    partial class AwpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AwpForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.dbButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.reportsButton = new FontAwesome.Sharp.IconButton();
            this.dumpButton = new FontAwesome.Sharp.IconButton();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.awpButton = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutButton = new FontAwesome.Sharp.IconButton();
            this.ucSettings1 = new awp.ucSettings();
            this.ucDump1 = new awp.ucDump();
            this.ucDB1 = new awp.ucDB();
            this.ucHome1 = new awp.ucHome();
            this.ucReports1 = new awp.ucReports();
            this.ucAbout1 = new awp.ucAbout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon) (resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Red;
            this.sidePanel.Location = new System.Drawing.Point(0, 50);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(5, 50);
            this.sidePanel.TabIndex = 6;
            this.sidePanel.Visible = false;
            // 
            // dbButton
            // 
            this.dbButton.FlatAppearance.BorderSize = 0;
            this.dbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.dbButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dbButton.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.dbButton.IconColor = System.Drawing.Color.White;
            this.dbButton.IconSize = 30;
            this.dbButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dbButton.Location = new System.Drawing.Point(0, 100);
            this.dbButton.Name = "dbButton";
            this.dbButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dbButton.Rotation = 0D;
            this.dbButton.Size = new System.Drawing.Size(200, 50);
            this.dbButton.TabIndex = 5;
            this.dbButton.Text = "        Базы данных";
            this.dbButton.UseVisualStyleBackColor = true;
            this.dbButton.Click += new System.EventHandler(this.dbButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.Color.White;
            this.homeButton.IconSize = 30;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 50);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homeButton.Rotation = 0D;
            this.homeButton.Size = new System.Drawing.Size(200, 50);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Главная ";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.reportsButton.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.reportsButton.IconColor = System.Drawing.Color.White;
            this.reportsButton.IconSize = 30;
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(0, 150);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reportsButton.Rotation = 0D;
            this.reportsButton.Size = new System.Drawing.Size(200, 50);
            this.reportsButton.TabIndex = 5;
            this.reportsButton.Text = "Отчеты  ";
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // dumpButton
            // 
            this.dumpButton.FlatAppearance.BorderSize = 0;
            this.dumpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.dumpButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dumpButton.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.dumpButton.IconColor = System.Drawing.Color.White;
            this.dumpButton.IconSize = 30;
            this.dumpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dumpButton.Location = new System.Drawing.Point(0, 200);
            this.dumpButton.Name = "dumpButton";
            this.dumpButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dumpButton.Rotation = 0D;
            this.dumpButton.Size = new System.Drawing.Size(200, 50);
            this.dumpButton.TabIndex = 5;
            this.dumpButton.Text = "Бэкап     ";
            this.dumpButton.UseVisualStyleBackColor = true;
            this.dumpButton.Click += new System.EventHandler(this.dumpButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.settingsButton.IconColor = System.Drawing.Color.White;
            this.settingsButton.IconSize = 30;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 250);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settingsButton.Rotation = 0D;
            this.settingsButton.Size = new System.Drawing.Size(200, 50);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings ";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Visible = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // awpButton
            // 
            this.awpButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.awpButton.FlatAppearance.BorderSize = 0;
            this.awpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.awpButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.awpButton.Font = new System.Drawing.Font("Brush Script MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.awpButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.awpButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.awpButton.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.awpButton.IconSize = 30;
            this.awpButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.awpButton.Location = new System.Drawing.Point(0, 0);
            this.awpButton.Name = "awpButton";
            this.awpButton.Rotation = 0D;
            this.awpButton.Size = new System.Drawing.Size(200, 50);
            this.awpButton.TabIndex = 7;
            this.awpButton.Text = "Automated WorkPlace";
            this.awpButton.UseVisualStyleBackColor = false;
            this.awpButton.Click += new System.EventHandler(this.awpButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (31)))), ((int) (((byte) (37)))), ((int) (((byte) (47)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.homeButton);
            this.panelMenu.Controls.Add(this.dbButton);
            this.panelMenu.Controls.Add(this.reportsButton);
            this.panelMenu.Controls.Add(this.dumpButton);
            this.panelMenu.Controls.Add(this.settingsButton);
            this.panelMenu.Controls.Add(this.aboutButton);
            this.panelMenu.Controls.Add(this.awpButton);
            this.panelMenu.Controls.Add(this.sidePanel);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 536);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (55)))), ((int) (((byte) (80)))));
            this.panel1.Location = new System.Drawing.Point(198, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 40);
            this.panel1.TabIndex = 8;
            // 
            // aboutButton
            // 
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.aboutButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.aboutButton.IconColor = System.Drawing.Color.White;
            this.aboutButton.IconSize = 30;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(0, 486);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.aboutButton.Rotation = 0D;
            this.aboutButton.Size = new System.Drawing.Size(200, 50);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "        О программе";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // ucSettings1
            // 
            this.ucSettings1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.ucSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSettings1.Location = new System.Drawing.Point(200, 0);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(584, 536);
            this.ucSettings1.TabIndex = 3;
            // 
            // ucDump1
            // 
            this.ucDump1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.ucDump1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDump1.Location = new System.Drawing.Point(200, 0);
            this.ucDump1.Name = "ucDump1";
            this.ucDump1.Size = new System.Drawing.Size(584, 536);
            this.ucDump1.TabIndex = 4;
            // 
            // ucDB1
            // 
            this.ucDB1.AutoScroll = true;
            this.ucDB1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.ucDB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDB1.Location = new System.Drawing.Point(200, 0);
            this.ucDB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucDB1.Name = "ucDB1";
            this.ucDB1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ucDB1.Size = new System.Drawing.Size(584, 536);
            this.ucDB1.TabIndex = 5;
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(200, 0);
            this.ucHome1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(584, 536);
            this.ucHome1.TabIndex = 7;
            // 
            // ucReports1
            // 
            this.ucReports1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.ucReports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReports1.Location = new System.Drawing.Point(200, 0);
            this.ucReports1.Margin = new System.Windows.Forms.Padding(2);
            this.ucReports1.Name = "ucReports1";
            this.ucReports1.Size = new System.Drawing.Size(584, 536);
            this.ucReports1.TabIndex = 8;
            // 
            // ucAbout1
            // 
            this.ucAbout1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucAbout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAbout1.Location = new System.Drawing.Point(200, 0);
            this.ucAbout1.Name = "ucAbout1";
            this.ucAbout1.Size = new System.Drawing.Size(584, 536);
            this.ucAbout1.TabIndex = 9;
            // 
            // AwpForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 536);
            this.Controls.Add(this.ucAbout1);
            this.Controls.Add(this.ucReports1);
            this.Controls.Add(this.ucHome1);
            this.Controls.Add(this.ucDB1);
            this.Controls.Add(this.ucDump1);
            this.Controls.Add(this.ucSettings1);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(216, 389);
            this.Name = "AwpForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWP";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AwpForm_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        public FontAwesome.Sharp.IconButton aboutButton;
        private FontAwesome.Sharp.IconButton awpButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public FontAwesome.Sharp.IconButton dbButton;
        public FontAwesome.Sharp.IconButton dumpButton;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public FontAwesome.Sharp.IconButton homeButton;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        public FontAwesome.Sharp.IconButton reportsButton;
        public FontAwesome.Sharp.IconButton settingsButton;
        private System.Windows.Forms.Panel sidePanel;
        private awp.ucAbout ucAbout1;
        private awp.ucDB ucDB1;
        private awp.ucDump ucDump1;
        private awp.ucHome ucHome1;
        private awp.ucReports ucReports1;
        private awp.ucSettings ucSettings1;

        #endregion
    }
}