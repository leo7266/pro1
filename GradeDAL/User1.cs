using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using SQLDAL;

//数据访问层
namespace StudentManageDAL
{
    public class User1
    {
        public bool IsUser(Model.User user)
        {
            bool isUser = false;
            string sql = string.Format("select UserName from tb_User where UserName=@UserName and UserPasswd=@UserPasswd");
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserName",user.UserName1),
                new SqlParameter("@UserPasswd",user.UserPasswd1)
            };

            DataTable dt = SQLHelper.ExecuteDataTable(sql, parameters, CommandType.Text);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["UserName"] != null && dt.Rows[0]["UserName"].ToString() != "")
                {
                    user.UserName1 = dt.Rows[0]["UserName"].ToString();
                    isUser = true;
                }
            }
            return isUser;
        }
    }
}
