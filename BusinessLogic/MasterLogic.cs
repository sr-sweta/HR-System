using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace BusinessLogic
{
    public class MasterLogic
    {
        public static void SaveEmployeeType(EmployeeType employeeType, User user)
        {
            if(employeeType.Id < 0 && employeeType.IsActive)
            {
                MasterData.InsertEmployeeType(employeeType, user);
            }
            else if( employeeType.IsDirty && employeeType.Id > 0)
            {
                MasterData.UpdateEmployeeType(employeeType, user);
            }
        }

        public static ArrayList GetAllEmployeeType()
        {
            return MasterData.GetAllEmployeeType();
        }
        public static ArrayList GetAllActiveEmployeeType()
        {
            return MasterData.GetAllActiveEmployeeType();
        }
    }
}
