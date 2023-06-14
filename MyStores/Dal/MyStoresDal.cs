using System.Data.SqlClient;

namespace MyStores.Dal
{
    public class MyStoresDal
    {
        /// <summary>
        /// Checks the user.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool CheckUserLogin(string email, string password)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "select count(*) from Users where email = @email and password = @password";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            command.Parameters["@email"].Value = email;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
            command.Parameters["@password"].Value = password;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count == 1;
        }
    }
}
