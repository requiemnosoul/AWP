using System.ComponentModel;

namespace awp
{
    partial class ucSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAccept = new FontAwesome.Sharp.IconButton();
            this.rbRu = new System.Windows.Forms.RadioButton();
            this.rbEn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 345);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAccept);
            this.groupBox1.Controls.Add(this.rbRu);
            this.groupBox1.Controls.Add(this.rbEn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAccept.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAccept.IconColor = System.Drawing.Color.Black;
            this.btnAccept.IconSize = 30;
            this.btnAccept.Location = new System.Drawing.Point(6, 81);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Rotation = 0D;
            this.btnAccept.Size = new System.Drawing.Size(104, 37);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // rbRu
            // 
            this.rbRu.Location = new System.Drawing.Point(6, 51);
            this.rbRu.Name = "rbRu";
            this.rbRu.Size = new System.Drawing.Size(104, 24);
            this.rbRu.TabIndex = 1;
            this.rbRu.TabStop = true;
            this.rbRu.Text = "Русский";
            this.rbRu.UseVisualStyleBackColor = true;
            // 
            // rbEn
            // 
            this.rbEn.Location = new System.Drawing.Point(6, 21);
            this.rbEn.Name = "rbEn";
            this.rbEn.Size = new System.Drawing.Size(104, 24);
            this.rbEn.TabIndex = 0;
            this.rbEn.TabStop = true;
            this.rbEn.Text = "English";
            this.rbEn.UseVisualStyleBackColor = true;
            // 
            // ucSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (75)))), ((int) (((byte) (101)))));
            this.Controls.Add(this.panel1);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(400, 400);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton btnAccept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbEn;
        private System.Windows.Forms.RadioButton rbRu;

        #endregion
    }
}