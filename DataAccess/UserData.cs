using Entity;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    /// <summary>
    /// Handles all activities related to User Table
    /// </summary>
    
    public class UserData
    {
        //Validates User credentials for login
        public static User ValidateUser(string userName, string password)
        {
            User user = null;

            //connectionString will have whole string inside connectionString in add node in Web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["FirstWeb"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            //If system connection is not open then it opens the connection
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            //Creating SqlCommand obj to connect stored procedure usp_ValidateUser and the connectionstring
            SqlCommand command = new SqlCommand("usp_ValidateUser", connection);

            //Assigning the CommandType as there are varity of CommandType so it needs to be specified
            command.CommandType = System.Data.CommandType.StoredProcedure;

            //Adding parameters of procedure which is in insert part of stored procedure
            command.Parameters.Add(new SqlParameter("@Username", userName));
            command.Parameters.Add(new SqlParameter("@Password", password));
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                user = new User(Convert.ToInt32(reader["Id"].ToString()), reader["Username"].ToString(), reader["FirstName"].ToString(),
                        reader["LastName"].ToString(), reader["Password"].ToString(), Convert.ToBoolean(reader["IsActive"].ToString()));
            }
            return user;
        }

        //Editing Firstname and Lastname of User
        public static void EditUser(string username, string password, string firstName, string lastName)
		{
            SqlCommand command = DataHelper.GetSqlCommandObject("usp_EditUser");
            command.Parameters.Add(new SqlParameter("@Username", username));
            command.Parameters.Add(new SqlParameter("@Password", password));
            command.Parameters.Add(new SqlParameter("@FirstName", firstName));
            command.Parameters.Add(new SqlParameter("@LastName", lastName));
            command.ExecuteNonQuery();
        }

    }
}
