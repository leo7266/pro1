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
    public partial class frmCollegeList : Form
    {
        public frmCollegeList()
        {
            InitializeComponent();
        }

        private static frmCollegeList frmcollegeList = null;

        public static frmCollegeList CreateInstance()
        {
            if (frmcollegeList == null || frmcollegeList.IsDisposed)
            {
                frmcollegeList = new frmCollegeList();
            }
            return frmcollegeList;
        }
         
    }
}
