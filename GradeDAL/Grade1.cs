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
    public class Grade1
    {
        //添加成绩表
        public bool AddGrade(List<Model.Grade> list)
        {
            List<string> sqlList = new List<string>();

            SqlParameter[] parameters=new SqlParameter[] { };
            foreach (var grade in list)
            {
                string sql = string.Format("insert into tb_Grade (SID,CID,Result,Term) values(@sid, @cid, @result, @term)");
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@sid", grade.SID1),
                    new SqlParameter("@cid", grade.CID1),
                    new SqlParameter("@result", grade.Result1),
                    new SqlParameter("@term", grade.Term1)
                };
                sqlList.Add(sql);
            }
            return SQLHelper.ExecuteTransaction(sqlList,System.Data.CommandType.Text, parameters);
        }

        //修改成绩表
        public bool UpdateGrade(List<Model.Grade> list)
        {
            List<string> sqlList = new List<string>();

            SqlParameter[] parameters = new SqlParameter[] { };
            foreach (var grade in list)
            {
                string sql = string.Format("update tb_Grade set Result=@result where SID=@sid and CID=@cid and Term=@term");
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@sid", grade.SID1),
                    new SqlParameter("@cid", grade.CID1),
                    new SqlParameter("@result", grade.Result1),
                    new SqlParameter("@term", grade.Term1)
                };
                sqlList.Add(sql);
            }
            return SQLHelper.ExecuteTransaction(sqlList, System.Data.CommandType.Text, parameters);
        }

        //获取成绩表
        public DataTable GetTables(string cid,string term)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select t1.SID,t2.StudentName,t1.Result");
            sql.Append("From tb_Grade t1");
            sql.Append("inner join tb_Student t2 on t1.SID=t2.StudentID");
            sql.Append("where t1.CID = @cid and t1.Term = @term");
            return SQLHelper.ExecuteDataTable(sql.ToString());
        }

        //获取指定学生成绩表
        public DataTable StudentGradeTablesByID(string sid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select t2.CourseName,t1.Result,t1.Term");
            sql.Append("From tb_Grade t1");
            sql.Append("inner join tb_Course t2 on t1.CID=t2.CourseID");
            sql.Append("where t1.SID = @sid");
            return SQLHelper.ExecuteDataTable(sql.ToString());
        }
    }
}
