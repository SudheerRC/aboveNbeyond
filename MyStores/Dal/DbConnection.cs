using System.Data.SqlClient;

namespace MyStores.Dal
{
    /// <summary>
    /// This class is used to set up the database connection
    /// </summary>
    public class DbConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            const string connectionString = "Data Source=(localDB)\\MSSQLLocalDB;Initial Catalog=MyStores; Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
