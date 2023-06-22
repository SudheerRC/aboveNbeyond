using Microsoft.Data.SqlClient;

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
            SqlConnectionStringBuilder conn = new SqlConnectionStringBuilder
            {
                //Azure SQL Server Name 
                DataSource = "myserver0622.database.windows.net",
                //User to connect to Azure
                UserID = "azureuser",
                //Password used in Azure
                Password = "Admin@0622",
                //Azure database name
                InitialCatalog = "MyStores"
            };

            return new SqlConnection(conn.ConnectionString);
        }
    }
}
