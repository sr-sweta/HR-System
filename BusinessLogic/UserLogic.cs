using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// Handles all logics related to User data in Representation Layer 
    /// </summary>

    public class UserLogic
    {
        //Receives User data from Data Access Layer after validation is successfull
        public static User ValidateUser(string userName, string password)
        {
            return UserData.ValidateUser(userName, password);
        }

    }
}
