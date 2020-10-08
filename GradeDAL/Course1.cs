using SQLDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageDAL
{
    public class Course1
    {
        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="college"></param>
        /// <returns></returns>
        public int AddCourse(Model.Course course)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into tb_Course (CourseID,CourseName)");
            sql.Append("values(@courseID,@courseName)");

            SqlParameter[] parameters =
            {
                new SqlParameter("@courseID",course.CourseID1),
                new SqlParameter("@courseName",course.CourseName1)
            };
            return SQLHelper.ExecuteNonQuery(sql.ToString(), System.Data.CommandType.Text, parameters);
        }

        //更改课程信息
        public int UpdateCourse(Model.Course course)
        {
            string sql = string.Format("update tb_Course set CourseName=@courseName where CourseID=@courseID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@courseName",course.CourseName1),
                new SqlParameter("@courseID",course.CourseID1)
            };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 删除课程
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteCourse(string id)
        {
            string sql = string.Format("delete from tb_Course where CourseID=@courseID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@courseID",id)
            };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 获取课程列表
        /// </summary>
        /// <returns></returns>
        public List<Model.Course> CourseList()
        {
            List<Model.Course> courseList = new List<Model.Course>();
            string sql = string.Format("select CourseID,CourseName from tb_Course");
            using (SqlDataReader dr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, null))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Model.Course course = new Model.Course();
                        course.CourseID1 = Convert.ToInt32(dr["CourseID"]);
                        course.CourseName1 = dr["CourseName"].ToString();
                        courseList.Add(course);

                    }
                }
            }
            return (courseList.Count > 0 ? courseList : null);
        }

        public Model.Course GetCourse(string con)
        {
            Model.Course course = new Model.Course();
            StringBuilder sql = new StringBuilder();
            sql.Append("select CourseID,CourseName from tb_Course where 1=1");
            if (string.IsNullOrEmpty(con))
            {
                sql.Append("And" + con);
            }
            using (SqlDataReader dr = SQLHelper.ExecuteReader(sql.ToString(), System.Data.CommandType.Text, null))
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    course.CourseID1 = Convert.ToInt32(dr["CourseID"]);
                    course.CourseName1 = dr["CourseName"].ToString();
                }
            }
            return course;
        }
    }
}
