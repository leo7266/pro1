using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLDAL;
using StudentManageDAL;

namespace StudentManage
{
    public partial class addGrade : Form
    {
        public addGrade()
        {
            InitializeComponent();
        }

        private void addGrade_Load(object sender, EventArgs e)
        {
            GetCourse();
            GetClass();
        }

        private void GetCourse()
        {
            DataTable dt=Helper.GetCourse();
            cboCourse.DataSource = dt;
            cboCourse.DisplayMember = "CourseName";
            cboCourse.ValueMember = "CourseID";
        }

        private void GetClass()
        {
            DataTable dt = Helper.GetClass();
            cboClass.DataSource = dt;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassID";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string classID = cboClass.SelectedValue.ToString();

            string sql = string.Format("select StudentID ,StudentName from tb_Student where ClassID=@classID");
            SqlParameter[] parameters = 
            {
                new SqlParameter("@classID",classID)
            };

            DataTable dt=SQLHelper.ExecuteDataTable(sql, parameters, CommandType.Text);
            dgv1.DataSource = dt;

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }
    }
}
