using System.ComponentModel;

namespace awp
{
    partial class ucDump
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDump = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonDump);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 395);
            this.panel1.TabIndex = 1;
            // 
            // buttonDump
            // 
            this.buttonDump.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDump.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonDump.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonDump.ForeColor = System.Drawing.Color.Black;
            this.buttonDump.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.buttonDump.IconColor = System.Drawing.Color.Black;
            this.buttonDump.IconSize = 30;
            this.buttonDump.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDump.Location = new System.Drawing.Point(188, 220);
            this.buttonDump.Name = "buttonDump";
            this.buttonDump.Rotation = 0D;
            this.buttonDump.Size = new System.Drawing.Size(115, 40);
            this.buttonDump.TabIndex = 4;
            this.buttonDump.Text = "Dump";
            this.buttonDump.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDump.UseVisualStyleBackColor = true;
            this.buttonDump.Click += new System.EventHandler(this.dumpButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Backup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucDump
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ucDump";
            this.Size = new System.Drawing.Size(600, 450);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton buttonDump;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}