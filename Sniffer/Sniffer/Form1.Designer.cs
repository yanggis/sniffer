﻿namespace Sniffer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tab_multi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.filter_rule = new System.Windows.Forms.DataGridView();
            this.filter_rule_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter_rule_oper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter_rule_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filter_oper = new System.Windows.Forms.ComboBox();
            this.filter_btn_apply = new System.Windows.Forms.Button();
            this.filter_btn_clear = new System.Windows.Forms.Button();
            this.filter_value = new System.Windows.Forms.TextBox();
            this.filter_key = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.restruct_save = new System.Windows.Forms.Button();
            this.restruct_display = new System.Windows.Forms.TextBox();
            this.restruct_get = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restruct_btn_get = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.display_text = new System.Windows.Forms.TextBox();
            this.display_title = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.search_display = new System.Windows.Forms.RichTextBox();
            this.search_ignoreUpper = new System.Windows.Forms.CheckBox();
            this.search_keyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_multi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filter_rule)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restruct_get)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始抓包";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "停止抓包";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(626, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "读取Pacp";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(626, 291);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "退出";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(626, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "保存Pcap";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择网卡";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(42, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 214);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView_row_click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "时间";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "源地址";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "目的地址";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "协议";
            this.Column4.Name = "Column4";
            this.Column4.Width = 74;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "信息";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "index";
            this.Column6.Name = "Column6";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(42, 300);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(578, 153);
            this.treeView1.TabIndex = 4;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // tab_multi
            // 
            this.tab_multi.Controls.Add(this.tabPage1);
            this.tab_multi.Controls.Add(this.tabPage3);
            this.tab_multi.Controls.Add(this.tabPage2);
            this.tab_multi.Controls.Add(this.tabPage4);
            this.tab_multi.Location = new System.Drawing.Point(717, 12);
            this.tab_multi.Name = "tab_multi";
            this.tab_multi.SelectedIndex = 0;
            this.tab_multi.Size = new System.Drawing.Size(380, 442);
            this.tab_multi.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filter_rule);
            this.tabPage1.Controls.Add(this.filter_oper);
            this.tabPage1.Controls.Add(this.filter_btn_apply);
            this.tabPage1.Controls.Add(this.filter_btn_clear);
            this.tabPage1.Controls.Add(this.filter_value);
            this.tabPage1.Controls.Add(this.filter_key);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(372, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "过滤规则";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // filter_rule
            // 
            this.filter_rule.AllowUserToAddRows = false;
            this.filter_rule.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filter_rule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filter_rule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filter_rule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filter_rule_key,
            this.filter_rule_oper,
            this.filter_rule_value});
            this.filter_rule.Location = new System.Drawing.Point(6, 65);
            this.filter_rule.Name = "filter_rule";
            this.filter_rule.RowHeadersVisible = false;
            this.filter_rule.RowTemplate.Height = 23;
            this.filter_rule.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.filter_rule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filter_rule.Size = new System.Drawing.Size(293, 277);
            this.filter_rule.TabIndex = 9;
            // 
            // filter_rule_key
            // 
            this.filter_rule_key.HeaderText = "键";
            this.filter_rule_key.Name = "filter_rule_key";
            // 
            // filter_rule_oper
            // 
            this.filter_rule_oper.HeaderText = "操作符";
            this.filter_rule_oper.Name = "filter_rule_oper";
            this.filter_rule_oper.Width = 80;
            // 
            // filter_rule_value
            // 
            this.filter_rule_value.HeaderText = "值";
            this.filter_rule_value.Name = "filter_rule_value";
            // 
            // filter_oper
            // 
            this.filter_oper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_oper.FormattingEnabled = true;
            this.filter_oper.Items.AddRange(new object[] {
            "==",
            "!=",
            "包含"});
            this.filter_oper.Location = new System.Drawing.Point(125, 10);
            this.filter_oper.Name = "filter_oper";
            this.filter_oper.Size = new System.Drawing.Size(68, 20);
            this.filter_oper.TabIndex = 8;
            this.filter_oper.SelectedIndexChanged += new System.EventHandler(this.filter_oper_SelectedIndexChanged);
            // 
            // filter_btn_apply
            // 
            this.filter_btn_apply.Location = new System.Drawing.Point(6, 36);
            this.filter_btn_apply.Name = "filter_btn_apply";
            this.filter_btn_apply.Size = new System.Drawing.Size(75, 23);
            this.filter_btn_apply.TabIndex = 6;
            this.filter_btn_apply.Text = "apply";
            this.filter_btn_apply.UseVisualStyleBackColor = true;
            this.filter_btn_apply.Click += new System.EventHandler(this.filter_btn_apply_Click);
            // 
            // filter_btn_clear
            // 
            this.filter_btn_clear.Location = new System.Drawing.Point(87, 36);
            this.filter_btn_clear.Name = "filter_btn_clear";
            this.filter_btn_clear.Size = new System.Drawing.Size(75, 23);
            this.filter_btn_clear.TabIndex = 5;
            this.filter_btn_clear.Text = "clear";
            this.filter_btn_clear.UseVisualStyleBackColor = true;
            this.filter_btn_clear.Click += new System.EventHandler(this.filter_btn_clear_Click);
            // 
            // filter_value
            // 
            this.filter_value.Location = new System.Drawing.Point(199, 10);
            this.filter_value.Name = "filter_value";
            this.filter_value.Size = new System.Drawing.Size(100, 21);
            this.filter_value.TabIndex = 4;
            this.filter_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filter_value_KeyPress);
            // 
            // filter_key
            // 
            this.filter_key.DisplayMember = "ip";
            this.filter_key.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_key.FormattingEnabled = true;
            this.filter_key.Items.AddRange(new object[] {
            "ip_addr",
            "ip_version",
            "port",
            "protocol",
            "info_start",
            "validate_checksum"});
            this.filter_key.Location = new System.Drawing.Point(6, 10);
            this.filter_key.Name = "filter_key";
            this.filter_key.Size = new System.Drawing.Size(112, 20);
            this.filter_key.TabIndex = 2;
            this.filter_key.SelectedIndexChanged += new System.EventHandler(this.filter_key_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.restruct_save);
            this.tabPage3.Controls.Add(this.restruct_display);
            this.tabPage3.Controls.Add(this.restruct_get);
            this.tabPage3.Controls.Add(this.restruct_btn_get);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(372, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "数据报重组";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // restruct_save
            // 
            this.restruct_save.Location = new System.Drawing.Point(280, 386);
            this.restruct_save.Name = "restruct_save";
            this.restruct_save.Size = new System.Drawing.Size(75, 23);
            this.restruct_save.TabIndex = 5;
            this.restruct_save.Text = "保存文件";
            this.restruct_save.UseVisualStyleBackColor = true;
            this.restruct_save.Click += new System.EventHandler(this.restruct_save_Click);
            // 
            // restruct_display
            // 
            this.restruct_display.Location = new System.Drawing.Point(6, 257);
            this.restruct_display.Multiline = true;
            this.restruct_display.Name = "restruct_display";
            this.restruct_display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.restruct_display.Size = new System.Drawing.Size(350, 122);
            this.restruct_display.TabIndex = 4;
            // 
            // restruct_get
            // 
            this.restruct_get.BackgroundColor = System.Drawing.SystemColors.Control;
            this.restruct_get.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restruct_get.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.dport,
            this.message});
            this.restruct_get.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.restruct_get.EnableHeadersVisualStyles = false;
            this.restruct_get.Location = new System.Drawing.Point(6, 39);
            this.restruct_get.Name = "restruct_get";
            this.restruct_get.RowHeadersVisible = false;
            this.restruct_get.RowTemplate.Height = 23;
            this.restruct_get.Size = new System.Drawing.Size(350, 208);
            this.restruct_get.TabIndex = 3;
            this.restruct_get.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.restruct_get_CellContentClick);
            // 
            // index
            // 
            this.index.HeaderText = "index";
            this.index.Name = "index";
            this.index.Width = 50;
            // 
            // dport
            // 
            this.dport.HeaderText = "sport";
            this.dport.Name = "dport";
            this.dport.Width = 50;
            // 
            // message
            // 
            this.message.HeaderText = "message";
            this.message.Name = "message";
            this.message.Width = 190;
            // 
            // restruct_btn_get
            // 
            this.restruct_btn_get.Location = new System.Drawing.Point(256, 3);
            this.restruct_btn_get.Name = "restruct_btn_get";
            this.restruct_btn_get.Size = new System.Drawing.Size(100, 23);
            this.restruct_btn_get.TabIndex = 2;
            this.restruct_btn_get.Text = "过滤文件包";
            this.restruct_btn_get.UseVisualStyleBackColor = true;
            this.restruct_btn_get.Click += new System.EventHandler(this.restruct_btn_get_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.display_text);
            this.tabPage2.Controls.Add(this.display_title);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(372, 416);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "应用层数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // display_text
            // 
            this.display_text.Location = new System.Drawing.Point(6, 33);
            this.display_text.Multiline = true;
            this.display_text.Name = "display_text";
            this.display_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.display_text.Size = new System.Drawing.Size(352, 368);
            this.display_text.TabIndex = 1;
            // 
            // display_title
            // 
            this.display_title.AutoSize = true;
            this.display_title.Location = new System.Drawing.Point(4, 10);
            this.display_title.Name = "display_title";
            this.display_title.Size = new System.Drawing.Size(0, 12);
            this.display_title.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.search_display);
            this.tabPage4.Controls.Add(this.search_ignoreUpper);
            this.tabPage4.Controls.Add(this.search_keyword);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(372, 416);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "全局搜索";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // search_display
            // 
            this.search_display.Location = new System.Drawing.Point(6, 68);
            this.search_display.Name = "search_display";
            this.search_display.Size = new System.Drawing.Size(353, 336);
            this.search_display.TabIndex = 3;
            this.search_display.Text = "";
            // 
            // search_ignoreUpper
            // 
            this.search_ignoreUpper.AutoSize = true;
            this.search_ignoreUpper.Location = new System.Drawing.Point(257, 33);
            this.search_ignoreUpper.Name = "search_ignoreUpper";
            this.search_ignoreUpper.Size = new System.Drawing.Size(84, 16);
            this.search_ignoreUpper.TabIndex = 2;
            this.search_ignoreUpper.Text = "忽略大小写";
            this.search_ignoreUpper.UseVisualStyleBackColor = true;
            this.search_ignoreUpper.CheckedChanged += new System.EventHandler(this.search_ignoreUpper_CheckedChanged);
            // 
            // search_keyword
            // 
            this.search_keyword.Location = new System.Drawing.Point(6, 33);
            this.search_keyword.Name = "search_keyword";
            this.search_keyword.Size = new System.Drawing.Size(244, 21);
            this.search_keyword.TabIndex = 1;
            this.search_keyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_keyword_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入要搜索的关键字，回车开始搜索";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 475);
            this.Controls.Add(this.tab_multi);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Sniffer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.check_closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_multi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filter_rule)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restruct_get)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tab_multi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button filter_btn_apply;
        private System.Windows.Forms.Button filter_btn_clear;
        private System.Windows.Forms.TextBox filter_value;
        private System.Windows.Forms.ComboBox filter_key;
        private System.Windows.Forms.ComboBox filter_oper;
        private System.Windows.Forms.DataGridView filter_rule;
        private System.Windows.Forms.DataGridViewTextBoxColumn filter_rule_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn filter_rule_oper;
        private System.Windows.Forms.DataGridViewTextBoxColumn filter_rule_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button restruct_btn_get;
        private System.Windows.Forms.DataGridView restruct_get;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn dport;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.TextBox restruct_display;
        private System.Windows.Forms.Button restruct_save;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox display_text;
        private System.Windows.Forms.Label display_title;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox search_display;
        private System.Windows.Forms.CheckBox search_ignoreUpper;
        private System.Windows.Forms.TextBox search_keyword;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

