using SQLDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageDAL
{
    public class College1
    {
        /// <summary>
        /// 添加院系
        /// </summary>
        /// <param name="college"></param>
        /// <returns></returns>
        public int AddCollege(Model.College college)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into tb_College (CollegeID,CollegeName)");
            sql.Append("values(@collegeID,@collegeName)");

            SqlParameter[] parameters =
            {
                new SqlParameter("@collegeID",college.CollegeID1),
                new SqlParameter("@collegeName",college.CollegeName1)
            };
            return SQLHelper.ExecuteNonQuery(sql.ToString(), System.Data.CommandType.Text, parameters);
        }

        //更改院系信息
        public int UpdateCollege(Model.College college)
        {
            string sql = string.Format("update tb_College set CollegeName=@collegeName where CollegeID=@collegeID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@collegeName",college.CollegeName1),
                new SqlParameter("@collegeID",college.CollegeID1)
            };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 删除院系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCollege(string id)
        {
            string sql = string.Format("delete from tb_College where CollegeID=@collegeID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@collegeID",id)
            };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 获取院系列表
        /// </summary>
        /// <returns></returns>
        public List<Model.College> CollegeList()
        {
            List<Model.College> collegeList = new List<Model.College>();
            string sql = string.Format("select CollegeID,CollegeName from tb_College");
            using(SqlDataReader dr=SQLHelper.ExecuteReader(sql,System.Data.CommandType.Text,null))
            {
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Model.College col = new Model.College();
                        col.CollegeID1 = Convert.ToInt32(dr["CollegeID"]);
                        col.CollegeName1 = dr["CollegeName"].ToString();
                        collegeList.Add(col);

                    }
                }
            }
            return (collegeList.Count > 0 ? collegeList : null);
        }

        public Model.College GetCollege(string con)
        {
            Model.College college = new Model.College();
            StringBuilder sql = new StringBuilder();
            sql.Append("select CollegeID,CollegeName from tb_College where 1=1");
            if(string.IsNullOrEmpty(con))
            {
                sql.Append("And" + con);
            }
            using(SqlDataReader dr=SQLHelper.ExecuteReader(sql.ToString(),System.Data.CommandType.Text,null))
            {
                if(dr.HasRows)
                {
                    dr.Read();
                    college.CollegeID1 = Convert.ToInt32(dr["CollegeID"]);
                    college.CollegeName1 = dr["CollegeName"].ToString();
                }
            }
            return college;
        }
    }
}
