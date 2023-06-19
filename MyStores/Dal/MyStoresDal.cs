using System.Data;
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

        public void RegisterUser(Users newUser)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            using var command = new SqlCommand("registerUser", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar);
            command.Parameters["@firstName"].Value = newUser.FirstName;

            command.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            command.Parameters["@lastName"].Value = newUser.LastName;

            command.Parameters.Add("@dateOfBirth", System.Data.SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = newUser.DOB;

            command.Parameters.Add("@gender", System.Data.SqlDbType.VarChar);
            command.Parameters["@gender"].Value = newUser.Gender;

            command.Parameters.Add("@streetAddress", System.Data.SqlDbType.VarChar);
            command.Parameters["@streetAddress"].Value = newUser.StreetAddress;

            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar);
            command.Parameters["@city"].Value = newUser.City;

            command.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
            command.Parameters["@state"].Value = newUser.State;

            command.Parameters.Add("@zipCode", System.Data.SqlDbType.VarChar);
            command.Parameters["@zipCode"].Value = newUser.ZipCode;

            command.Parameters.Add("@country", System.Data.SqlDbType.VarChar);
            command.Parameters["@country"].Value = newUser.Country;

            command.Parameters.Add("@phoneNumber", System.Data.SqlDbType.Char);
            command.Parameters["@phoneNumber"].Value = newUser.PhoneNumber;

            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            command.Parameters["@email"].Value = newUser.Email;

            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
            command.Parameters["@password"].Value = newUser.Password;

            command.ExecuteNonQuery();
        }
    }
}
