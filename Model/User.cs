using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private int UserID;
        private string UserName;
        private string UserPasswd;

        public User(int userID, string userName, string userPasswd)
        {
            UserID = userID;
            UserName = userName;
            UserPasswd = userPasswd;
        }

        public User()
        {
        }

        public int UserID1 { get => UserID; set => UserID = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
        public string UserPasswd1 { get => UserPasswd; set => UserPasswd = value; }
    }
}
