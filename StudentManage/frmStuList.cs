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
    public partial class frmStuList : Form
    {
        public frmStuList()
        {
            InitializeComponent();
        }

        private void ChaXunXueSheng_Load(object sender, EventArgs e)
        {
            //设置表格行对齐方式
            dgv1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            LoadTreeView();
            tv1.ExpandAll();
        }

        /// <summary>
        /// 建立树形导航栏
        /// </summary>
        private void LoadTreeView()
        {
            TreeNode root = new TreeNode("根目录");
            root.Tag = null;
            tv1.Nodes.Add(root);

            //生成院系列表
            StudentManageBLL.College2 college2 = new StudentManageBLL.College2();
            List<Model.College> collegeList = college2.GetCollegeList();
            //遍历院系列表
            foreach(var col in collegeList)
            {
                //生成院系节点
                TreeNode collegeNodes = root.Nodes.Add(col.CollegeName1);
                collegeNodes.Tag = col.CollegeID1;

               
                StudentManageBLL.ClassManage2 cla2 = new StudentManageBLL.ClassManage2();
                List<Model.ClassManage> classList = cla2.ClassList(col.CollegeID1.ToString());
                if(classList!=null)
                {
                    foreach (var cla in classList)
                    {
                        //生成班级节点
                        TreeNode classNode = collegeNodes.Nodes.Add(cla.ClassName1);
                        classNode.Tag = cla.ClassID1;
                    }
                }
            }
        }

        private void tv1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取选择节点信息
            TreeNode nodes = e.Node.Parent as TreeNode;
            string name = e.Node.Text.ToString();
            string id = e.Node.Tag.ToString();
            //判断选择节点类型
            if(name.Equals("根目录")||nodes.Text.Equals("根目录"))
            {
                MessageBox.Show("请选择一个班级", "提示");
            }
            else
            {
                StudentManageBLL.Student2 stu2 = new StudentManageBLL.Student2();
                dgv1.DataSource = stu2.studentList(id);
            }
        }
    }
}
