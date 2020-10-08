using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManage
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void addMenu_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd();
            frmAdd.MdiParent = this;
            frmAdd.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab1.Text = "当前时间为：" + DateTime.Now.ToString();
        }

        //窗口关闭
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //添加院系
        private void addCollegeMenu_Click(object sender, EventArgs e)
        {
            frmAddCollege frmAddCollege = new frmAddCollege();
            frmAddCollege.MdiParent = this;
            frmAddCollege.Show();
        }

        //院系列表
        private void collegeListMenu_Click(object sender, EventArgs e)
        {

            frmCollegeList frmCollegeList = new frmCollegeList();
            frmCollegeList.MdiParent = this;
            frmCollegeList.Show();
        }

        private void addClassMenu_Click(object sender, EventArgs e)
        {
            frmAddClass frmAddClass = new frmAddClass();
            frmAddClass.MdiParent = this;
            frmAddClass.Show();
        }

        private void classListMenu_Click(object sender, EventArgs e)
        {
            frmClassList frmClassList =frmClassList.CreateInstance();
            frmClassList.MdiParent = this;
            frmClassList.Show();
        }
    }
}
