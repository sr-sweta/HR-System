using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
	public class EmployeeData
	{
        public static void InsertEmployee(Employee employee, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_InsertEmployee");
            SqlParameter parameter = new SqlParameter("@Id", System.Data.SqlDbType.Int, 16);
            parameter.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(parameter);
            command.Parameters.Add(new SqlParameter("@EmployeeType", employee.EmployeeType.Id));
            command.Parameters.Add(new SqlParameter("@EmployeeCategory", employee.Category.Id));
            command.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
            command.Parameters.Add(new SqlParameter("@MiddleName", employee.MiddleName));
            command.Parameters.Add(new SqlParameter("@LastName", employee.LastName));
            command.Parameters.Add(new SqlParameter("@DOB", employee.DateOfBirth));
            command.Parameters.Add(new SqlParameter("@DateOfJoining", employee.DateOfJoining));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.ExecuteNonQuery();
            employee.Id = Convert.ToInt32(command.Parameters["@Id"].Value.ToString());
            //@EmployeeCategory, @EmployeeType, @CreatedBy
        }

        public static void UpdateEmployee(Employee employee, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_UpdateEmployee");
            command.Parameters.Add(new SqlParameter("@Id", employee.Id));
            command.Parameters.Add(new SqlParameter("@EmployeeType", employee.EmployeeType.Id));
            command.Parameters.Add(new SqlParameter("@EmployeeCategory", employee.Category.Id));
            command.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
            command.Parameters.Add(new SqlParameter("@MiddleName", employee.MiddleName));
            command.Parameters.Add(new SqlParameter("@LastName", employee.LastName));
            command.Parameters.Add(new SqlParameter("@DOB", employee.DateOfBirth));
            command.Parameters.Add(new SqlParameter("@DateOfJoining", employee.DateOfJoining));
            command.Parameters.Add(new SqlParameter("@LastUpdatedBy", user.Id));
            command.Parameters.Add(new SqlParameter("@IsActive", employee.IsActive));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.ExecuteNonQuery();
        }

        public static ArrayList SearchActiveEmployees(int typeId, int categoryId, string employeeName)
        {
            ArrayList list = new ArrayList();
            //SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllActiveEmployeeType").ExecuteReader();
            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_SearchActiveEmployees");
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@TypeId", typeId));
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@CategoryId", categoryId));
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@EmployeeName", employeeName));
            adapter.Fill(records);

            if (records != null && records.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in records.Tables[0].Rows)
                {
                    EmployeeType type = new EmployeeType(Convert.ToInt32(row["EmployeeTypeId"].ToString()), row["EmployeeType"].ToString());
                    EmployeeCategory category = new EmployeeCategory(Convert.ToInt32(row["EmployeeCategoryId"].ToString()), row["EmployeeCategory"].ToString());

                    list.Add(new Employee(Convert.ToInt32(row["Id"].ToString()), row["FirstName"].ToString(), row["MiddleName"].ToString(),
                        row["LastName"].ToString(), category, type, Convert.ToDateTime(row["DateOfJoining"].ToString()), Convert.ToDateTime(row["DOB"].ToString()),
                        row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString(),
                        Convert.ToBoolean(row["IsActive"].ToString())));
                }

            }
            return list;
        }

        public static Employee SearchEmployeesById(int id)
        {
            Employee employee = null;
            //SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllActiveEmployeeType").ExecuteReader();
            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_SearchEmployeesById");
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@Id", id));
            adapter.Fill(records);

            if (records != null && records.Tables[0].Rows.Count == 1)
            {
                DataRow row = records.Tables[0].Rows[0];
                EmployeeType type = new EmployeeType(Convert.ToInt32(row["EmployeeTypeId"].ToString()), row["EmployeeType"].ToString());
                EmployeeCategory category = new EmployeeCategory(Convert.ToInt32(row["EmployeeCategoryId"].ToString()), row["EmployeeCategory"].ToString());

                employee = new Employee(Convert.ToInt32(row["Id"].ToString()), row["FirstName"].ToString(), row["MiddleName"].ToString(),
                    row["LastName"].ToString(), category, type, Convert.ToDateTime(row["DateOfJoining"].ToString()), Convert.ToDateTime(row["DOB"].ToString()),
                    row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString(),
                    Convert.ToBoolean(row["IsActive"].ToString()));
            }
            return employee;
        }

        public static ArrayList SearchEmployees(int typeId, int categoryId, string employeeName)
        {
            ArrayList list = new ArrayList();
            //SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllActiveEmployeeType").ExecuteReader();
            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_SearchEmployees");
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@TypeId", typeId));
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@CategoryId", categoryId));
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@EmployeeName", employeeName));
            adapter.Fill(records);

            if (records != null && records.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in records.Tables[0].Rows)
                {
                    EmployeeType type = new EmployeeType(Convert.ToInt32(row["EmployeeTypeId"].ToString()), row["EmployeeType"].ToString());
                    EmployeeCategory category = new EmployeeCategory(Convert.ToInt32(row["EmployeeCategoryId"].ToString()), row["EmployeeCategory"].ToString());

                    list.Add(new Employee(Convert.ToInt32(row["Id"].ToString()), row["FirstName"].ToString(), row["MiddleName"].ToString(),
                        row["LastName"].ToString(), category, type, Convert.ToDateTime(row["DateOfJoining"].ToString()), Convert.ToDateTime(row["DOB"].ToString()),
                        row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString(),
                        Convert.ToBoolean(row["IsActive"].ToString())));
                }

            }
            return list;
        }
    }
}
