using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.IO;

namespace DataAccess
{
    /// <summary>
    /// EmployeeData handles data for insert, update and search of any employee
    /// </summary>
	public class EmployeeData
	{
        /// <summary>
        /// InsertEmployee insert employee data to employee table
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="user"></param>
        public static void InsertEmployee(Employee employee, User user)
        {
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_InsertEmployee");
            command.CommandType = CommandType.StoredProcedure;
            SqlTransaction transaction = command.Connection.BeginTransaction();
			try 
            { 
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
                command.Transaction = transaction;
                command.ExecuteNonQuery();
                employee.Id = Convert.ToInt32(command.Parameters["@Id"].Value.ToString());
                foreach(EmployeeDocument document in employee.EmployeeDocument)
				{
					if (document.IsActive)
                    {
                        InsertEmployeeDocument(employee.Id, document, transaction, command.Connection, user);
                    }
                }
                transaction.Commit();
            }
			catch(Exception exception)
			{
                transaction.Rollback();
                throw (exception);
			}
        }

        /// <summary>
        /// InsertEmployeeDocument insert employees document to backend
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="employeeDocument"></param>
        /// <param name="transaction"></param>
        /// <param name="connection"></param>
        /// <param name="user"></param>
        public static void InsertEmployeeDocument(int employeeId,EmployeeDocument employeeDocument, SqlTransaction transaction,SqlConnection connection, User user)
        {

            SqlCommand command = new SqlCommand("usp_InsertEmployeeDocuments", connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter = new SqlParameter("@Id", System.Data.SqlDbType.Int, 16);
            parameter.Direction = System.Data.ParameterDirection.Output;
            command.Parameters.Add(parameter);
            command.Parameters.Add(new SqlParameter("@Employee", employeeId));
            command.Parameters.Add(new SqlParameter("@DocumentType", employeeDocument.Document.Id));
            command.Parameters.Add(new SqlParameter("@FileName", employeeDocument.FileName));
            command.Parameters.Add(new SqlParameter("@UserId", user.Id));
            command.Transaction = transaction;
            command.ExecuteNonQuery();
            employeeDocument.Id = Convert.ToInt32(command.Parameters["@Id"].Value.ToString());
            string folderPath = HttpContext.Current.Server.MapPath(".") + @"\bin\EmployeeDocuments\" + employeeId.ToString() + @"\" + employeeDocument.Document.Id + @"\" +
                                employeeDocument.Id + @"\";
			if (!Directory.Exists(folderPath))
			{
                Directory.CreateDirectory(folderPath);
			}
            employeeDocument.PostedFile.SaveAs(folderPath + employeeDocument.PostedFile.FileName);
        }

        /// <summary>
        /// UpdateEmployee updates employee data in employee table
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="user"></param>
        public static void UpdateEmployee(Employee employee, User user)
        {
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_UpdateEmployee");
            command.CommandType = CommandType.StoredProcedure;
            SqlTransaction transaction = command.Connection.BeginTransaction();
			try
			{
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
                command.Transaction = transaction;
                command.ExecuteNonQuery();
                foreach (EmployeeDocument document in employee.EmployeeDocument)
                {
                    if (document.Id < 0 && document.IsActive)
                    {
                        InsertEmployeeDocument(employee.Id, document, transaction, command.Connection, user);
                    }
                    else if(document.Id > 0 && document.IsDirty)
					{
                        // UpdateEmployeeDocument(document.Id, transaction);
                        UpdateEmployeeDocument(document.Id);
                    }
                }
                transaction.Commit();
            }
            catch (Exception exception)
            {
                transaction.Rollback();
                throw (exception);
            }
        }

        /// <summary>
        /// UpdateEmployeeDocument updates employee document 
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="transaction"></param>
        //public static void UpdateEmployeeDocument(int documentId, SqlTransaction transaction)
        public static void UpdateEmployeeDocument(int documentId)
        {
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_UpdateEmployeeDocument");
            command.Parameters.Add(new SqlParameter("@Id", documentId));
            //command.Transaction = transaction;
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// SearchActiveEmployees searchs all employees who are active
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="categoryId"></param>
        /// <param name="employeeName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// SearchEmployeesById searchs employee by id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
            employee.EmployeeDocument = GetEmployeeDocumentById(employee.Id);
            return employee;
        }

        /// <summary>
        /// GetEmployeeDocumentById searchs employee document by employee id
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        private static ArrayList GetEmployeeDocumentById(int employeeId)
		{
            ArrayList list = new ArrayList();
            DataSet records = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = DataHelper.GetSqlCommandObject("usp_GetEmployeeDocumentById");
            adapter.SelectCommand.Parameters.Add(new SqlParameter("@Id", employeeId));
            adapter.Fill(records);

            if (records != null && records.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in records.Tables[0].Rows)
                {
                    DocumentType document = new DocumentType(Convert.ToInt32(row["DocumentTypeId"].ToString()), row["DocumentType"].ToString());

                    list.Add(new EmployeeDocument(Convert.ToInt32(row["Id"].ToString()), row["FileName"].ToString(), document,
                        row["CreatedBy"].ToString(), row["CreatedDate"].ToString(), row["LastUpdatedBy"].ToString(), row["LastUpdatedDate"].ToString(),
                        Convert.ToBoolean(row["IsActive"].ToString())));
                }

            }
            return list;
        }

        /// <summary>
        /// SearchEmployees searchs all employee according to provided details wheather he is active or not
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="categoryId"></param>
        /// <param name="employeeName"></param>
        /// <returns></returns>
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
