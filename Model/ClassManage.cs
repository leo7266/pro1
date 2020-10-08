using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClassManage
    {
        private int ClassID;
        private string ClassName;
        private int CollegeID;

        public ClassManage(int classID, string className, int collegeID)
        {
            ClassID = classID;
            ClassName = className;
            CollegeID = collegeID;
        }

        public ClassManage() { }

        public int ClassID1 { get => ClassID; set => ClassID = value; }
        public string ClassName1 { get => ClassName; set => ClassName = value; }
        public int CollegeID1 { get => CollegeID; set => CollegeID = value; }
    }
}
