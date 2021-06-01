using Entity;
using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace DataAccess
{
    /// <summary>
    /// All direct database interaction happens here
    /// </summary>
    
    public class MasterData
    {
        /// <summary>
        /// Database activites in Employee Type Table
        /// </summary>

        #region EmployeeType

        //It reads all Employee Type and returns list of it
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
                foreach (DataRow row in view.Table.Rows)
                {
                    list.Add(new EmployeeType(Convert.ToInt32(row["Id"].ToString()), row["Description"].ToString(), Convert.ToBoolean(row["IsActive"].ToString()),
                                row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString()));
                }

            }
            return list;
        }

        //It reads all Active Employee Type and returns the list
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

        //It inserts new Active Employee Type 
        public static void InsertEmployeeType(EmployeeType employeeType, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_InsertEmployeeType");
            SqlParameter parameter = new SqlParameter("@Id", System.Data.SqlDbType.Int, 16);
            parameter.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(parameter);
            command.Parameters.Add(new SqlParameter("@Description", employeeType.Description));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.ExecuteNonQuery();
            employeeType.Id = Convert.ToInt32(command.Parameters["@Id"].Value.ToString());
            //(new System.Collections.Generic.Mscorlib_CollectionDebugView<System.Data.SqlClient.SqlParameter>(command.Parameters._items).Items[0]).Value

        }

        //It updates the Description and Active status of Employee Type
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

        #endregion

        /// <summary>
        /// Database activites in Employee Category Table
        /// </summary>

        #region EmployeeCategory

        //It reads all Employee Category and returns list of it
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

        //It reads all Active Employee Category and returns the list
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

        //It inserts new Active Employee Category 
        public static void InsertEmployeeCategory(EmployeeCategory employeeCategory, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_InsertEmployeeCategory");
            SqlParameter parameter = new SqlParameter("@Id", System.Data.SqlDbType.Int, 16);
            parameter.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(parameter);
            command.Parameters.Add(new SqlParameter("@Description", employeeCategory.Description));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.ExecuteNonQuery();
            employeeCategory.Id = Convert.ToInt32(command.Parameters["@Id"].Value.ToString());
        }

        //It updates the Description and Active status of Employee Category
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

        #endregion

        /// <summary>
        /// Database activites in Document Type Table
        /// </summary>

        #region DocumentType

        //It reads all Document Type and returns list of it
        public static ArrayList GetAllDocumentType()
        {
            ArrayList list = new ArrayList();

            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_GetAllDocumentType");
            adapter.Fill(records);

            //SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllDocumentType").ExecuteReader();
            if (records != null && records.Tables[0].Rows.Count > 0)
            {
                DataView view = new DataView(records.Tables[0]);
                view.RowFilter = "IsActive = 1";
                foreach (DataRow row in view.Table.Rows)
                {
                    list.Add(new DocumentType(Convert.ToInt32(row["Id"].ToString()), row["Description"].ToString(), Convert.ToBoolean(row["IsActive"].ToString()),
                                row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString()));
                }

            }
            return list;
        }

        //It reads all Active Document Type and returns the list
        public static ArrayList GetAllActiveDocumentType()
        {
            ArrayList list = new ArrayList();
            //SqlDataReader reader = DataHelper.GetSqlCommandObject("usp_GetAllActiveDocumentType").ExecuteReader();
            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_GetAllActiveDocumentType");
            adapter.Fill(records);

            if (records != null && records.Tables[0].Rows.Count > 0)
            {
                DataView view = new DataView(records.Tables[0]);
                foreach (DataRow row in view.Table.Rows)
                {
                    list.Add(new DocumentType(Convert.ToInt32(row["Id"].ToString()), row["Description"].ToString(), Convert.ToBoolean(row["IsActive"].ToString()),
                                row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString()));
                }

            }
            return list;
        }

        //It inserts new Active Document Type 
        public static void InsertDocumentType(DocumentType DocumentType, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_InsertDocumentType");
            SqlParameter parameter = new SqlParameter("@Id", System.Data.SqlDbType.Int, 16);
            parameter.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(parameter);
            command.Parameters.Add(new SqlParameter("@Description", DocumentType.Description));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.ExecuteNonQuery();
            DocumentType.Id = Convert.ToInt32(command.Parameters["@Id"].Value.ToString());
        }

        //It updates the Description and Active status of Document Type 
        public static void UpdateDocumentType(DocumentType DocumentType, User user)
        {
            ArrayList list = new ArrayList();
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_UpdateDocumentType");
            command.Parameters.Add(new SqlParameter("@Id", DocumentType.Id));
            command.Parameters.Add(new SqlParameter("@Description", DocumentType.Description));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.Parameters.Add(new SqlParameter("@IsActive", DocumentType.IsActive));
            command.ExecuteNonQuery();
        }

        #endregion

    }
}
