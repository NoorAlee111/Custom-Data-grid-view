using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MydataGridView
{
    [Serializable]
    public class MyUser
    {
        private string userName;
        private string userPassword;
        private string userRole;

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserRole { get => userRole; set => userRole = value; }


        public MyUser(string userName, string userPassword, string userRole)
        {
            this.userName = userName;
            this.UserPassword = userPassword;
            this.UserRole = userRole;
        }
        public MyUser(string userName, string userPassword)
        {
            this.userName = userName;
            this.UserPassword = userPassword;
            this.UserRole = "NA";
        }
        public static bool isAdmin(MyUser user1)
        {
            bool flag = false;
            foreach (MyUser user in MyUserDL.UserList)
            {
                if (user1.userName == user.userName && user1.UserPassword == user.UserPassword)
                {
                    if (user.UserRole == "ADMIN" || user.UserRole == "Admin")
                    {
                        flag = true;
                        return flag;
                    }
                }
            }

            return flag;
        }
    }
}
