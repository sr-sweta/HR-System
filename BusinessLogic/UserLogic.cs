using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace BusinessLogic
{
    public class UserLogic
    {
        public static User ValidateUser(string userName, string password)
        {
            return UserData.ValidateUser(userName, password);
        }
    }
}
