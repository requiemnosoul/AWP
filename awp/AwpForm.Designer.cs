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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.aboutButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.dbButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.ucDB1 = new awp.ucDB();
            this.ucAbout1 = new awp.ucAbout();
            this.ucSettings1 = new awp.ucSettings();
            this.ucHome1 = new awp.ucHome();
            this.contextMenuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (25)))), ((int) (((byte) (23)))), ((int) (((byte) (22)))));
            this.panelMenu.Controls.Add(this.sidePanel);
            this.panelMenu.Controls.Add(this.settingsButton);
            this.panelMenu.Controls.Add(this.aboutButton);
            this.panelMenu.Controls.Add(this.homeButton);
            this.panelMenu.Controls.Add(this.dbButton);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 450);
            this.panelMenu.TabIndex = 3;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Red;
            this.sidePanel.Location = new System.Drawing.Point(0, 70);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(5, 50);
            this.sidePanel.TabIndex = 6;
            this.sidePanel.Visible = false;
            // 
            // settingsButton
            // 
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.settingsButton.IconColor = System.Drawing.Color.White;
            this.settingsButton.IconSize = 30;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 180);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Rotation = 0D;
            this.settingsButton.Size = new System.Drawing.Size(180, 50);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.aboutButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.aboutButton.IconColor = System.Drawing.Color.White;
            this.aboutButton.IconSize = 30;
            this.aboutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutButton.Location = new System.Drawing.Point(0, 400);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Rotation = 0D;
            this.aboutButton.Size = new System.Drawing.Size(180, 50);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "About";
            this.aboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.Color.White;
            this.homeButton.IconSize = 30;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 70);
            this.homeButton.Name = "homeButton";
            this.homeButton.Rotation = 0D;
            this.homeButton.Size = new System.Drawing.Size(180, 50);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // dbButton
            // 
            this.dbButton.FlatAppearance.BorderSize = 0;
            this.dbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.dbButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dbButton.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.dbButton.IconColor = System.Drawing.Color.White;
            this.dbButton.IconSize = 30;
            this.dbButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dbButton.Location = new System.Drawing.Point(0, 120);
            this.dbButton.Name = "dbButton";
            this.dbButton.Rotation = 0D;
            this.dbButton.Size = new System.Drawing.Size(180, 50);
            this.dbButton.TabIndex = 5;
            this.dbButton.Text = "Database";
            this.dbButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dbButton.UseVisualStyleBackColor = true;
            this.dbButton.Click += new System.EventHandler(this.dbButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.exitButton.IconColor = System.Drawing.Color.White;
            this.exitButton.IconSize = 28;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitButton.Location = new System.Drawing.Point(767, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Rotation = 0D;
            this.exitButton.Size = new System.Drawing.Size(33, 33);
            this.exitButton.TabIndex = 8;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(180, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 2);
            this.panel1.TabIndex = 9;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.LightGray;
            this.panelMain.Controls.Add(this.ucDB1);
            this.panelMain.Controls.Add(this.ucAbout1);
            this.panelMain.Controls.Add(this.ucSettings1);
            this.panelMain.Controls.Add(this.ucHome1);
            this.panelMain.Location = new System.Drawing.Point(180, 35);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(620, 415);
            this.panelMain.TabIndex = 10;
            // 
            // ucDB1
            // 
            this.ucDB1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (47)))), ((int) (((byte) (69)))), ((int) (((byte) (80)))));
            this.ucDB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDB1.Location = new System.Drawing.Point(0, 0);
            this.ucDB1.Margin = new System.Windows.Forms.Padding(2);
            this.ucDB1.Name = "ucDB1";
            this.ucDB1.Size = new System.Drawing.Size(620, 415);
            this.ucDB1.TabIndex = 3;
            // 
            // ucAbout1
            // 
            this.ucAbout1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucAbout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAbout1.Location = new System.Drawing.Point(0, 0);
            this.ucAbout1.Margin = new System.Windows.Forms.Padding(2);
            this.ucAbout1.Name = "ucAbout1";
            this.ucAbout1.Size = new System.Drawing.Size(620, 415);
            this.ucAbout1.TabIndex = 2;
            // 
            // ucSettings1
            // 
            this.ucSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSettings1.Location = new System.Drawing.Point(0, 0);
            this.ucSettings1.Margin = new System.Windows.Forms.Padding(2);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(620, 415);
            this.ucSettings1.TabIndex = 1;
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.Color.White;
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(0, 0);
            this.ucHome1.Margin = new System.Windows.Forms.Padding(2);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(620, 415);
            this.ucHome1.TabIndex = 0;
            // 
            // AwpForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (47)))), ((int) (((byte) (69)))), ((int) (((byte) (80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AwpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AwpForm_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton aboutButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private FontAwesome.Sharp.IconButton dbButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private FontAwesome.Sharp.IconButton homeButton;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton settingsButton;
        private System.Windows.Forms.Panel sidePanel;
        private awp.ucAbout ucAbout1;
        private awp.ucDB ucDB1;
        private awp.ucHome ucHome1;
        private awp.ucSettings ucSettings1;

        #endregion
    }
}