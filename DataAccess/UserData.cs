using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Entity;

namespace DataAccess
{
    public class UserData
    {
        public static User ValidateUser(string userName, string password)
        {
            User user = null;
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
        
    }
}
