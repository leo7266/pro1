using SQLDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageDAL
{
    public class ClassManage1
    {
        /// <summary>
        /// 添加班级
        /// </summary>
        /// <param name="college"></param>
        /// <returns></returns>
        public int AddClass(Model.ClassManage classManage)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into tb_Class (ClassID,ClassName,CollegeID)");
            sql.Append("values(@classID,@className,@collegeID)");

            SqlParameter[] parameters =
            {
                new SqlParameter("@classID",classManage.ClassID1),
                new SqlParameter("@className",classManage.ClassName1),
                new SqlParameter("@collegeID",classManage.CollegeID1)
            };
            return SQLHelper.ExecuteNonQuery(sql.ToString(), System.Data.CommandType.Text, parameters);
        }

        //更改班级信息
        public int UpdateClass(Model.ClassManage classManage)
        {
            string sql = string.Format("update tb_Class set ClassName=@className,CollegeID=@collegeID where ClassID=@classID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@className",classManage.ClassName1),
                new SqlParameter("@collegeID",classManage.CollegeID1)
            };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 删除班级
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteClass(string id)
        {
            string sql = string.Format("delete from tb_Class where ClassID=@classID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@classID",id)
            };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 获取院系列表
        /// </summary>
        /// <returns></returns>
        public List<Model.ClassManage> ClassList(string id)
        {
            List<Model.ClassManage> classList = new List<Model.ClassManage>();
            string sql = string.Format("select ClassID,ClassName from tb_Class where CollegeID=@collegeID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@collegeID",id)
            };
            using (SqlDataReader dr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, parameters))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Model.ClassManage cla = new Model.ClassManage();
                        cla.ClassID1 = Convert.ToInt32(dr["ClassID"]);
                        cla.ClassName1 = dr["ClassName"].ToString();
                        classList.Add(cla);

                    }
                }
            }
            return (classList.Count > 0 ? classList : null);
        }

        public Model.ClassManage GetClass(string con)
        {
            Model.ClassManage cla = new Model.ClassManage();
            StringBuilder sql = new StringBuilder();
            sql.Append("select ClassID,ClassName,CollegeID from tb_Class where 1=1");
            if (string.IsNullOrEmpty(con))
            {
                sql.Append("And" + con);
            }
            using (SqlDataReader dr = SQLHelper.ExecuteReader(sql.ToString(), System.Data.CommandType.Text, null))
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    cla.ClassID1 = Convert.ToInt32(dr["ClassID"]);
                    cla.ClassName1 = dr["ClassName"].ToString();
                    cla.CollegeID1 = Convert.ToInt32(dr["CollegeID"]);
                }
            }
            return cla;
        }
    }
}
