using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;         


namespace WinTabex
{
    public partial class WinTabex : Form
    {
        public WinTabex()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            ownerTextBox.Text = usernameTextBox.Text.ToUpper();
        }

        private void tablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablesListBox.SelectedIndex != -1)
            {
                button2.Enabled = true;
            }
            //toolStripStatusLabel2.Text = "Table selected!!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> resultSet = new List<String>(0);
            button2.Enabled = false;
            OraConnect OraConn = new OraConnect();
            String conn = "Data Source="+sidTextBox.Text+";User Id="+usernameTextBox.Text+";Password="+passwordTextBox.Text+";"; // "User Id=<username>;Password=<password>;Data Source=<datasource>"
            if (dbaCheckBox.Checked)
            {
                conn = conn + "DBA Privilege=SYSDBA";
            }
            OraConn.setConnString(conn);

            if (!OraConn.Connect())
            {
                toolStripStatusLabel2.Text = OraConn.getError();
                resultSet.Clear();
                tablesListBox.DataSource = resultSet;
                tablesListBox.Refresh();
                OraConn.Close();
            }
            else
            {
                toolStripStatusLabel2.Text = "Connected to Oracle " + OraConn.getVersion();
                String sql = "select table_name from all_tables where owner='" + ownerTextBox.Text + "' order by table_name asc";
                if (!OraConn.getOracleResultSet(resultSet, sql))
                {
                    toolStripStatusLabel2.Text = OraConn.getError();
                    resultSet.Clear();
                    tablesListBox.DataSource = resultSet;
                    tablesListBox.Refresh();
                    OraConn.Close();
                }
                else
                {
                    tablesListBox.DataSource = resultSet;
                    tablesListBox.Refresh();
                    OraConn.Close();
                }
                OraConn.Close();
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "SQL Files (*.SQL)|*.sql|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1; 
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileTextBox.Text= saveFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> resultSet = new List<String>(0);
            OraConnect OraTest = new OraConnect();
            String conn = "Data Source=" + sidTextBox.Text + ";User Id=" + usernameTextBox.Text + ";Password=" + passwordTextBox.Text + ";"; // "User Id=<username>;Password=<password>;Data Source=<datasource>"
            if (dbaCheckBox.Checked)
            {
                conn = conn + "DBA Privilege=SYSDBA;";
            }
            OraTest.setConnString(conn);

            if (!OraTest.Connect())
            {
                toolStripStatusLabel2.Text = OraTest.getError();
                resultSet.Clear();
                OraTest.Close();
            }
            else
            {
                toolStripStatusLabel2.Text = "Connected to Oracle " + OraTest.getVersion();
                String sql = "select * from " +ownerTextBox.Text+"."+tablesListBox.SelectedItem.ToString()+" ";
                
                if (whereClauseTextBox.TextLength > 0)
                {
                    sql += whereClauseTextBox.Text;
                }

                String table = ownerTextBox.Text+"."+tablesListBox.SelectedItem.ToString();
                if (!OraTest.createOracleInserts(resultSet, sql, table))
                {
                    toolStripStatusLabel2.Text = OraTest.getError();
                    resultSet.Clear();
                    OraTest.Close();
                    toolStripStatusLabel2.Text = "Failed fetching inserts...";
                }
                else
                {
                    OraTest.Close();
                    try
                    {
                        System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(fileTextBox.Text);
                        try
                        {
                            foreach (var item in resultSet)
                            {
                                SaveFile.WriteLine(item.ToString());
                            }
                            toolStripStatusLabel2.Text = "File written succesfully!!!!";
                            SaveFile.Close();
                            tablesListBox.SelectedIndex = -1;
                            button2.Enabled = false;
                        }
                        catch (Exception exc)
                        {
                            toolStripStatusLabel2.Text = exc.Message;
                            SaveFile.Close();
                            tablesListBox.SelectedIndex = -1;
                            button2.Enabled = false;
                        }
                    }
                    catch (Exception exc)
                    {
                        toolStripStatusLabel2.Text = exc.Message;
                    }
                }
                OraTest.Close();
            }
        }
    }
}
