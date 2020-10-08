using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using StudentManageDAL;

namespace StudentManage
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addstu_Load(object sender, EventArgs e)
        {
            GetCollege();
            GetClass();
        }

        /// <summary>
        /// 获取学院列表
        /// </summary>
        private void GetCollege()
        {
            DataTable dt = Helper.GetCollege();
            DataRow dr = dt.NewRow();
            if (dt.Rows.Count==0)
            {
                dr["CollegeID"] = "0";
                dr["CollegeName"] = "--无数据--";
            }
            else
            {
                dr["CollegeID"] = "0";
                dr["CollegeName"] = "--请选择--";
            }
           
            dt.Rows.InsertAt(dr, 0);
            cmbCollege.DataSource = dt;
            cmbCollege.DisplayMember = "CollegeName";
            cmbCollege.ValueMember = "CollegeID";
            cmbCollege.SelectedIndex = 0;
        }

        /// <summary>
        /// 获取班级列表
        /// </summary>
        private void GetClass()
        {
            DataTable dt = Helper.GetClass();
            DataRow dr = dt.NewRow();
            if (dt.Rows.Count == 0)
            {
                dr["ClassID"] = "0";
                dr["ClassName"] = "--无数据--";
            }
            else
            {
                dr["ClassID"] = "0";
                dr["ClassName"] = "--请选择--";
            }
            dt.Rows.InsertAt(dr, 0);
            cmbClass.DataSource = dt;
            cmbClass.DisplayMember = "ClassName";
            cmbClass.ValueMember = "ClassID";
            cmbClass.SelectedIndex = 0;
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Student student = new Student();
           
            student.StudentName1 = txtName.Text.Trim();
            student.Gender1 = rdoBoy.Checked ? "男" : "女";
            student.Birthday1 = dt1.Value;
            student.CollegeID1 = Convert.ToInt32(cmbCollege.SelectedValue);
            student.ClassID1 = Convert.ToInt32(cmbClass.SelectedValue);
            student.Address1 = txtAddress.Text.Trim();

            StudentManageBLL.Student2 student1 = new StudentManageBLL.Student2();
            if(student1.AddStudent(student)>0)
            {
                MessageBox.Show("添加学生信息成功", "添加学生");
                ResetForm();

            }
            else
            {
                MessageBox.Show("添加学生信息失败，请联系管理员！", "添加学生");
            }
        }

        /// <summary>
        /// 复原添加学生表
        /// </summary>
        public void ResetForm()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            GetCollege();
            GetClass();
            rdoBoy.Checked = true;
            dt1.Value = DateTime.Now;

        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
