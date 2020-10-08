using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        private int StudentID;
        private string StudentName;
        private string Gender;
        private DateTime Birthday;
        private int CollegeID;
        private int ClassID;
        private String Address;

        public Student(int studentID, string studentName, string gender, DateTime birthday, int collegeID, int classID, string address)
        {
            StudentID = studentID;
            StudentName = studentName;
            Gender = gender;
            Birthday = birthday;
            CollegeID = collegeID;
            ClassID = classID;
            Address = address;
        }

        public Student()
        {

        }

        public int StudentID1 { get => StudentID; set => StudentID = value; }
        public string StudentName1 { get => StudentName; set => StudentName = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public DateTime Birthday1 { get => Birthday; set => Birthday = value; }
        public int CollegeID1 { get => CollegeID; set => CollegeID = value; }
        public int ClassID1 { get => ClassID; set => ClassID = value; }
        public string Address1 { get => Address; set => Address = value; }
    }
}
