using Entity;
using System;
using System.Collections;
using System.Data.SqlClient;

namespace DataAccess
{
    public class MasterData
    {
        public static ArrayList GetAllEmployeeType()
        {
            ArrayList list = new ArrayList();
            SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllEmployeeType").ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(new EmployeeType(Convert.ToInt32(reader["Id"].ToString()), reader["Description"].ToString(), Convert.ToBoolean(reader["IsActive"].ToString()),
                                reader["CreatedBy"].ToString(), reader["CreatedDate"].ToString(), reader["LastUpdatedBy"].ToString(), reader["LastUpdatedDate"].ToString()));
                }

            }
            return list;
        }

        public static ArrayList GetAllActiveEmployeeType()
        {
            ArrayList list = new ArrayList();
            SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllActiveEmployeeType").ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    list.Add(new EmployeeType(Convert.ToInt32(reader["Id"].ToString()), reader["Description"].ToString(), Convert.ToBoolean(reader["IsActive"].ToString()),
                                reader["CreatedBy"].ToString(), reader["CreatedDate"].ToString(), reader["LastUpdatedBy"].ToString(), reader["LastUpdatedDate"].ToString()));
                }

            }
            return list;
        }

        public static void InsertEmployeeType(EmployeeType employeeType, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_InsertEmployeeType");
            SqlParameter parameter = new SqlParameter("Id", System.Data.SqlDbType.Int, 16);
            parameter.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(parameter);
            command.Parameters.Add(new SqlParameter("@Description", employeeType.Description));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.ExecuteNonQuery();
            employeeType.Id = Convert.ToInt32(command.Parameters["@Id"].Value.ToString());
        }

        public static void UpdateEmployeeType(EmployeeType employeeType, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_UpdateEmployeeType");
            command.Parameters.Add(new SqlParameter("@Id", employeeType.Id));
            command.Parameters.Add(new SqlParameter("@Description", employeeType.Description));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.Parameters.Add(new SqlParameter("@IsActive", employeeType.IsActive));
            command.ExecuteNonQuery();
        }
    }
}
