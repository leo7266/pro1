using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SQLDAL
{
    public class SQLHelper
    {
        //连接字符串
        private static string connString = ConfigurationSettings.AppSettings["connectionstring"];

        /// <summary>
        /// 执行查询，返回结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(string sql,SqlParameter[] parameters,CommandType commandType)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn=new SqlConnection(connString))
            {
                using (SqlCommand cmd=new SqlCommand(sql,conn))
                {
                    cmd.CommandType = commandType;
                    if(parameters!=null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                }
            }
            return ds.Tables[0];
        }

        public static bool ExecuteTransaction(List<string> sqlList,CommandType commandType,SqlParameter[] parameters)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                //开始本地事务
                SqlTransaction sqlTran = conn.BeginTransaction();
                //建立命令对象
                SqlCommand cmd = conn.CreateCommand();
                cmd.Transaction = sqlTran;
                try
                {
                    foreach (string sql in sqlList)
                    {
                        cmd.CommandText = sql;
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        if(cmd.ExecuteNonQuery()>0)
                        {
                            result = true;
                        }
                    }
                    //提交事务
                    sqlTran.Commit();
                }
                catch(Exception ex)
                {
                    
                    try
                    {
                        //事务回滚
                        sqlTran.Rollback();
                    }
                    catch(Exception exRollBack)
                    {

                    }
                }

            }
            return result;
        }

        public static DataTable ExecuteDataTable(string sql)
        {
            return ExecuteDataTable(sql, null, CommandType.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql,CommandType commandType,SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = commandType;
            if (parameters != null)
            {
               foreach (SqlParameter parameter in parameters)
               {
                   cmd.Parameters.Add(parameter);
               }
            }
            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
          
        }

        public static SqlDataReader ExecuteReader(String sql,CommandType commandType)
        {
            return ExecuteReader(sql, commandType, null);
        }

        /// <summary>
        /// 从数据库中检索单个值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql,CommandType commandType,SqlParameter[] parameters)
        {
            object result = null;
            using(SqlConnection conn=new SqlConnection(connString))
            {
                using (SqlCommand cmd=new SqlCommand(sql,conn))
                {
                    cmd.CommandType = commandType;
                    if(parameters!=null)
                    {
                        foreach(SqlParameter parameter in parameters)
                        {
                            cmd.Parameters.Add(parameter);
                        }
                    }
                    conn.Open();
                    result = cmd.ExecuteScalar();
                }
            }
            return result;
        }

        public static object ExecuteScalar(string sql)
        {
            return ExecuteScalar(sql, CommandType.Text, null);
        }

        public static Object ExecuteScalar(string sql,CommandType commandType)
        {
            return ExecuteScalar(sql, commandType, null);
        }

        /// <summary>
        /// 对数据库执行增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql,CommandType commandType,SqlParameter[] parameters)
        {
            int count = 0;
            using (SqlConnection conn=new SqlConnection(connString))
            {
                using (SqlCommand cmd=new SqlCommand(sql,conn))
                {
                    cmd.CommandType = commandType;
                    if(parameters!=null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    conn.Open();
                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }

        public static int ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql, CommandType.Text, null);
        }

        public static int ExecuteNonQuery(string sql,CommandType commandType)
        {
            return ExecuteNonQuery(sql, commandType, null);
        }
    }
}
