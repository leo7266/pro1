using SQLDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageDAL
{
    public class Helper
    {
        //绑定课程下拉框
        public static DataTable GetCourse()
        {
            string sql = "select CourseID,CourseName from tb_Course";

            return SQLHelper.ExecuteDataTable(sql);

        }


        public static DataTable GetClass()
        {
            string sql = "select ClassID,ClassName from tb_Class";

            return SQLHelper.ExecuteDataTable(sql);   
        }


        public static DataTable GetClassByCollegeID(int collegeID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select t1.ClassID,t1.ClassName ");
            sql.Append("from tb_Class t1 ");
            sql.Append("where t1.CollegeID = @collegeID");

            SqlParameter[] parameters =
            {
                new SqlParameter("@collegeID",collegeID)
            };
            return SQLHelper.ExecuteDataTable(sql.ToString(),parameters,CommandType.Text);
        }


        public static DataTable GetCollege()
        {
            string sql = "select CollegeID,CollegeName from tb_College";
            return SQLHelper.ExecuteDataTable(sql);
        }
    }
}
