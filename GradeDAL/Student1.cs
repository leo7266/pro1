using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using SQLDAL;

namespace StudentManageDAL
{
    public class Student1
    {
        /// <summary>
        /// 根据学号检索学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student GetStudentByID(string id)
        {
            string sql = string.Format("select StudentID,StudentName,Gender,Birthday,CollegeID,ClassID,Address from tb_Student Where StudentID = @studentID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@studentID",id)
            };
            Student student = new Student();
            SqlDataReader dr=SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, parameters);
            if(dr.HasRows)
            {
                dr.Read();
                student.StudentID1 = Convert.ToInt32(dr["StudentID"]);
                student.StudentName1 = dr["StudentName"].ToString().Trim();
                student.Gender1 = dr["Gender"].ToString().Trim();
                student.Birthday1 = Convert.ToDateTime(dr["Birthday"]);
                student.CollegeID1 = Convert.ToInt32(dr["CollegeID"]);
                student.ClassID1 = Convert.ToInt32(dr["ClassID"]);
                student.Address1 = dr["Address"].ToString().Trim();

            }
            return student;
        }

        /// <summary>
        /// 根据班级获取学生人数
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public object CountStudentByClass(string cid)
        {
            string sql = string.Format("select count(*) from tb_Student where ClassID=@classID");
            SqlParameter[] parameters = {
                new SqlParameter("@classID", cid)
            };
            return SQLHelper.ExecuteScalar(sql, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 创建一个学生集合
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public List<Model.Student> StudentList(string cid)
        {
            List<Model.Student> list = new List<Model.Student>();
            string sql = string.Format("select StudentID,StudentName,Gender,Birthday,CollegeID,ClassID,Address from tb_Student where ClassID = @classID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@classID", cid)
            };
            SqlDataReader dr = SQLHelper.ExecuteReader(sql, System.Data.CommandType.Text, parameters);
            if (dr.HasRows)
            {
                while(dr.Read())
                {
                    Model.Student stu = new Model.Student();
                    stu.StudentID1 = Convert.ToInt32(dr["StudentID"]);
                    stu.StudentName1 = dr["StudentName"].ToString();
                    stu.Gender1 = dr["Gender"].ToString();
                    stu.Birthday1 = Convert.ToDateTime(dr["Birthday"]);
                    stu.CollegeID1 = Convert.ToInt32(dr["CollegeID"]);
                    stu.ClassID1 = Convert.ToInt32(dr["ClassID"]);
                    stu.Address1 = dr["Address"].ToString();
                    list.Add(stu);
                }
            }
            return list;
        }

        /// <summary>
        /// 根据学号删除学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteStudent(string id)
        {
            string sql = string.Format("delete from tb_Student where StudentID=@studentID");
            SqlParameter[] parameters =
            {
                new SqlParameter("studentID",id)
            };
            return SQLHelper.ExecuteNonQuery(sql, System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int AddStudent(Model.Student stu)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into tb_Student (StudentName,Gender,Birthday,CollegeID,ClassID,Address) ");
            sql.Append("values(@studentName,@gender,@birthday,@collegeID,@classID,@address)");
            SqlParameter[] parameters =
            {
                new SqlParameter("@studentName",stu.StudentName1),
                new SqlParameter("@gender",stu.Gender1),
                new SqlParameter("@birthday",stu.Birthday1),
                new SqlParameter("@collegeID",stu.CollegeID1),
                new SqlParameter("@classID",stu.ClassID1),
                new SqlParameter("@address",stu.Address1)
            };
            return SQLHelper.ExecuteNonQuery(sql.ToString(), System.Data.CommandType.Text, parameters);
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int UpdateStudent(Model.Student stu)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update tb_Student set ");
            sql.Append("StudentName=@studentName,Gender=@gender,Birthday=@birthday,");
            sql.Append("CollegeID=@collegeID,classID=@classID,Address=@address ");
            sql.Append("where StudentID=@studentID");
            SqlParameter[] parameters =
            {
                new SqlParameter("@studentName",stu.StudentName1),
                new SqlParameter("@gender",stu.Gender1),
                new SqlParameter("@birthday",stu.Birthday1),
                new SqlParameter("@collegeID",stu.CollegeID1),
                new SqlParameter("@classID",stu.ClassID1),
                new SqlParameter("@address",stu.Address1),
                new SqlParameter("@studentID",stu.StudentID1)
            };
            return SQLHelper.ExecuteNonQuery(sql.ToString(), System.Data.CommandType.Text, parameters);
        }
    }
}
