using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace StudentManageBLL
{
    public class Student2
    {
        StudentManageDAL.Student1 student1 = new StudentManageDAL.Student1();

        /// <summary>
        /// 根据学号查询学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.Student GetStudentByID(string id)
        {
            return student1.GetStudentByID(id);
        }

        /// <summary>
        /// 学生列表
        /// </summary>
        /// <param name="cid"></param>
        /// <returns></returns>
        public List<Model.Student> studentList(string cid)
        {
            return student1.StudentList(cid);
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int AddStudent(Model.Student student)
        {
            return student1.AddStudent(student);
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public int UpdateStudent(Model.Student student)
        {
            return student1.UpdateStudent(student);
        }

        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteStudent(string id)
        {
            return student1.DeleteStudent(id);
        }
    }
}
