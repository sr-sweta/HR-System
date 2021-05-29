using Entity;
using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;


namespace DataAccess
{
    public class CategoryData
    {
        public static ArrayList GetAllEmployeeCategory()
        {
            ArrayList list = new ArrayList();
            //SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllEmployeeCategory").ExecuteReader();
            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_GetAllEmployeeCategory");
            adapter.Fill(records);

            if (records != null && records.Tables[0].Rows.Count > 0)
            {
                DataView view = new DataView(records.Tables[0]);
                view.RowFilter = "IsActive = 1";
                foreach (DataRow row in view.Table.Rows)
                {
                    list.Add(new EmployeeCategory(Convert.ToInt32(row["Id"].ToString()), row["Description"].ToString(), Convert.ToBoolean(row["IsActive"].ToString()),
                                row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString()));
                }

            }
            return list;
        }

        public static ArrayList GetAllActiveEmployeeCategory()
        {
            ArrayList list = new ArrayList();
            //SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllActiveEmployeeCategory").ExecuteReader();

            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_GetAllActiveEmployeeCategory");
            adapter.Fill(records);
            if (records != null && records.Tables[0].Rows.Count > 0)
            {
                DataView view = new DataView(records.Tables[0]);
                foreach (DataRow row in view.Table.Rows)
                {
                    list.Add(new EmployeeCategory(Convert.ToInt32(row["Id"].ToString()), row["Description"].ToString(), Convert.ToBoolean(row["IsActive"].ToString()),
                                row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString()));
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
