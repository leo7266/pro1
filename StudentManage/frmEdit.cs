using SQLDAL;
using StudentManageDAL;
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
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void editstu_Load(object sender, EventArgs e)
        {
            GetCollege();
            GetClass();
        }

        private void GetCollege()
        {
            DataTable dt = Helper.GetCollege();
            DataRow dr = dt.NewRow();
            if (dt.Rows.Count == 0)
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


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要修改吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result==DialogResult.Yes)
            {
                Model.Student stu = new Model.Student();
                if (string.IsNullOrEmpty(txtSid.Text.Trim()))
                {
                    
                    return;
                }
                stu.StudentID1 = Convert.ToInt32(txtSid.Text.Trim());
                stu.StudentName1 = txtName.Text.Trim();
                stu.Gender1 = rdoBoy.Checked ? "男" : "女";
                stu.Birthday1 = Convert.ToDateTime(dt1.Value);
                stu.CollegeID1 =Convert.ToInt32(cmbCollege.SelectedValue);
                stu.ClassID1 = Convert.ToInt32(cmbClass.SelectedValue);
                stu.Address1 = txtAddress.Text.Trim();
                StudentManageBLL.Student2 bllstu = new StudentManageBLL.Student2();
                if(stu.StudentID1> 0 & bllstu.UpdateStudent(stu) > 0 )
                {
                    MessageBox.Show("修改学生信息成功!", "提示");

                }
                else
                {
                    MessageBox.Show("修改学生信息失败!", "提示");
                }

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                StudentManageBLL.Student2 bllstu = new StudentManageBLL.Student2();
                if (bllstu.DeleteStudent(txtSid.Text.Trim()) > 0)
                {
                    MessageBox.Show("删除学生信息成功!", "提示");
                    ReFreshForm();
                }
                else
                {
                    MessageBox.Show("删除学生信息失败!", "提示");
                }
            }
        }

        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            StudentManageBLL.Student2 bllStu = new StudentManageBLL.Student2();
            Model.Student stu=bllStu.GetStudentByID(txtQsid.Text.Trim());
            if(stu.StudentName1!=null)
            {
                txtSid.Text = stu.StudentID1.ToString();
                txtName.Text = stu.StudentName1.ToString();
                
                if(stu.Gender1.ToString()=="男")
                {
                    rdoBoy.Checked = true;
                }
                else
                {
                    rdo2.Checked = true;
                }
                dt1.Value = stu.Birthday1;
                cmbCollege.SelectedValue= stu.CollegeID1.ToString();
                cmbClass.SelectedValue = stu.ClassID1.ToString();
                txtAddress.Text = stu.Address1.ToString();
            }
            else
            {
                MessageBox.Show("没有该学生信息", "提示");
            }           
        }

        //关闭窗口
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //刷新页面
        private void ReFreshForm()
        {
            txtQsid.Text = "";
            txtSid.Text = "";
            txtName.Text = "";
            rdoBoy.Checked = true;
            dt1.Value = DateTime.Now;
            cmbCollege.SelectedIndex = 0;
            cmbClass.SelectedIndex = 0;
            txtAddress.Text = "";
        }


    }
}
