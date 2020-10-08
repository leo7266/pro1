using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Course
    {
        private int CourseID;
        private string CourseName;

        public Course(int courseID, string courseName)
        {
            CourseID = courseID;
            CourseName = courseName;
        }

        public Course()
        {

        }

        public int CourseID1 { get => CourseID; set => CourseID = value; }
        public string CourseName1 { get => CourseName; set => CourseName = value; }
    }
}
