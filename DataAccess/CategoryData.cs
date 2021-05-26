using Entity;
using System;
using System.Collections;
using System.Data.SqlClient;


namespace DataAccess
{
    public class CategoryData
    {
        public static ArrayList GetAllEmployeeCategory()
        {
            ArrayList list = new ArrayList();
            SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllEmployeeCategory").ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(new EmployeeCategory(Convert.ToInt32(reader["Id"].ToString()), reader["Description"].ToString(), Convert.ToBoolean(reader["IsActive"].ToString()),
                                reader["CreatedBy"].ToString(), reader["CreatedDate"].ToString(), reader["LastUpdatedBy"].ToString(), reader["LastUpdatedDate"].ToString()));
                }

            }
            return list;
        }

        public static ArrayList GetAllActiveEmployeeCategory()
        {
            ArrayList list = new ArrayList();
            SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllActiveEmployeeCategory").ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(new EmployeeCategory(Convert.ToInt32(reader["Id"].ToString()), reader["Description"].ToString(), Convert.ToBoolean(reader["IsActive"].ToString()),
                                reader["CreatedBy"].ToString(), reader["CreatedDate"].ToString(), reader["LastUpdatedBy"].ToString(), reader["LastUpdatedDate"].ToString()));
                }

            }
            return list;
        }

        public static void InsertEmployeeCategory(EmployeeCategory employeeCategory, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_InsertEmployeeCategory");
            SqlParameter parameter = new SqlParameter("Id", System.Data.SqlDbType.Int, 16);
            parameter.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(parameter);
            command.Parameters.Add(new SqlParameter("@Description", employeeCategory.Description));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.ExecuteNonQuery();
            employeeCategory.Id = Convert.ToInt32(command.Parameters["@Id"].Value.ToString());
        }

        public static void UpdateEmployeeCategory(EmployeeCategory employeeCategory, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_UpdateEmployeeCategory");
            command.Parameters.Add(new SqlParameter("@Id", employeeCategory.Id));
            command.Parameters.Add(new SqlParameter("@Description", employeeCategory.Description));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.Parameters.Add(new SqlParameter("@IsActive", employeeCategory.IsActive));
            command.ExecuteNonQuery();
        }
    }
}
