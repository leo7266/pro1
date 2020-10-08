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
using StudentManageBLL;

namespace StudentManage
{
    public partial class DengLu : Form
    {
        public DengLu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.txtName.Text.Trim();
            string pwd = this.txtPwd.Text.Trim();

            if(string.IsNullOrEmpty(userName) ||string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("用户名或密码不能为空!","登录提示");
                this.txtName.Focus();
            }
            else
            {
                Model.User user = new Model.User();
                user.UserName1 = userName;
                user.UserPasswd1 = pwd;
                StudentManageBLL.User2 user1 = new StudentManageBLL.User2();
                if(user1.IsUser(user))
                {
                    this.Hide();
                    frmMain ZhuChuangKou = new frmMain();
                    ZhuChuangKou.ShowDialog();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "登录提示");
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DengLu_Load(object sender, EventArgs e)
        {

        }
    }
}
