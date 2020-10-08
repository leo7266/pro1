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
    public partial class frmClassList : Form
    {
        public frmClassList()
        {
            InitializeComponent();
        }

        private static frmClassList frmclassList = null;

        public static frmClassList CreateInstance()
        {
            if(frmclassList == null || frmclassList.IsDisposed)
            {
                frmclassList = new frmClassList();
            }
            return frmclassList;
        }


    }
}
