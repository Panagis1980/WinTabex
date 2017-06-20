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

        private DataSet ds;
        private DataSet node_ds;
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

        private void btn_Path_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyDocuments;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            OdbcConnect conn = new OdbcConnect();
            conn.setConnString("Dsn=" + txt_odbc_dsn.Text + ";uid=" + txt_uid.Text + ";pwd=" + txt_pwd.Text);

            if (conn.Connect())
            {
                toolStripStatusLabel2.Text = conn.getVersion();

                String appTypeQuery = "select distinct obj_type from dbo.pansys_statrans";
                DataSet ds = new DataSet();
                conn.GetDataset(ds, appTypeQuery);
                conn.Close();
                ddl_Type.DataSource = ds.Tables[0];
                ddl_Type.ValueMember = "obj_type";
                ddl_Type.DisplayMember = "obj_type";
                ddl_Type.SelectedIndex = 0;
            }
            else
            {
                toolStripStatusLabel2.Text = conn.getError();
                conn.Close();
            }
        }

        private void ddl_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdbcConnect conn = new OdbcConnect();
            conn.setConnString("Dsn=" + txt_odbc_dsn.Text + ";uid=" + txt_uid.Text + ";pwd=" + txt_pwd.Text);

            if (conn.Connect() && ddl_Type.SelectedIndex != 0)
            {
                //MessageBox.Show(ddl_objType.SelectedIndex.ToString());
                String nodeQuery = "select distinct g_status from dbo.pansys_statrans where obj_type='" + ddl_Type.SelectedValue.ToString() + "'";
                //MessageBox.Show(appTypeQuery);
                node_ds = new DataSet();

                if (conn.GetDataset(node_ds, nodeQuery))
                {
                    conn.Close();
                    ddl_Node.DataSource = node_ds.Tables[0];
                    ddl_Node.ValueMember = "g_status";
                    ddl_Node.DisplayMember = "g_status";
                    ddl_Node.SelectedIndex = 0;
                }
                else
                {
                    this.toolStripStatusLabel2.Text = conn.getError();
                    conn.Close();
                }

                checkBox_all.Enabled = true;
            }
            else
            {
                conn.Close();
            }
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            OdbcConnect conn = new OdbcConnect();
            conn.setConnString("Dsn=" + txt_odbc_dsn.Text + ";uid=" + txt_uid.Text + ";pwd=" + txt_pwd.Text);

            if (conn.Connect() && ddl_Type.SelectedIndex > 0)
            {
                //MessageBox.Show(ddl_objType.SelectedIndex.ToString());
                String transitionsQuery = "select * from dbo.pansys_statrans where obj_type='" +
                    ddl_Type.SelectedValue.ToString() +
                    "' and g_status='" + ddl_Node.SelectedValue.ToString() + "'";
                //MessageBox.Show(transitionsQuery);
                this.ds = new DataSet();
                
                if (conn.GetDataset(ds, transitionsQuery))
                {
                    conn.Close();
                    this.toolStripStatusLabel2.Text = "Dataset populated succesfully.";
                    txt_trancount.Text = ds.Tables[0].Select("obj_type is not null").Length.ToString();
                    var distinctStatus = ds.Tables[0].AsEnumerable().Select(row => new
                    {
                        status = row.Field<string>("d_status")
                    }).Distinct();
                    Int32 cnt = 0;
                    foreach (var s in distinctStatus)
                    {
                        cnt += 1;
                    }
                    txt_statcount.Text = cnt.ToString();
                    txt_header.Text = "<fragment d1p1:version=\"0.0\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:ns0=\"urn:IAPPLY_EFGSE_BOM\" xmlns:d1p1=\"urn:relational.visualexpressions.metadata\"><RuleDiagram SymbolId = \"" + Guid.NewGuid().ToString("N") + "\"><Variables/><Statements><Condition SymbolId=\"" +Guid.NewGuid().ToString("N") + "\">";
                    txt_footer.Text = "\t</Condition>\n  </Statements>\n</RuleDiagram>\n</fragment>";
                }
                else
                {
                    this.toolStripStatusLabel2.Text = conn.getError();
                    conn.Close();
                }
            }
            else
            {
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exportrules_Click(object sender, EventArgs e)
        {
            if (checkBox_all.Checked == false) {
                try
                {
                    String fname = txt_Path.Text + "\\" + ddl_Type.SelectedValue.ToString() + "-" + ddl_Node.SelectedValue.ToString() + ".xml";
                    //MessageBox.Show(fname);
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(fname);
                    XML_bodycreate xml = new XML_bodycreate();
                    try
                    {
                        SaveFile.WriteLine(txt_header.Text);
                        foreach (String s in xml.XML_create(this.ds))
                        {
                            SaveFile.WriteLine(s);
                        }

                        SaveFile.WriteLine(txt_footer.Text);

                        toolStripStatusLabel2.Text = "File written succesfully!!!!";
                        SaveFile.Close();
                        //btn_exportrules.Enabled = false;
                    }
                    catch (Exception exc)
                    {
                        toolStripStatusLabel2.Text = exc.Message;
                        SaveFile.Close();
                        //btn_exportrules.Enabled = false;
                    }
                }
                catch (Exception exc)
                {
                    toolStripStatusLabel2.Text = exc.Message;
                }
            }
            else
            {
                String node = "";
                foreach (DataRow node_row in node_ds.Tables[0].Rows)
                {
                    node = node_row.Field<String>("g_status");
                    //MessageBox.Show(node);
                    OdbcConnect conn = new OdbcConnect();
                    conn.setConnString("Dsn=" + txt_odbc_dsn.Text + ";uid=" + txt_uid.Text + ";pwd=" + txt_pwd.Text);

                    if (conn.Connect())
                    {
                        String transitionsQuery = "select * from dbo.pansys_statrans where obj_type='" +
                            ddl_Type.SelectedValue.ToString() +
                            "' and g_status='" + node + "'";                        
                        this.ds = new DataSet();

                        if (conn.GetDataset(ds, transitionsQuery))
                        {
                            conn.Close();
                            String header = "<fragment d1p1:version=\"0.0\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:ns0=\"urn:IAPPLY_EFGSE_BOM\" xmlns:d1p1=\"urn:relational.visualexpressions.metadata\"><RuleDiagram SymbolId = \"" + Guid.NewGuid().ToString("N") + "\"><Variables/><Statements><Condition SymbolId=\"" + Guid.NewGuid().ToString("N") + "\">";
                            String footer = "\t</Condition>\n  </Statements>\n</RuleDiagram>\n</fragment>";
                            // File write
                            String fname = txt_Path.Text + "\\" + ddl_Type.SelectedValue.ToString() + "-" + node + ".xml";
                            //MessageBox.Show(fname);
                            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(fname);
                            XML_bodycreate xml = new XML_bodycreate();
                            try
                            {
                                SaveFile.WriteLine(header);
                                foreach (String s in xml.XML_create(this.ds))
                                {
                                    SaveFile.WriteLine(s);
                                }

                                SaveFile.WriteLine(footer);

                                toolStripStatusLabel2.Text = "File written succesfully!!!!";
                                SaveFile.Close();
                                //btn_exportrules.Enabled = false;
                            }
                            catch (Exception exc)
                            {
                                toolStripStatusLabel2.Text = exc.Message;
                                SaveFile.Close();
                                //btn_exportrules.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        conn.Close();
                    }

                }
            }


        }

        private void ddl_Node_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox_all_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_all.Checked == true)
            {
                btn_fetch.Enabled = false;
                ddl_Node.Enabled = false;
            }
            else
            {
                btn_fetch.Enabled = true;
                ddl_Node.Enabled = true;
            }

        }
    }
}
