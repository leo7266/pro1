using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using StudentManageDAL;

namespace StudentManageBLL
{
    public class User2
    {
        public bool IsUser(Model.User user)
        {
            StudentManageDAL.User1 userList = new StudentManageDAL.User1();
            return userList.IsUser(user);
        }

    }
}
