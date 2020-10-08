namespace StudentManage
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ManagementMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stuListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.collegeManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addCollegeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.collegeListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addClassMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.classListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCourseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.courseListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.queryCourseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGradeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addGradeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gradeListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.queryGradeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSystemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editPwdMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lab1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManagementMenu,
            this.collegeManageMenu,
            this.manageCourseMenu,
            this.manageGradeMenu,
            this.manageSystemMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ManagementMenu
            // 
            this.ManagementMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenu,
            this.editMenu,
            this.stuListMenu});
            this.ManagementMenu.Name = "ManagementMenu";
            this.ManagementMenu.Size = new System.Drawing.Size(83, 24);
            this.ManagementMenu.Text = "学生管理";
            // 
            // addMenu
            // 
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(224, 26);
            this.addMenu.Text = "添加学生";
            this.addMenu.Click += new System.EventHandler(this.addMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(224, 26);
            this.editMenu.Text = "编辑学生";
            // 
            // stuListMenu
            // 
            this.stuListMenu.Name = "stuListMenu";
            this.stuListMenu.Size = new System.Drawing.Size(224, 26);
            this.stuListMenu.Text = "学生列表";
            // 
            // collegeManageMenu
            // 
            this.collegeManageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCollegeMenu,
            this.collegeListMenu,
            this.toolStripSeparator1,
            this.addClassMenu,
            this.classListMenu});
            this.collegeManageMenu.Name = "collegeManageMenu";
            this.collegeManageMenu.Size = new System.Drawing.Size(83, 24);
            this.collegeManageMenu.Text = "院系管理";
            // 
            // addCollegeMenu
            // 
            this.addCollegeMenu.Name = "addCollegeMenu";
            this.addCollegeMenu.Size = new System.Drawing.Size(224, 26);
            this.addCollegeMenu.Text = "添加院系";
            this.addCollegeMenu.Click += new System.EventHandler(this.addCollegeMenu_Click);
            // 
            // collegeListMenu
            // 
            this.collegeListMenu.Name = "collegeListMenu";
            this.collegeListMenu.Size = new System.Drawing.Size(224, 26);
            this.collegeListMenu.Text = "院系列表";
            this.collegeListMenu.Click += new System.EventHandler(this.collegeListMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // addClassMenu
            // 
            this.addClassMenu.Name = "addClassMenu";
            this.addClassMenu.Size = new System.Drawing.Size(224, 26);
            this.addClassMenu.Text = "添加班级";
            this.addClassMenu.Click += new System.EventHandler(this.addClassMenu_Click);
            // 
            // classListMenu
            // 
            this.classListMenu.Name = "classListMenu";
            this.classListMenu.Size = new System.Drawing.Size(224, 26);
            this.classListMenu.Text = "班级列表";
            this.classListMenu.Click += new System.EventHandler(this.classListMenu_Click);
            // 
            // manageCourseMenu
            // 
            this.manageCourseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseMenu,
            this.courseListMenu,
            this.queryCourseMenu});
            this.manageCourseMenu.Name = "manageCourseMenu";
            this.manageCourseMenu.Size = new System.Drawing.Size(83, 24);
            this.manageCourseMenu.Text = "课程管理";
            // 
            // addCourseMenu
            // 
            this.addCourseMenu.Name = "addCourseMenu";
            this.addCourseMenu.Size = new System.Drawing.Size(152, 26);
            this.addCourseMenu.Text = "添加课程";
            // 
            // courseListMenu
            // 
            this.courseListMenu.Name = "courseListMenu";
            this.courseListMenu.Size = new System.Drawing.Size(152, 26);
            this.courseListMenu.Text = "课程列表";
            // 
            // queryCourseMenu
            // 
            this.queryCourseMenu.Name = "queryCourseMenu";
            this.queryCourseMenu.Size = new System.Drawing.Size(152, 26);
            this.queryCourseMenu.Text = "查询课程";
            // 
            // manageGradeMenu
            // 
            this.manageGradeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGradeMenu,
            this.gradeListMenu,
            this.queryGradeMenu});
            this.manageGradeMenu.Name = "manageGradeMenu";
            this.manageGradeMenu.Size = new System.Drawing.Size(83, 24);
            this.manageGradeMenu.Text = "成绩管理";
            // 
            // addGradeMenu
            // 
            this.addGradeMenu.Name = "addGradeMenu";
            this.addGradeMenu.Size = new System.Drawing.Size(152, 26);
            this.addGradeMenu.Text = "添加成绩";
            // 
            // gradeListMenu
            // 
            this.gradeListMenu.Name = "gradeListMenu";
            this.gradeListMenu.Size = new System.Drawing.Size(152, 26);
            this.gradeListMenu.Text = "成绩列表";
            // 
            // queryGradeMenu
            // 
            this.queryGradeMenu.Name = "queryGradeMenu";
            this.queryGradeMenu.Size = new System.Drawing.Size(152, 26);
            this.queryGradeMenu.Text = "成绩查询";
            // 
            // manageSystemMenu
            // 
            this.manageSystemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPwdMenu,
            this.toolStripSeparator2,
            this.CopyMenu,
            this.resumeMenu,
            this.toolStripSeparator3,
            this.ExitMenu});
            this.manageSystemMenu.Name = "manageSystemMenu";
            this.manageSystemMenu.Size = new System.Drawing.Size(83, 24);
            this.manageSystemMenu.Text = "系统管理";
            // 
            // editPwdMenu
            // 
            this.editPwdMenu.Name = "editPwdMenu";
            this.editPwdMenu.Size = new System.Drawing.Size(152, 26);
            this.editPwdMenu.Text = "修改密码";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // CopyMenu
            // 
            this.CopyMenu.Name = "CopyMenu";
            this.CopyMenu.Size = new System.Drawing.Size(152, 26);
            this.CopyMenu.Text = "数据备份";
            // 
            // resumeMenu
            // 
            this.resumeMenu.Name = "resumeMenu";
            this.resumeMenu.Size = new System.Drawing.Size(152, 26);
            this.resumeMenu.Text = "数据恢复";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(152, 26);
            this.ExitMenu.Text = "退出系统";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenu});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 24);
            this.helpMenu.Text = "帮助";
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(122, 26);
            this.aboutMenu.Text = "关于";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lab1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 699);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1006, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lab1
            // 
            this.lab1.Margin = new System.Windows.Forms.Padding(0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(167, 22);
            this.lab1.Text = "toolStripStatusLabel1";
            this.lab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生成绩管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManagementMenu;
        private System.Windows.Forms.ToolStripMenuItem collegeManageMenu;
        private System.Windows.Forms.ToolStripMenuItem manageCourseMenu;
        private System.Windows.Forms.ToolStripMenuItem manageGradeMenu;
        private System.Windows.Forms.ToolStripMenuItem manageSystemMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem addMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem stuListMenu;
        private System.Windows.Forms.ToolStripMenuItem addCollegeMenu;
        private System.Windows.Forms.ToolStripMenuItem collegeListMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addClassMenu;
        private System.Windows.Forms.ToolStripMenuItem classListMenu;
        private System.Windows.Forms.ToolStripMenuItem addCourseMenu;
        private System.Windows.Forms.ToolStripMenuItem courseListMenu;
        private System.Windows.Forms.ToolStripMenuItem queryCourseMenu;
        private System.Windows.Forms.ToolStripMenuItem addGradeMenu;
        private System.Windows.Forms.ToolStripMenuItem gradeListMenu;
        private System.Windows.Forms.ToolStripMenuItem queryGradeMenu;
        private System.Windows.Forms.ToolStripMenuItem editPwdMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CopyMenu;
        private System.Windows.Forms.ToolStripMenuItem resumeMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripStatusLabel lab1;
    }
}