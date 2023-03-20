namespace chapter1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.r_man = new System.Windows.Forms.RadioButton();
            this.r_woman = new System.Windows.Forms.RadioButton();
            this.li_mojar = new System.Windows.Forms.ComboBox();
            this.dp = new System.Windows.Forms.DateTimePicker();
            this.c1 = new System.Windows.Forms.CheckBox();
            this.c2 = new System.Windows.Forms.CheckBox();
            this.c3 = new System.Windows.Forms.CheckBox();
            this.c4 = new System.Windows.Forms.CheckBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "专业";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "出生日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "兴趣";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(249, 59);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(150, 30);
            this.tb_name.TabIndex = 5;
            // 
            // r_man
            // 
            this.r_man.AutoSize = true;
            this.r_man.Checked = true;
            this.r_man.Location = new System.Drawing.Point(249, 132);
            this.r_man.Name = "r_man";
            this.r_man.Size = new System.Drawing.Size(53, 28);
            this.r_man.TabIndex = 6;
            this.r_man.TabStop = true;
            this.r_man.Text = "男";
            this.r_man.UseVisualStyleBackColor = true;
            // 
            // r_woman
            // 
            this.r_woman.AutoSize = true;
            this.r_woman.Location = new System.Drawing.Point(371, 132);
            this.r_woman.Name = "r_woman";
            this.r_woman.Size = new System.Drawing.Size(53, 28);
            this.r_woman.TabIndex = 7;
            this.r_woman.Text = "女";
            this.r_woman.UseVisualStyleBackColor = true;
            // 
            // li_mojar
            // 
            this.li_mojar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.li_mojar.FormattingEnabled = true;
            this.li_mojar.Items.AddRange(new object[] {
            "软件",
            "人工智能",
            "机械"});
            this.li_mojar.Location = new System.Drawing.Point(249, 227);
            this.li_mojar.Name = "li_mojar";
            this.li_mojar.Size = new System.Drawing.Size(182, 32);
            this.li_mojar.TabIndex = 8;
            // 
            // dp
            // 
            this.dp.Location = new System.Drawing.Point(249, 302);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(300, 30);
            this.dp.TabIndex = 9;
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(249, 396);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(72, 28);
            this.c1.TabIndex = 10;
            this.c1.Text = "唱歌";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Location = new System.Drawing.Point(371, 396);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(72, 28);
            this.c2.TabIndex = 11;
            this.c2.Text = "跳舞";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Location = new System.Drawing.Point(479, 396);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(65, 28);
            this.c3.TabIndex = 12;
            this.c3.Text = "rap";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Location = new System.Drawing.Point(588, 396);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(72, 28);
            this.c4.TabIndex = 13;
            this.c4.Text = "篮球";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.Location = new System.Drawing.Point(77, 463);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(945, 194);
            this.listView.TabIndex = 14;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "姓名";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "性别";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "专业";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "出生日期";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "兴趣";
            this.columnHeader5.Width = 250;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(77, 682);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 34);
            this.add.TabIndex = 15;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 754);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.dp);
            this.Controls.Add(this.li_mojar);
            this.Controls.Add(this.r_woman);
            this.Controls.Add(this.r_man);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tb_name;
        private RadioButton r_man;
        private RadioButton r_woman;
        private ComboBox li_mojar;
        private DateTimePicker dp;
        private CheckBox c1;
        private CheckBox c2;
        private CheckBox c3;
        private CheckBox c4;
        private ListView listView;
        private Button add;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}