using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// EmployeeLogic class handles all business logic functions to show data in representation layer
    /// </summary>
	public class EmployeeLogic
	{
        /// <summary>
        /// InsertEmployee calls data access layer InsertEmployee function to insert employee data
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="user"></param>
        public static void InsertEmployee(Employee employee, User user)
        {
            EmployeeData.InsertEmployee(employee, user);
        }

        /// <summary>
        /// UpdateEmployee calls data access layer UpdateEmployee function to update employee data
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="user"></param>
        public static void UpdateEmployee(Employee employee, User user)
        {
            EmployeeData.UpdateEmployee(employee, user);
        }

        /// <summary>
        /// SearchActiveEmployees calls data access layer SearchActiveEmployees function to search active employees and return its list
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="categoryId"></param>
        /// <param name="employeeName"></param>
        /// <returns></returns>
        public static ArrayList SearchActiveEmployees(int typeId, int categoryId, string employeeName)
        {
            return EmployeeData.SearchActiveEmployees(typeId, categoryId, employeeName);
        }

        /// <summary>
        /// SearchEmployeesById calls data access layer SearchEmployeesById function to search a particuler employee by his id and return it
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Employee SearchEmployeesById(int id)
        {
            return EmployeeData.SearchEmployeesById(id);
        }

        /// <summary>
        /// SearchEmployees calls data access layer SearchEmployees function to get all employees according to provided details and return the list
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="categoryId"></param>
        /// <param name="employeeName"></param>
        /// <returns></returns>
        public static ArrayList SearchEmployees(int typeId, int categoryId, string employeeName)
        {
            return EmployeeData.SearchEmployees(typeId, categoryId, employeeName);
        }
    }
}
