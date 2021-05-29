using Entity;
using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace DataAccess
{
    public class MasterData
    {
        public static ArrayList GetAllEmployeeType()
        {
            ArrayList list = new ArrayList();

            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_GetAllEmployeeType");
            adapter.Fill(records);

            //SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllEmployeeType").ExecuteReader();
            if (records != null && records.Tables[0].Rows.Count > 0)
            {
                DataView view = new DataView(records.Tables[0]);
                view.RowFilter = "IsActive = 1";
                foreach(DataRow row in view.Table.Rows)
                {
                    list.Add(new EmployeeType(Convert.ToInt32(row["Id"].ToString()), row["Description"].ToString(), Convert.ToBoolean(row["IsActive"].ToString()),
                                row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString()));
                }

            }
            return list;
        }

        public static ArrayList GetAllActiveEmployeeType()
        {
            ArrayList list = new ArrayList();
            //SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllActiveEmployeeType").ExecuteReader();
            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_GetAllActiveEmployeeType");
            adapter.Fill(records);

            if (records != null && records.Tables[0].Rows.Count > 0)
            {
                DataView view = new DataView(records.Tables[0]);
                foreach (DataRow row in view.Table.Rows)
                {
                    list.Add(new EmployeeType(Convert.ToInt32(row["Id"].ToString()), row["Description"].ToString(), Convert.ToBoolean(row["IsActive"].ToString()),
                                row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString()));
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
