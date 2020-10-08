using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageBLL
{
    public class ClassManage2
    {
        StudentManageDAL.ClassManage1 c = new StudentManageDAL.ClassManage1();

        public int AddClass(Model.ClassManage cla)
        {
            return c.AddClass(cla);
        }

        public int UpdateClass(Model.ClassManage cla)
        {
            return c.UpdateClass(cla);
        }

        public int DeleteClass(string id)
        {
            return c.DeleteClass(id);
        }

        public List<Model.ClassManage> ClassList(string id)
        {
            return c.ClassList(id);
        }
    }
}
