namespace StudentManage
{
    partial class frmEdit
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
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbCollege = new System.Windows.Forms.ComboBox();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdoBoy = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab8 = new System.Windows.Forms.Label();
            this.txtQsid = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Location = new System.Drawing.Point(98, 511);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 30);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 511);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 30);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 432);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.cmbClass);
            this.tabPage1.Controls.Add(this.cmbCollege);
            this.tabPage1.Controls.Add(this.dt1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtSid);
            this.tabPage1.Controls.Add(this.lab7);
            this.tabPage1.Controls.Add(this.lab1);
            this.tabPage1.Controls.Add(this.lab6);
            this.tabPage1.Controls.Add(this.lab2);
            this.tabPage1.Controls.Add(this.lab5);
            this.tabPage1.Controls.Add(this.lab3);
            this.tabPage1.Controls.Add(this.lab4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "编辑学生信息";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(111, 165);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(200, 23);
            this.cmbClass.TabIndex = 4;
            // 
            // cmbCollege
            // 
            this.cmbCollege.FormattingEnabled = true;
            this.cmbCollege.Location = new System.Drawing.Point(111, 136);
            this.cmbCollege.Name = "cmbCollege";
            this.cmbCollege.Size = new System.Drawing.Size(200, 23);
            this.cmbCollege.TabIndex = 4;
            // 
            // dt1
            // 
            this.dt1.Location = new System.Drawing.Point(111, 104);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(200, 25);
            this.dt1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo2);
            this.panel1.Controls.Add(this.rdoBoy);
            this.panel1.Location = new System.Drawing.Point(111, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 28);
            this.panel1.TabIndex = 2;
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(53, 3);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(43, 19);
            this.rdo2.TabIndex = 0;
            this.rdo2.Text = "女";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // rdoBoy
            // 
            this.rdoBoy.AutoSize = true;
            this.rdoBoy.Checked = true;
            this.rdoBoy.Location = new System.Drawing.Point(4, 4);
            this.rdoBoy.Name = "rdoBoy";
            this.rdoBoy.Size = new System.Drawing.Size(43, 19);
            this.rdoBoy.TabIndex = 0;
            this.rdoBoy.TabStop = true;
            this.rdoBoy.Text = "男";
            this.rdoBoy.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(111, 194);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(400, 25);
            this.txtAddress.TabIndex = 1;
            // 
            // txtSid
            // 
            this.txtSid.Enabled = false;
            this.txtSid.Location = new System.Drawing.Point(111, 14);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(150, 25);
            this.txtSid.TabIndex = 1;
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab7.Location = new System.Drawing.Point(20, 200);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(85, 19);
            this.lab7.TabIndex = 0;
            this.lab7.Text = "家庭地址";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab1.Location = new System.Drawing.Point(20, 20);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(47, 19);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "学号";
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab6.Location = new System.Drawing.Point(20, 170);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(47, 19);
            this.lab6.TabIndex = 0;
            this.lab6.Text = "班级";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab2.Location = new System.Drawing.Point(20, 50);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(47, 19);
            this.lab2.TabIndex = 0;
            this.lab2.Text = "姓名";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab5.Location = new System.Drawing.Point(20, 140);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(47, 19);
            this.lab5.TabIndex = 0;
            this.lab5.Text = "学院";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab3.Location = new System.Drawing.Point(20, 80);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(47, 19);
            this.lab3.TabIndex = 0;
            this.lab3.Text = "性别";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab4.Location = new System.Drawing.Point(20, 110);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(85, 19);
            this.lab4.TabIndex = 0;
            this.lab4.Text = "出生日期";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lab8);
            this.panel2.Controls.Add(this.txtQsid);
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 55);
            this.panel2.TabIndex = 7;
            // 
            // lab8
            // 
            this.lab8.AutoSize = true;
            this.lab8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab8.Location = new System.Drawing.Point(20, 15);
            this.lab8.Name = "lab8";
            this.lab8.Size = new System.Drawing.Size(47, 19);
            this.lab8.TabIndex = 0;
            this.lab8.Text = "学号";
            // 
            // txtQsid
            // 
            this.txtQsid.Location = new System.Drawing.Point(111, 14);
            this.txtQsid.Name = "txtQsid";
            this.txtQsid.Size = new System.Drawing.Size(200, 25);
            this.txtQsid.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(317, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 30);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(184, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // editstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tabControl1);
            this.Name = "editstu";
            this.Text = "编辑学生信息";
            this.Load += new System.EventHandler(this.editstu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbCollege;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdoBoy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab8;
        private System.Windows.Forms.TextBox txtQsid;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClose;
    }
}