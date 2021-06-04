using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace BusinessLogic
{
	public class EmployeeLogic
	{
        public static void InsertEmployee(Employee employee, User user)
        {
            EmployeeData.InsertEmployee(employee, user);
        }

        public static void UpdateEmployee(Employee employee, User user)
        {
            EmployeeData.UpdateEmployee(employee, user);
        }

        public static ArrayList SearchActiveEmployees(int typeId, int categoryId, string employeeName)
        {
            return EmployeeData.SearchActiveEmployees(typeId, categoryId, employeeName);
        }

        public static Employee SearchEmployeesById(int id)
        {
            return EmployeeData.SearchEmployeesById(id);
        }

        public static ArrayList SearchEmployees(int typeId, int categoryId, string employeeName)
        {
            return EmployeeData.SearchEmployees(typeId, categoryId, employeeName);
        }
    }
}
