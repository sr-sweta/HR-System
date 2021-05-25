using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataHelper
    {
        internal static SqlCommand GetSqlCommandObject(string procedureName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FirstWeb"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);

            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            return command;
        }
    }
}
