using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class College
    {
        private int CollegeID;
        private string CollegeName;

        public College(int collegeID, string collegeName)
        {
            CollegeID = collegeID;
            CollegeName = collegeName;
        }

        public College()
        {

        }

        public int CollegeID1 { get => CollegeID; set => CollegeID = value; }
        public string CollegeName1 { get => CollegeName; set => CollegeName = value; }
    }
}
