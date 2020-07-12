using System.ComponentModel;

namespace awp
{
    partial class ucAbout
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 35F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 400);
            this.label1.TabIndex = 0;
            this.label1.Text = "Automated WorkPlace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Resize += new System.EventHandler(this.label1_Resize);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.label2.Location = new System.Drawing.Point(0, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Рычкова Анастасия Александровна\r\nОльхов Валерий Владимирович\r\nv.1.0\r\n2020";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucAbout
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucAbout";
            this.Size = new System.Drawing.Size(400, 400);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}