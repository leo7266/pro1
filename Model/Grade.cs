using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Grade
    {
        private int SID;
        private int CID;
        private string Result;
        private string Term;

        public Grade(int sID, int cID, string result, string term)
        {
            SID = sID;
            CID = cID;
            Result = result;
            Term = term;
        }

        public Grade() { }

        public int SID1 { get => SID; set => SID = value; }
        public int CID1 { get => CID; set => CID = value; }
        public string Result1 { get => Result; set => Result = value; }
        public string Term1 { get => Term; set => Term = value; }
    }
}
