using System.ComponentModel;
using System.Windows.Forms;

namespace awp
{
    partial class ucDB
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
            this.checkPort = new System.Windows.Forms.CheckBox();
            this.comboDBMS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddConnection = new FontAwesome.Sharp.IconButton();
            this.btnTabDb = new FontAwesome.Sharp.IconButton();
            this.panelAddConnection = new System.Windows.Forms.Panel();
            this.ucDbTab1 = new awp.ucDbTab();
            this.panelAddConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkPort
            // 
            this.checkPort.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.checkPort.ForeColor = System.Drawing.Color.Black;
            this.checkPort.Location = new System.Drawing.Point(398, 108);
            this.checkPort.Name = "checkPort";
            this.checkPort.Size = new System.Drawing.Size(108, 38);
            this.checkPort.TabIndex = 7;
            this.checkPort.Text = "use port \r\nnon-standart\r\n";
            this.checkPort.UseVisualStyleBackColor = true;
            this.checkPort.CheckedChanged += new System.EventHandler(this.checkPort_CheckedChanged);
            // 
            // comboDBMS
            // 
            this.comboDBMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDBMS.FormattingEnabled = true;
            this.comboDBMS.Items.AddRange(new object[] {"MySQL", "MS SQL Server"});
            this.comboDBMS.Location = new System.Drawing.Point(256, 86);
            this.comboDBMS.Name = "comboDBMS";
            this.comboDBMS.Size = new System.Drawing.Size(136, 24);
            this.comboDBMS.TabIndex = 5;
            this.comboDBMS.SelectionChangeCommitted += new System.EventHandler(this.comboDBMS_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(188, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "DBMS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(187, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(187, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(187, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(188, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonConnect.Enabled = false;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Black;
            this.buttonConnect.Location = new System.Drawing.Point(256, 227);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(136, 28);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(256, 200);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 22);
            this.textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(256, 172);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "root";
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(256, 143);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 22);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "root";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(354, 115);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "3306";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(256, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "localhost";
            // 
            // buttonAddConnection
            // 
            this.buttonAddConnection.FlatAppearance.BorderSize = 0;
            this.buttonAddConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddConnection.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAddConnection.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonAddConnection.IconColor = System.Drawing.Color.Pink;
            this.buttonAddConnection.IconSize = 27;
            this.buttonAddConnection.Location = new System.Drawing.Point(10, 6);
            this.buttonAddConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddConnection.Name = "buttonAddConnection";
            this.buttonAddConnection.Rotation = 0D;
            this.buttonAddConnection.Size = new System.Drawing.Size(40, 37);
            this.buttonAddConnection.TabIndex = 1;
            this.buttonAddConnection.UseVisualStyleBackColor = true;
            this.buttonAddConnection.Click += new System.EventHandler(this.buttonAddConnection_Click);
            // 
            // btnTabDb
            // 
            this.btnTabDb.FlatAppearance.BorderSize = 0;
            this.btnTabDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabDb.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTabDb.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.btnTabDb.ForeColor = System.Drawing.Color.White;
            this.btnTabDb.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnTabDb.IconColor = System.Drawing.Color.Yellow;
            this.btnTabDb.IconSize = 20;
            this.btnTabDb.Location = new System.Drawing.Point(10, 6);
            this.btnTabDb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTabDb.Name = "btnTabDb";
            this.btnTabDb.Rotation = 0D;
            this.btnTabDb.Size = new System.Drawing.Size(120, 37);
            this.btnTabDb.TabIndex = 0;
            this.btnTabDb.Text = "Connect";
            this.btnTabDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTabDb.UseVisualStyleBackColor = true;
            this.btnTabDb.Visible = false;
            // 
            // panelAddConnection
            // 
            this.panelAddConnection.BackColor = System.Drawing.Color.White;
            this.panelAddConnection.Controls.Add(this.textBox1);
            this.panelAddConnection.Controls.Add(this.textBox2);
            this.panelAddConnection.Controls.Add(this.textBox3);
            this.panelAddConnection.Controls.Add(this.textBox4);
            this.panelAddConnection.Controls.Add(this.textBox5);
            this.panelAddConnection.Controls.Add(this.label1);
            this.panelAddConnection.Controls.Add(this.label2);
            this.panelAddConnection.Controls.Add(this.label3);
            this.panelAddConnection.Controls.Add(this.label4);
            this.panelAddConnection.Controls.Add(this.label5);
            this.panelAddConnection.Controls.Add(this.comboDBMS);
            this.panelAddConnection.Controls.Add(this.checkPort);
            this.panelAddConnection.Controls.Add(this.buttonConnect);
            this.panelAddConnection.Location = new System.Drawing.Point(7, 43);
            this.panelAddConnection.Name = "panelAddConnection";
            this.panelAddConnection.Size = new System.Drawing.Size(606, 365);
            this.panelAddConnection.TabIndex = 2;
            // 
            // ucDbTab1
            // 
            this.ucDbTab1.BackColor = System.Drawing.Color.White;
            this.ucDbTab1.Location = new System.Drawing.Point(7, 43);
            this.ucDbTab1.Margin = new System.Windows.Forms.Padding(4);
            this.ucDbTab1.Name = "ucDbTab1";
            this.ucDbTab1.Size = new System.Drawing.Size(606, 365);
            this.ucDbTab1.TabIndex = 8;
            // 
            // ucDB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (47)))), ((int) (((byte) (69)))), ((int) (((byte) (80)))));
            this.Controls.Add(this.panelAddConnection);
            this.Controls.Add(this.ucDbTab1);
            this.Controls.Add(this.buttonAddConnection);
            this.Controls.Add(this.btnTabDb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucDB";
            this.Size = new System.Drawing.Size(620, 415);
            this.panelAddConnection.ResumeLayout(false);
            this.panelAddConnection.PerformLayout();
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton btnTabDb;
        private FontAwesome.Sharp.IconButton buttonAddConnection;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.CheckBox checkPort;
        private System.Windows.Forms.ComboBox comboDBMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelAddConnection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private awp.ucDbTab ucDbTab1;

        #endregion
    }
}