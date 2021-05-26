using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace BusinessLogic
{
    public class CategoryLogic
    {
        public static void SaveEmployeeCategory(EmployeeCategory employeeCategory, User user)
        {
            if (employeeCategory.Id < 0 && employeeCategory.IsActive)
            {
                CategoryData.InsertEmployeeCategory(employeeCategory, user);
            }
            else if (employeeCategory.IsDirty && employeeCategory.Id > 0)
            {
                CategoryData.UpdateEmployeeCategory(employeeCategory, user);
            }
        }

        public static ArrayList GetAllEmployeeCategory()
        {
            return CategoryData.GetAllEmployeeCategory();
        }
        public static ArrayList GetAllActiveEmployeeCategory()
        {
            return CategoryData.GetAllActiveEmployeeCategory();
        }
    }
}
