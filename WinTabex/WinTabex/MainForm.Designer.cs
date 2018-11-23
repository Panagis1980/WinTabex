namespace WinTabex
{
    partial class WinTabex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinTabex));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wherClauseLabel = new System.Windows.Forms.Label();
            this.whereClauseTextBox = new System.Windows.Forms.TextBox();
            this.tablesListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.dbaCheckBox = new System.Windows.Forms.CheckBox();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sidTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_header = new System.Windows.Forms.TextBox();
            this.txt_trancount = new System.Windows.Forms.TextBox();
            this.lbl_trancount = new System.Windows.Forms.Label();
            this.txt_statcount = new System.Windows.Forms.TextBox();
            this.lbl_statcount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_footer = new System.Windows.Forms.TextBox();
            this.btn_exportrules = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_all = new System.Windows.Forms.CheckBox();
            this.btn_fetch = new System.Windows.Forms.Button();
            this.lbl_node = new System.Windows.Forms.Label();
            this.ddl_Node = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.ddl_Type = new System.Windows.Forms.ComboBox();
            this.btn_Path = new System.Windows.Forms.Button();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.lbl_Path = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_odbc_dsn = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 512);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(934, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(4, 17);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Export";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wherClauseLabel);
            this.groupBox2.Controls.Add(this.whereClauseTextBox);
            this.groupBox2.Controls.Add(this.tablesListBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(212, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 455);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select table";
            // 
            // wherClauseLabel
            // 
            this.wherClauseLabel.AutoSize = true;
            this.wherClauseLabel.Location = new System.Drawing.Point(6, 218);
            this.wherClauseLabel.Name = "wherClauseLabel";
            this.wherClauseLabel.Size = new System.Drawing.Size(86, 13);
            this.wherClauseLabel.TabIndex = 7;
            this.wherClauseLabel.Text = "WHERE Clause:";
            // 
            // whereClauseTextBox
            // 
            this.whereClauseTextBox.Location = new System.Drawing.Point(7, 234);
            this.whereClauseTextBox.Multiline = true;
            this.whereClauseTextBox.Name = "whereClauseTextBox";
            this.whereClauseTextBox.Size = new System.Drawing.Size(693, 56);
            this.whereClauseTextBox.TabIndex = 0;
            // 
            // tablesListBox
            // 
            this.tablesListBox.FormattingEnabled = true;
            this.tablesListBox.Location = new System.Drawing.Point(7, 20);
            this.tablesListBox.Name = "tablesListBox";
            this.tablesListBox.Size = new System.Drawing.Size(693, 186);
            this.tablesListBox.TabIndex = 6;
            this.tablesListBox.SelectedIndexChanged += new System.EventHandler(this.tablesListBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(418, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.dbaCheckBox);
            this.groupBox1.Controls.Add(this.fileTextBox);
            this.groupBox1.Controls.Add(this.fileLabel);
            this.groupBox1.Controls.Add(this.ownerTextBox);
            this.groupBox1.Controls.Add(this.ownerLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sidTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 455);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(169, 237);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(25, 20);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // dbaCheckBox
            // 
            this.dbaCheckBox.AutoSize = true;
            this.dbaCheckBox.Location = new System.Drawing.Point(9, 198);
            this.dbaCheckBox.Name = "dbaCheckBox";
            this.dbaCheckBox.Size = new System.Drawing.Size(90, 17);
            this.dbaCheckBox.TabIndex = 18;
            this.dbaCheckBox.Text = "As SYSDBA?";
            this.dbaCheckBox.UseVisualStyleBackColor = true;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(6, 237);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(157, 20);
            this.fileTextBox.TabIndex = 9;
            this.fileTextBox.Text = "D:\\Desktop\\export.sql";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(4, 220);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(26, 13);
            this.fileLabel.TabIndex = 8;
            this.fileLabel.Text = "File:";
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.AcceptsTab = true;
            this.ownerTextBox.Location = new System.Drawing.Point(6, 172);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(188, 20);
            this.ownerTextBox.TabIndex = 19;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(6, 156);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(38, 13);
            this.ownerLabel.TabIndex = 20;
            this.ownerLabel.Text = "Owner";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.AcceptsTab = true;
            this.usernameTextBox.Location = new System.Drawing.Point(6, 79);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(188, 20);
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "TNS name:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.AcceptsReturn = true;
            this.passwordTextBox.Location = new System.Drawing.Point(6, 125);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(188, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password:";
            // 
            // sidTextBox
            // 
            this.sidTextBox.Location = new System.Drawing.Point(6, 36);
            this.sidTextBox.Name = "sidTextBox";
            this.sidTextBox.Size = new System.Drawing.Size(188, 20);
            this.sidTextBox.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transition Export";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_header);
            this.groupBox3.Controls.Add(this.txt_trancount);
            this.groupBox3.Controls.Add(this.lbl_trancount);
            this.groupBox3.Controls.Add(this.txt_statcount);
            this.groupBox3.Controls.Add(this.lbl_statcount);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_footer);
            this.groupBox3.Controls.Add(this.btn_exportrules);
            this.groupBox3.Location = new System.Drawing.Point(211, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 459);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Rule header and footer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rule header:";
            // 
            // txt_header
            // 
            this.txt_header.Location = new System.Drawing.Point(7, 60);
            this.txt_header.Multiline = true;
            this.txt_header.Name = "txt_header";
            this.txt_header.Size = new System.Drawing.Size(696, 173);
            this.txt_header.TabIndex = 12;
            // 
            // txt_trancount
            // 
            this.txt_trancount.Location = new System.Drawing.Point(297, 16);
            this.txt_trancount.Name = "txt_trancount";
            this.txt_trancount.Size = new System.Drawing.Size(45, 20);
            this.txt_trancount.TabIndex = 11;
            this.txt_trancount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl_trancount
            // 
            this.lbl_trancount.AutoSize = true;
            this.lbl_trancount.Location = new System.Drawing.Point(206, 20);
            this.lbl_trancount.Name = "lbl_trancount";
            this.lbl_trancount.Size = new System.Drawing.Size(88, 13);
            this.lbl_trancount.TabIndex = 10;
            this.lbl_trancount.Text = "Total Transitions:";
            this.lbl_trancount.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_statcount
            // 
            this.txt_statcount.Location = new System.Drawing.Point(133, 16);
            this.txt_statcount.Name = "txt_statcount";
            this.txt_statcount.Size = new System.Drawing.Size(45, 20);
            this.txt_statcount.TabIndex = 9;
            // 
            // lbl_statcount
            // 
            this.lbl_statcount.AutoSize = true;
            this.lbl_statcount.Location = new System.Drawing.Point(9, 20);
            this.lbl_statcount.Name = "lbl_statcount";
            this.lbl_statcount.Size = new System.Drawing.Size(122, 13);
            this.lbl_statcount.TabIndex = 8;
            this.lbl_statcount.Text = "Total Statuses for Node:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rule footer:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_footer
            // 
            this.txt_footer.Location = new System.Drawing.Point(7, 257);
            this.txt_footer.Multiline = true;
            this.txt_footer.Name = "txt_footer";
            this.txt_footer.Size = new System.Drawing.Size(700, 156);
            this.txt_footer.TabIndex = 0;
            // 
            // btn_exportrules
            // 
            this.btn_exportrules.Location = new System.Drawing.Point(604, 419);
            this.btn_exportrules.Name = "btn_exportrules";
            this.btn_exportrules.Size = new System.Drawing.Size(99, 34);
            this.btn_exportrules.TabIndex = 6;
            this.btn_exportrules.Text = "Export";
            this.btn_exportrules.UseVisualStyleBackColor = true;
            this.btn_exportrules.Click += new System.EventHandler(this.btn_exportrules_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_all);
            this.groupBox4.Controls.Add(this.btn_fetch);
            this.groupBox4.Controls.Add(this.lbl_node);
            this.groupBox4.Controls.Add(this.ddl_Node);
            this.groupBox4.Controls.Add(this.lbl_type);
            this.groupBox4.Controls.Add(this.ddl_Type);
            this.groupBox4.Controls.Add(this.btn_Path);
            this.groupBox4.Controls.Add(this.txt_Path);
            this.groupBox4.Controls.Add(this.lbl_Path);
            this.groupBox4.Controls.Add(this.btn_Connect);
            this.groupBox4.Controls.Add(this.txt_uid);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txt_pwd);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt_odbc_dsn);
            this.groupBox4.Location = new System.Drawing.Point(5, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 459);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection";
            // 
            // checkBox_all
            // 
            this.checkBox_all.AutoSize = true;
            this.checkBox_all.Enabled = false;
            this.checkBox_all.Location = new System.Drawing.Point(6, 291);
            this.checkBox_all.Name = "checkBox_all";
            this.checkBox_all.Size = new System.Drawing.Size(104, 17);
            this.checkBox_all.TabIndex = 21;
            this.checkBox_all.Text = "Export All Nodes";
            this.checkBox_all.UseVisualStyleBackColor = true;
            this.checkBox_all.CheckedChanged += new System.EventHandler(this.checkBox_all_CheckedChanged);
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(6, 378);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(188, 35);
            this.btn_fetch.TabIndex = 20;
            this.btn_fetch.Text = "Fetch";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // lbl_node
            // 
            this.lbl_node.AutoSize = true;
            this.lbl_node.Location = new System.Drawing.Point(5, 239);
            this.lbl_node.Name = "lbl_node";
            this.lbl_node.Size = new System.Drawing.Size(70, 13);
            this.lbl_node.TabIndex = 19;
            this.lbl_node.Text = "Source Node";
            // 
            // ddl_Node
            // 
            this.ddl_Node.FormattingEnabled = true;
            this.ddl_Node.Location = new System.Drawing.Point(5, 255);
            this.ddl_Node.Name = "ddl_Node";
            this.ddl_Node.Size = new System.Drawing.Size(187, 21);
            this.ddl_Node.TabIndex = 18;
            this.ddl_Node.SelectedIndexChanged += new System.EventHandler(this.ddl_Node_SelectedIndexChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(5, 196);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(86, 13);
            this.lbl_type.TabIndex = 17;
            this.lbl_type.Text = "Application Type";
            // 
            // ddl_Type
            // 
            this.ddl_Type.FormattingEnabled = true;
            this.ddl_Type.Location = new System.Drawing.Point(5, 212);
            this.ddl_Type.Name = "ddl_Type";
            this.ddl_Type.Size = new System.Drawing.Size(187, 21);
            this.ddl_Type.TabIndex = 16;
            this.ddl_Type.SelectedIndexChanged += new System.EventHandler(this.ddl_Type_SelectedIndexChanged);
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(169, 170);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(25, 20);
            this.btn_Path.TabIndex = 10;
            this.btn_Path.Text = "...";
            this.btn_Path.UseVisualStyleBackColor = true;
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(6, 170);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(157, 20);
            this.txt_Path.TabIndex = 9;
            this.txt_Path.Text = "D:\\Desktop";
            // 
            // lbl_Path
            // 
            this.lbl_Path.AutoSize = true;
            this.lbl_Path.Location = new System.Drawing.Point(4, 153);
            this.lbl_Path.Name = "lbl_Path";
            this.lbl_Path.Size = new System.Drawing.Size(32, 13);
            this.lbl_Path.TabIndex = 8;
            this.lbl_Path.Text = "Path:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(6, 419);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(187, 34);
            this.btn_Connect.TabIndex = 6;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_uid
            // 
            this.txt_uid.AcceptsTab = true;
            this.txt_uid.Location = new System.Drawing.Point(6, 79);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Size = new System.Drawing.Size(188, 20);
            this.txt_uid.TabIndex = 4;
            this.txt_uid.Text = "sa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "ODBC DSN name:";
            // 
            // txt_pwd
            // 
            this.txt_pwd.AcceptsReturn = true;
            this.txt_pwd.Location = new System.Drawing.Point(6, 125);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(188, 20);
            this.txt_pwd.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Password:";
            // 
            // txt_odbc_dsn
            // 
            this.txt_odbc_dsn.Location = new System.Drawing.Point(6, 36);
            this.txt_odbc_dsn.Name = "txt_odbc_dsn";
            this.txt_odbc_dsn.Size = new System.Drawing.Size(188, 20);
            this.txt_odbc_dsn.TabIndex = 3;
            this.txt_odbc_dsn.Text = "IAPPLY";
            // 
            // WinTabex
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(934, 534);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinTabex";
            this.Text = "WinTabex";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label wherClauseLabel;
        private System.Windows.Forms.TextBox whereClauseTextBox;
        private System.Windows.Forms.ListBox tablesListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckBox dbaCheckBox;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sidTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_footer;
        private System.Windows.Forms.Button btn_exportrules;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.Label lbl_Path;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_odbc_dsn;
        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.Label lbl_node;
        private System.Windows.Forms.ComboBox ddl_Node;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox ddl_Type;
        private System.Windows.Forms.TextBox txt_trancount;
        private System.Windows.Forms.Label lbl_trancount;
        private System.Windows.Forms.TextBox txt_statcount;
        private System.Windows.Forms.Label lbl_statcount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_header;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox checkBox_all;
    }
}

