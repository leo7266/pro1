using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageBLL
{
    public class College2
    {
        StudentManageDAL.College1 college1 = new StudentManageDAL.College1();

        public int AddCollege(Model.College college)
        {
            return college1.AddCollege(college);
        }

        public int UpdateCollege(Model.College college)
        {
            return college1.UpdateCollege(college);
        }

        public int DeleteCollege(string id)
        {
            return college1.DeleteCollege(id);
        }

        public List<Model.College> GetCollegeList()
        {
            return college1.CollegeList();
        }


    }
}
