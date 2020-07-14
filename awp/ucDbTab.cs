using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace awp
{
    internal partial class ucDbTab : UserControl
    {
        private string[] connArray; 
        private string sqlVersion = "select version()";
        private string sqlSize;
        
        public ucDbTab(string DBMS, string [] connArr)
        {
            sqlSize = 
                "SELECT ROUND(SUM(data_length + index_length) / 1024 / 1024, 2) AS \"Size in (MB)\" " +
                $"FROM information_schema.TABLES WHERE table_schema = \"{connArr[4]}\" GROUP BY table_schema";
            InitializeComponent();
            connArray = connArr;
            txtDBMS.Text = DBMS;
            txtDB.Text = connArr[4];
            txtSV.Text = MySQL.myCommand(sqlVersion,connArr);
            txtSize.Text = MySQL.myCommand(sqlSize, connArr);
            txtHost.Text = connArr[0];
            txtUser.Text = connArr[2];
            txtLD.Text = "Not have";
            showStatus();
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            string serv = connArray[0], login = connArray[2], pass = connArray[3], db = connArray[4];
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL files (*.sql)|*.sql";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ofd.FileName = "\"" + ofd.FileName + "\"";
                string command = $"/c mysqladmin.exe -u {login} -h {serv} -p{pass} drop {db} -y";
                Process.Start("CMD.exe",command).WaitForExit();
                command = $"/c mysqladmin.exe -u {login} -h {serv} -p{pass} create {db}";
                Process.Start("CMD.exe",command).WaitForExit();
                MySQL.myRestoreDump(serv, login, pass, db, ofd.FileName);
            }
            buttonRefresh_Click(sender, e);
        }

        private void buttonDump_Click(object sender, EventArgs e)
        {
            string serv = connArray[0], login = connArray[2], pass = connArray[3], db = connArray[4];
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL files (*.sql)|*.sql";
            sfd.FileName = db + "_dump_" + DateTime.Now.ToShortDateString().Replace(".", "_");
            string name = sfd.FileName+".sql";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sfd.FileName = "\"" + sfd.FileName + "\"";
                MySQL.myDump(serv, login, pass, db, sfd.FileName);
                using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\logDump.txt", true))
                {
                    if (new FileInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\logDump.txt").Length  == 0)
                        sw.WriteLine(String.Format("{0,-28} {1,-26} {2,-34} {3,-16} {4,-12} {5}",
                            "\\name\\",
                            "\\distrib\\",
                            "\\system\\",
                            "\\host\\",
                            "\\database\\",
                            "\\time\\"));
                }
                using (StreamWriter sw =
                    new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\logDump.txt",
                        true))
                {
                    sw.WriteLine(String.Format("{0,-28} {1,-26} {2,-34} {3,-16} {4,-12} {5}",
                        name,
                        txtDBMS.Text + " dump 10.13 " + txtSV.Text,
                        Environment.OSVersion,
                        serv,
                        db,
                        DateTime.Now.ToString()));
                }
                txtLD.Text = DateTime.Now.ToString();
            }
            
        }

        private void checkBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTime.Checked)
                groupBoxTime.Enabled = true;
            else
                groupBoxTime.Enabled = false;
        }

        private void buttonRep_Click(object sender, EventArgs e)
        {
            try
            {
                genRep();
                MessageBox.Show("Report created in root folder");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BAT files (*.bat)|*.bat";
            sfd.FileName = txtDB.Text + "_dump";
            string name = sfd.FileName+".bat";
            if (sfd.ShowDialog() == DialogResult.OK)
            {*/
                //sfd.FileName = "\"" + sfd.FileName + "\"";
                string temp = "";
                using (StreamReader sr = new StreamReader(@"log.txt"))
                {
                    temp = sr.ReadToEnd();
                }

                using (StreamWriter sw = new StreamWriter(String.Format(@"{0}_dump.bat", txtDB.Text)))
                {
                    sw.WriteLine(temp);
                }

                MessageBox.Show("Bat файл помещен в каталог программы");
                //}
        }

        void showStatus()
        {
            dgvStatus.DataSource = MySQL.statusMySql(connArray);
            dgvStatus.Height = dgvStatus.Rows.GetRowsHeight(DataGridViewElementStates.Visible) +
                               dgvStatus.ColumnHeadersHeight;
            dgvStatus.Width = dgvStatus.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) +
                              dgvStatus.RowHeadersWidth;
            groupBox4.Height = dgvStatus.Location.Y + dgvStatus.Height + dgvStatus.Location.X;
            groupBox5.Location = new Point(groupBox5.Location.X, groupBox4.Location.Y + groupBox4.Height + 5);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            txtSize.Text = MySQL.myCommand(sqlSize, connArray);
            showStatus();
        }

        void genRep()
        {
            using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Report.txt", true))
            {
                sw.WriteLine(String.Format("DBMS:{0,30}\nServer version:{1,20}\nDatabase:{2,26}\nHost:{3,30}\nUser:{4,30}\nSize in MB:{5, 24}\n\n{6}",
                        txtDBMS.Text,
                        txtSV.Text,
                        txtDB.Text,
                        txtHost.Text,
                        txtUser.Text,
                        txtSize.Text,
                        "Dumps:"));

                using (StreamReader str =
                    new StreamReader(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\logDump.txt",
                        Encoding.Default))
                {
                    while (!str.EndOfStream)
                    {
                        string st = str.ReadLine();
                        if (st.StartsWith(txtDB.Text))
                        {
                            sw.WriteLine(st);
                        }
                    }
                }
                sw.WriteLine("\nReport completed on: " + DateTime.Now.ToShortDateString());
                for (int i = 0; i < 121; i++)
                {
                    sw.Write("-");
                    if(i==120)
                        sw.WriteLine();
                }
            }
        }
    }
}