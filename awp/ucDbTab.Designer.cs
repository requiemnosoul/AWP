using System.ComponentModel;

namespace awp
{
    partial class ucDbTab
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
            this.labelDB = new System.Windows.Forms.Label();
            this.buttonRestore = new FontAwesome.Sharp.IconButton();
            this.labelDBMS = new System.Windows.Forms.Label();
            this.labelSV = new System.Windows.Forms.Label();
            this.labelLD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.txtSV = new System.Windows.Forms.Label();
            this.txtLD = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.Label();
            this.txtDBMS = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonPlan = new FontAwesome.Sharp.IconButton();
            this.buttonDump = new FontAwesome.Sharp.IconButton();
            this.buttonRep = new FontAwesome.Sharp.IconButton();
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvStatus)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDB
            // 
            this.labelDB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelDB.ForeColor = System.Drawing.Color.Black;
            this.labelDB.Location = new System.Drawing.Point(171, 18);
            this.labelDB.Name = "labelDB";
            this.labelDB.Size = new System.Drawing.Size(69, 23);
            this.labelDB.TabIndex = 2;
            this.labelDB.Text = "Database: ";
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestore.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonRestore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonRestore.ForeColor = System.Drawing.Color.Black;
            this.buttonRestore.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.buttonRestore.IconColor = System.Drawing.Color.Black;
            this.buttonRestore.IconSize = 30;
            this.buttonRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestore.Location = new System.Drawing.Point(168, 21);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Rotation = 0D;
            this.buttonRestore.Size = new System.Drawing.Size(157, 40);
            this.buttonRestore.TabIndex = 3;
            this.buttonRestore.Text = "Restore backup";
            this.buttonRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // labelDBMS
            // 
            this.labelDBMS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelDBMS.ForeColor = System.Drawing.Color.Black;
            this.labelDBMS.Location = new System.Drawing.Point(6, 18);
            this.labelDBMS.Name = "labelDBMS";
            this.labelDBMS.Size = new System.Drawing.Size(50, 23);
            this.labelDBMS.TabIndex = 2;
            this.labelDBMS.Text = "DBMS:";
            // 
            // labelSV
            // 
            this.labelSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelSV.ForeColor = System.Drawing.Color.Black;
            this.labelSV.Location = new System.Drawing.Point(6, 64);
            this.labelSV.Name = "labelSV";
            this.labelSV.Size = new System.Drawing.Size(98, 23);
            this.labelSV.TabIndex = 2;
            this.labelSV.Text = "Server version: ";
            // 
            // labelLD
            // 
            this.labelLD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelLD.ForeColor = System.Drawing.Color.Black;
            this.labelLD.Location = new System.Drawing.Point(6, 87);
            this.labelLD.Name = "labelLD";
            this.labelLD.Size = new System.Drawing.Size(77, 23);
            this.labelLD.TabIndex = 2;
            this.labelLD.Text = "Last dump: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.labelHost);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.txtSV);
            this.groupBox1.Controls.Add(this.txtLD);
            this.groupBox1.Controls.Add(this.txtHost);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.txtDBMS);
            this.groupBox1.Controls.Add(this.labelDBMS);
            this.groupBox1.Controls.Add(this.labelDB);
            this.groupBox1.Controls.Add(this.labelSV);
            this.groupBox1.Controls.Add(this.labelLD);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DB info";
            // 
            // labelHost
            // 
            this.labelHost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelHost.ForeColor = System.Drawing.Color.Black;
            this.labelHost.Location = new System.Drawing.Point(6, 41);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(41, 23);
            this.labelHost.TabIndex = 2;
            this.labelHost.Text = "Host: ";
            // 
            // labelUser
            // 
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelUser.ForeColor = System.Drawing.Color.Black;
            this.labelUser.Location = new System.Drawing.Point(171, 41);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(40, 23);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User: ";
            // 
            // txtSV
            // 
            this.txtSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtSV.ForeColor = System.Drawing.Color.Black;
            this.txtSV.Location = new System.Drawing.Point(110, 62);
            this.txtSV.Name = "txtSV";
            this.txtSV.Size = new System.Drawing.Size(55, 23);
            this.txtSV.TabIndex = 2;
            this.txtSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLD
            // 
            this.txtLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtLD.ForeColor = System.Drawing.Color.Black;
            this.txtLD.Location = new System.Drawing.Point(89, 85);
            this.txtLD.Name = "txtLD";
            this.txtLD.Size = new System.Drawing.Size(151, 23);
            this.txtLD.TabIndex = 2;
            this.txtLD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtHost.ForeColor = System.Drawing.Color.Black;
            this.txtHost.Location = new System.Drawing.Point(53, 39);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(112, 23);
            this.txtHost.TabIndex = 2;
            this.txtHost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(217, 39);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(127, 23);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDB
            // 
            this.txtDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDB.ForeColor = System.Drawing.Color.Black;
            this.txtDB.Location = new System.Drawing.Point(244, 16);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(100, 23);
            this.txtDB.TabIndex = 2;
            this.txtDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDBMS
            // 
            this.txtDBMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDBMS.ForeColor = System.Drawing.Color.Black;
            this.txtDBMS.Location = new System.Drawing.Point(62, 16);
            this.txtDBMS.Name = "txtDBMS";
            this.txtDBMS.Size = new System.Drawing.Size(103, 23);
            this.txtDBMS.TabIndex = 2;
            this.txtDBMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBoxTime);
            this.groupBox2.Controls.Add(this.checkBoxTime);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.buttonPlan);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 124);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Planning a backup";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.textBox2);
            this.groupBoxTime.Controls.Add(this.label1);
            this.groupBoxTime.Controls.Add(this.textBox1);
            this.groupBoxTime.Enabled = false;
            this.groupBoxTime.Location = new System.Drawing.Point(327, 10);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(83, 45);
            this.groupBoxTime.TabIndex = 10;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Time";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox2.Location = new System.Drawing.Point(48, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 25);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "59";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = ":";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox1.Location = new System.Drawing.Point(5, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 25);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "23";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.checkBoxTime.Location = new System.Drawing.Point(244, 26);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(81, 24);
            this.checkBoxTime.TabIndex = 6;
            this.checkBoxTime.Text = "Set time:";
            this.checkBoxTime.UseVisualStyleBackColor = true;
            this.checkBoxTime.CheckedChanged += new System.EventHandler(this.checkBoxTime_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Location = new System.Drawing.Point(6, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 65);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regularity";
            // 
            // radioButton4
            // 
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.radioButton4.Location = new System.Drawing.Point(9, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 23);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Just once";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.radioButton3.Location = new System.Drawing.Point(298, 30);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(105, 23);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Every month";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.radioButton1.Location = new System.Drawing.Point(100, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 23);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Every day";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.radioButton2.Location = new System.Drawing.Point(196, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 23);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Every week";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 25);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonPlan
            // 
            this.buttonPlan.BackColor = System.Drawing.Color.White;
            this.buttonPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonPlan.ForeColor = System.Drawing.Color.Black;
            this.buttonPlan.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.buttonPlan.IconColor = System.Drawing.Color.Black;
            this.buttonPlan.IconSize = 30;
            this.buttonPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlan.Location = new System.Drawing.Point(415, 60);
            this.buttonPlan.Name = "buttonPlan";
            this.buttonPlan.Rotation = 0D;
            this.buttonPlan.Size = new System.Drawing.Size(75, 58);
            this.buttonPlan.TabIndex = 3;
            this.buttonPlan.Text = "Plan";
            this.buttonPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPlan.UseVisualStyleBackColor = false;
            this.buttonPlan.Click += new System.EventHandler(this.buttonPlan_Click);
            // 
            // buttonDump
            // 
            this.buttonDump.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDump.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonDump.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonDump.ForeColor = System.Drawing.Color.Black;
            this.buttonDump.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.buttonDump.IconColor = System.Drawing.Color.Black;
            this.buttonDump.IconSize = 30;
            this.buttonDump.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDump.Location = new System.Drawing.Point(6, 21);
            this.buttonDump.Name = "buttonDump";
            this.buttonDump.Rotation = 0D;
            this.buttonDump.Size = new System.Drawing.Size(156, 40);
            this.buttonDump.TabIndex = 3;
            this.buttonDump.Text = "Dump";
            this.buttonDump.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDump.UseVisualStyleBackColor = true;
            this.buttonDump.Click += new System.EventHandler(this.buttonDump_Click);
            // 
            // buttonRep
            // 
            this.buttonRep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRep.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonRep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonRep.ForeColor = System.Drawing.Color.Black;
            this.buttonRep.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.buttonRep.IconColor = System.Drawing.Color.Black;
            this.buttonRep.IconSize = 30;
            this.buttonRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRep.Location = new System.Drawing.Point(331, 21);
            this.buttonRep.Name = "buttonRep";
            this.buttonRep.Rotation = 0D;
            this.buttonRep.Size = new System.Drawing.Size(157, 40);
            this.buttonRep.TabIndex = 3;
            this.buttonRep.Text = "Create report";
            this.buttonRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRep.UseVisualStyleBackColor = true;
            // 
            // dgvStatus
            // 
            this.dgvStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Location = new System.Drawing.Point(6, 21);
            this.dgvStatus.MaximumSize = new System.Drawing.Size(481, 152);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.RowHeadersVisible = false;
            this.dgvStatus.RowTemplate.Height = 24;
            this.dgvStatus.Size = new System.Drawing.Size(481, 152);
            this.dgvStatus.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.dgvStatus);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.groupBox4.Location = new System.Drawing.Point(3, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(494, 179);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database status";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.buttonDump);
            this.groupBox5.Controls.Add(this.buttonRestore);
            this.groupBox5.Controls.Add(this.buttonRep);
            this.groupBox5.Location = new System.Drawing.Point(3, 442);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(494, 71);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Action";
            // 
            // ucDbTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucDbTab";
            this.Size = new System.Drawing.Size(500, 518);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvStatus)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private FontAwesome.Sharp.IconButton buttonDump;
        private FontAwesome.Sharp.IconButton buttonPlan;
        private FontAwesome.Sharp.IconButton buttonRep;
        private FontAwesome.Sharp.IconButton buttonRestore;
        private System.Windows.Forms.CheckBox checkBoxTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDB;
        private System.Windows.Forms.Label labelDBMS;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelLD;
        private System.Windows.Forms.Label labelSV;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtDB;
        private System.Windows.Forms.Label txtDBMS;
        private System.Windows.Forms.Label txtHost;
        private System.Windows.Forms.Label txtLD;
        private System.Windows.Forms.Label txtSV;
        private System.Windows.Forms.Label txtUser;

        #endregion
    }
}