using System.Data.SqlClient;
using MyStores.Model;

namespace MyStores.Dal
{
    public class MyStoresDal
    {
        /// <summary>
        /// Checks the user login.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public bool CheckUserLogin(Users user)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "select count(*) from Users where email = @email and password = @password";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            command.Parameters["@email"].Value = user.Email;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
            command.Parameters["@password"].Value = user.Password;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count == 1;
        }

        public bool CheckEmail(string email)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "select count(*) from Users where email = @email";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            command.Parameters["@email"].Value = email;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count == 1;
        }
    }
}
