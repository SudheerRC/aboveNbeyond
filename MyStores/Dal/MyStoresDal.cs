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

        /// <summary>
        /// Checks the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Registers the user.
        /// </summary>
        /// <param name="newUser">The new user.</param>
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

        /// <summary>
        /// Gets the user id.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public int GetUserId(string email)
        {
            int userId = 0;
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "select userID from Users where email = @email";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            command.Parameters["@email"].Value = email;
            using var reader = command.ExecuteReader();

            var userIdOrdinal = reader.GetOrdinal("userID");
            while (reader.Read())
            {
                userId = reader.GetInt32(userIdOrdinal);
            }

            return userId;
        }

        /// <summary>
        /// Adds the store.
        /// </summary>
        /// <param name="newStore">The new store.</param>
        public void AddStore(Store newStore)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "INSERT INTO Stores(ownerID, storeName, streetAddress, city, state, zipCode, country) " +
                           "VALUES (@ownerId, @storeName, @streetAddress, @city, @state, @zipCode, @country)";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@ownerId", System.Data.SqlDbType.Int);
            command.Parameters["@ownerId"].Value = newStore.OwnerId;

            command.Parameters.Add("@storeName", System.Data.SqlDbType.VarChar);
            command.Parameters["@storeName"].Value = newStore.Name;

            command.Parameters.Add("@streetAddress", System.Data.SqlDbType.VarChar);
            command.Parameters["@streetAddress"].Value = newStore.StreetAddress;

            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar);
            command.Parameters["@city"].Value = newStore.City;

            command.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
            command.Parameters["@state"].Value = newStore.State;

            command.Parameters.Add("@zipCode", System.Data.SqlDbType.VarChar);
            command.Parameters["@zipCode"].Value = newStore.ZipCode;

            command.Parameters.Add("@country", System.Data.SqlDbType.VarChar);
            command.Parameters["@country"].Value = newStore.Country;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Gets the user stores.
        /// </summary>
        /// <param name="ownerId">The owner id.</param>
        /// <returns></returns>
        public List<Store> GetUserStores(int ownerId)
        {
            var stores = new List<Store>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "select storeID, ownerID, storeName, streetAddress, city, state, zipCode, country from Stores where ownerID = @ownerId;";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@ownerId", System.Data.SqlDbType.Int);
            command.Parameters["@ownerId"].Value = ownerId;
            using var reader = command.ExecuteReader();

            var storeIdOrdinal = reader.GetOrdinal("storeID");
            var ownerIdOrdinal = reader.GetOrdinal("ownerID");
            var nameOrdinal = reader.GetOrdinal("storeName");
            var streetOrdinal = reader.GetOrdinal("streetAddress");
            var cityOrdinal = reader.GetOrdinal("city");
            var stateOrdinal = reader.GetOrdinal("state");
            var zipOrdinal = reader.GetOrdinal("zipCode");
            var countryOrdinal = reader.GetOrdinal("country");

            while (reader.Read())
            {
                var storeId = reader.GetInt32(storeIdOrdinal);
                var ownerIdC = reader.GetInt32(ownerIdOrdinal);
                var name = reader.GetString(nameOrdinal);
                var street = reader.IsDBNull(streetOrdinal) ? "" : reader.GetString(streetOrdinal);
                var city = reader.GetString(cityOrdinal);
                var state = reader.GetString(stateOrdinal);
                var zip = reader.IsDBNull(zipOrdinal) ? "" : reader.GetString(zipOrdinal);
                var country = reader.IsDBNull(countryOrdinal) ? "" : reader.GetString(countryOrdinal);

                stores.Add(new Store
                {
                    Id = storeId,
                    OwnerId = ownerIdC,
                    Name = name,
                    StreetAddress = street,
                    City = city,
                    State = state,
                    ZipCode = zip,
                    Country = country
                });
            }

            return stores;
        }

        /// <summary>
        /// Searches the product.
        /// </summary>
        /// <param name="productName">Name of the product.</param>
        /// <returns></returns>
        public List<Product> SearchProduct(String productName)
        {
            var products = new List<Product>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT productID, productName, productSize, description, departmentName, barcode, sellingPrice FROM PRODUCT WHERE ProductName LIKE '%@productName%'";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@productName", System.Data.SqlDbType.VarChar);
            command.Parameters["@productName"].Value = productName;
            using var reader = command.ExecuteReader();

            var productIdOrdinal = reader.GetOrdinal("productID");
            var productNameOrdinal = reader.GetOrdinal("productName");
            var productSizeOrdinal = reader.GetOrdinal("productSize");
            var descriptionOrdinal = reader.GetOrdinal("description");
            var departmentNameOrdinal = reader.GetOrdinal("departmentName");
            var barcodeOrdinal = reader.GetOrdinal("barcode");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");

            while (reader.Read())
            {
                var productId = reader.GetInt32(productIdOrdinal);
                var name = reader.GetString(productNameOrdinal);
                var size = reader.GetString(productSizeOrdinal);
                var description = reader.GetString(descriptionOrdinal);
                var department = reader.GetString(departmentNameOrdinal);
                var barcode = reader.GetString(barcodeOrdinal);
                var sellingPrice = reader.GetInt32(sellingPriceOrdinal);

                products.Add(new Product
                {
                    Id = productId,
                    Description = description,
                    Name = name,
                    ProductSize = size,
                    DepartmentName = department,
                    SellingPrice = sellingPrice,
                    Barcode = barcode
                });
            }

            return products;
        }

        /// <summary>
        /// Search based on the product barcode.
        /// </summary>
        /// <param name="barCode">The bar code.</param>
        /// <returns></returns>
        public List<Product> SearchProductBarcode(String barCode)
        {
            var products = new List<Product>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT productID, productName, productSize, description, departmentName, barcode, sellingPrice FROM PRODUCT WHERE barcode = @barcode";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@barcode", System.Data.SqlDbType.VarChar);
            command.Parameters["@barcode"].Value = barCode;
            using var reader = command.ExecuteReader();

            var productIdOrdinal = reader.GetOrdinal("productID");
            var productNameOrdinal = reader.GetOrdinal("productName");
            var productSizeOrdinal = reader.GetOrdinal("productSize");
            var descriptionOrdinal = reader.GetOrdinal("description");
            var departmentNameOrdinal = reader.GetOrdinal("departmentName");
            var barcodeOrdinal = reader.GetOrdinal("barcode");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");

            while (reader.Read())
            {
                var productId = reader.GetInt32(productIdOrdinal);
                var name = reader.GetString(productNameOrdinal);
                var size = reader.GetString(productSizeOrdinal);
                var description = reader.GetString(descriptionOrdinal);
                var department = reader.GetString(departmentNameOrdinal);
                var barcode = reader.GetString(barcodeOrdinal);
                var sellingPrice = reader.GetInt32(sellingPriceOrdinal);

                products.Add(new Product
                {
                    Id = productId,
                    Description = description,
                    Name = name,
                    ProductSize = size,
                    DepartmentName = department,
                    SellingPrice = sellingPrice,
                    Barcode = barcode
                });
            }

            return products;
        }

        /// <summary>
        /// Search based on the vendor name.
        /// </summary>
        /// <param name="vendorName">Name of the vendor.</param>
        /// <returns></returns>
        public List<Vendor> SearchVendor(String vendorName)
        {
            var vendors = new List<Vendor>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT vendorID, vendorName, streetAddress, city, state, zipCode, country, phoneNumber FROM Vendor WHERE vendorName LIKE '%@vendorName%'";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@vendorName", System.Data.SqlDbType.VarChar);
            command.Parameters["@vendorName"].Value = vendorName;
            using var reader = command.ExecuteReader();

            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var vendorNameOrdinal = reader.GetOrdinal("vendorName");
            var streetAddressOrdinal = reader.GetOrdinal("streetAddress");
            var cityOrdinal = reader.GetOrdinal("city");
            var stateOrdinal = reader.GetOrdinal("state");
            var zipCodeOrdinal = reader.GetOrdinal("zipCode");
            var countryOrdinal = reader.GetOrdinal("country");
            var phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");

            while (reader.Read())
            {
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                var name = reader.GetString(vendorNameOrdinal);
                var streetAddress = reader.GetString(streetAddressOrdinal);
                var city = reader.GetString(cityOrdinal);
                var state = reader.GetString(stateOrdinal);
                var zipCode = reader.GetString(zipCodeOrdinal);
                var country = reader.GetString(countryOrdinal);
                var phoneNumber = reader.GetString(phoneNumberOrdinal);

                vendors.Add(new Vendor
                {
                    Id = vendorId,
                    Name = name,
                    StreetAddress = streetAddress,
                    City = city,
                    State = state,
                    ZipCode = zipCode,
                    Country = country,
                    PhoneNumber = phoneNumber

                });
            }

            return vendors;
        }

        /// <summary>
        /// Search based on the store name.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <returns></returns>
        public List<Store> SearchStore(String storeName)
        {
            var stores = new List<Store>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT storeID, ownerID, storeName, streetAddress, city, state, zipCode, country FROM Stores WHERE storeName LIKE '%@storeName%'";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeName", System.Data.SqlDbType.VarChar);
            command.Parameters["@storeName"].Value = storeName;
            using var reader = command.ExecuteReader();

            var storeIdOrdinal = reader.GetOrdinal("storeID");
            var ownerIdOrdinal = reader.GetOrdinal("ownerID");
            var storeNameOrdinal = reader.GetOrdinal("storeName");
            var streetAddressOrdinal = reader.GetOrdinal("streetAddress");
            var cityOrdinal = reader.GetOrdinal("city");
            var stateOrdinal = reader.GetOrdinal("state");
            var zipCodeOrdinal = reader.GetOrdinal("zipCode");
            var countryOrdinal = reader.GetOrdinal("country");

            while (reader.Read())
            {
                var storeId = reader.GetInt32(storeIdOrdinal);
                var ownerId = reader.GetInt32(ownerIdOrdinal);
                var name = reader.GetString(storeNameOrdinal);
                var streetAddress = reader.GetString(streetAddressOrdinal);
                var city = reader.GetString(cityOrdinal);
                var state = reader.GetString(stateOrdinal);
                var zipCode = reader.GetString(zipCodeOrdinal);
                var country = reader.GetString(countryOrdinal);

                stores.Add(new Store
                {
                    Id = storeId,
                    OwnerId = ownerId,
                    Name = name,
                    StreetAddress = streetAddress,
                    City = city,
                    State = state,
                    ZipCode = zipCode,
                    Country = country,

                });
            }

            return stores;
        }

        /// <summary>
        /// Adds the product.
        /// </summary>
        /// <param name="newProduct">The new product.</param>
        public void AddProduct(Product newProduct)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query =
                "INSERT INTO Product(productName, productSize, description, departmentName, barcode, sellingPrice) " +
                "VALUES (@name, @size, @description, @department, @barcode, @price)";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
            command.Parameters["@name"].Value = newProduct.Name;

            command.Parameters.Add("@size", System.Data.SqlDbType.VarChar);
            command.Parameters["@size"].Value = newProduct.ProductSize;

            command.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
            command.Parameters["@description"].Value = newProduct.Description;

            command.Parameters.Add("@department", System.Data.SqlDbType.VarChar);
            command.Parameters["@department"].Value = newProduct.DepartmentName;

            command.Parameters.Add("@barcode", System.Data.SqlDbType.VarChar);
            command.Parameters["@barcode"].Value = newProduct.Barcode;

            command.Parameters.Add("@price", System.Data.SqlDbType.Decimal);
            command.Parameters["@price"].Value = newProduct.SellingPrice;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Adds the vendor.
        /// </summary>
        /// <param name="vendor">The vendor.</param>
        public void AddVendor(Vendor vendor)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "INSERT Vendor (vendorName, streetAddress, city, state, zipCode, country, phoneNumber) " +
                           "VALUES (@vendorName, @streetAddress, @city, @state, @zipCode, @country, @phoneNumber)";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@vendorName", System.Data.SqlDbType.VarChar);
            command.Parameters["@vendorName"].Value = vendor.Name;

            command.Parameters.Add("@streetAddress", System.Data.SqlDbType.VarChar);
            command.Parameters["@streetAddress"].Value = vendor.StreetAddress;

            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar);
            command.Parameters["@city"].Value = vendor.City;

            command.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
            command.Parameters["@state"].Value = vendor.State;

            command.Parameters.Add("@zipCode", System.Data.SqlDbType.VarChar);
            command.Parameters["@zipCode"].Value = vendor.ZipCode;

            command.Parameters.Add("@country", System.Data.SqlDbType.VarChar);
            command.Parameters["@country"].Value = vendor.Country;

            command.Parameters.Add("@phoneNumber", System.Data.SqlDbType.VarChar);
            command.Parameters["@phoneNumber"].Value = vendor.PhoneNumber;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Adds the manager.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="storeId">The store id.</param>
        public void AddManager(int userId, int storeId)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "INSERT INTO StoreManagers (storeID, managerID) VALUES (@storeId, @managerId)";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;

            command.Parameters.Add("@userId", System.Data.SqlDbType.Int);
            command.Parameters["@userId"].Value = userId;

            command.ExecuteNonQuery();
        }

        public List<Product> SearchProductWithStoreId(int storeId)
        {
            var products = new List<Product>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT productID, productName, productSize, description, departmentName, barcode, sellingPrice FROM Product,Inventory WHERE Inventory.productID = Product.productID and Inventory.storeID = @storeID";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;
            using var reader = command.ExecuteReader();

            var productIdOrdinal = reader.GetOrdinal("productID");
            var productNameOrdinal = reader.GetOrdinal("productName");
            var productSizeOrdinal = reader.GetOrdinal("productSize");
            var descriptionOrdinal = reader.GetOrdinal("description");
            var departmentNameOrdinal = reader.GetOrdinal("departmentName");
            var barcodeOrdinal = reader.GetOrdinal("barcode");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");

            while (reader.Read())
            {
                var productId = reader.GetInt32(productIdOrdinal);
                var name = reader.GetString(productNameOrdinal);
                var size = reader.GetString(productSizeOrdinal);
                var description = reader.GetString(descriptionOrdinal);
                var department = reader.GetString(departmentNameOrdinal);
                var barcode = reader.GetString(barcodeOrdinal);
                var sellingPrice = reader.GetInt32(sellingPriceOrdinal);

                products.Add(new Product
                {
                    Id = productId,
                    Description = description,
                    Name = name,
                    ProductSize = size,
                    DepartmentName = department,
                    SellingPrice = sellingPrice,
                    Barcode = barcode
                });
            }

            return products;
        }

        public List<Product> SearchProductWithStoreIdAndName(int storeId, String productName)
        {
            var products = new List<Product>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT productID, productName, productSize, description, departmentName, barcode, sellingPrice FROM Product,Inventory WHERE Inventory.productID = Product.productID and Inventory.storeID = @storeID and ProductName LIKE '%@productName%'";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;
            command.Parameters.Add("@productName", System.Data.SqlDbType.VarChar);
            command.Parameters["@productName"].Value = productName;
            using var reader = command.ExecuteReader();

            var productIdOrdinal = reader.GetOrdinal("productID");
            var productNameOrdinal = reader.GetOrdinal("productName");
            var productSizeOrdinal = reader.GetOrdinal("productSize");
            var descriptionOrdinal = reader.GetOrdinal("description");
            var departmentNameOrdinal = reader.GetOrdinal("departmentName");
            var barcodeOrdinal = reader.GetOrdinal("barcode");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");

            while (reader.Read())
            {
                var productId = reader.GetInt32(productIdOrdinal);
                var name = reader.GetString(productNameOrdinal);
                var size = reader.GetString(productSizeOrdinal);
                var description = reader.GetString(descriptionOrdinal);
                var department = reader.GetString(departmentNameOrdinal);
                var barcode = reader.GetString(barcodeOrdinal);
                var sellingPrice = reader.GetInt32(sellingPriceOrdinal);

                products.Add(new Product
                {
                    Id = productId,
                    Description = description,
                    Name = name,
                    ProductSize = size,
                    DepartmentName = department,
                    SellingPrice = sellingPrice,
                    Barcode = barcode
                });
            }

            return products;
        }

        public List<InventoryItem> SearchInventory(int storeId)
        {
            var stores = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT inventoryID, vendorID, productID, storeID, purchasePrice, sellingPrice and quantity FROM Inventory WHERE Inventory.storeID = @storeID";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.VarChar);
            command.Parameters["@storeID"].Value = storeId;
            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var productIdOrdinal = reader.GetOrdinal("productID");
            var storeIdOrdinal = reader.GetOrdinal("storeID");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);
                var storeID = reader.GetInt32(storeIdOrdinal);
                var purchasePrice = reader.GetString(purchasePriceOrdinal);
                var sellingPrice = reader.GetString(sellingPriceOrdinal);
                var quantity = reader.GetString(quantityOrdinal);

                stores.Add(new InventoryItem
                {
                    //Id = storeID,
                    //OwnerId = ownerId,
                    //Name = name,
                    //StreetAddress = streetAddress,
                    //City = city,
                    //State = state,
                    //ZipCode = zipCode,
                    //Country = country,

                });
            }

            return stores;
        }
    }
}
