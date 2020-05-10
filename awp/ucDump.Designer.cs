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
            this.dumpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dumpButton
            // 
            this.dumpButton.ForeColor = System.Drawing.Color.Black;
            this.dumpButton.Location = new System.Drawing.Point(214, 145);
            this.dumpButton.Name = "dumpButton";
            this.dumpButton.Size = new System.Drawing.Size(162, 88);
            this.dumpButton.TabIndex = 0;
            this.dumpButton.Text = "Dump";
            this.dumpButton.UseVisualStyleBackColor = true;
            this.dumpButton.Click += new System.EventHandler(this.dumpButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dumpButton);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 401);
            this.panel1.TabIndex = 1;
            // 
            // ucDump
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (47)))), ((int) (((byte) (69)))), ((int) (((byte) (80)))));
            this.Controls.Add(this.panel1);
            this.Name = "ucDump";
            this.Size = new System.Drawing.Size(620, 415);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button dumpButton;
        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}