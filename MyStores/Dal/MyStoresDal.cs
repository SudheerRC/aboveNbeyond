using System.Data;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.SqlClient;
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

        public Users GetUserDetails(int userId)
        {
            var user = new Users();
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "select firstName, lastName, dateOfBirth, gender from UserDetails where userID = @userId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@userId", System.Data.SqlDbType.Int);
            command.Parameters["@userId"].Value = userId;

            using var reader = command.ExecuteReader();

            var fNameOrdinal = reader.GetOrdinal("firstName");
            var lNameOrdinal = reader.GetOrdinal("lastName");
            var dobOrdinal = reader.GetOrdinal("dateOfBirth");
            var genderOrdinal = reader.GetOrdinal("gender");

            while (reader.Read())
            {
                var fName = reader.GetString(fNameOrdinal);
                var lName = reader.GetString(lNameOrdinal);
                var dob = reader.GetDateTime(dobOrdinal);
                var gender = reader.GetString(genderOrdinal);

                user = new Users()
                {
                    UserId = userId,
                    FirstName = fName,
                    LastName = lName,
                    DOB = dob,
                    Gender = gender
                };
            }
            return user;
        }

        /// <summary>
        /// Adds the store.
        /// </summary>
        /// <param name="newStore">The new store.</param>
        public void AddStore(Store newStore)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "INSERT INTO Stores(ownerID, storeName, streetAddress, city, state, zipCode, country, status) " +
                           "VALUES (@ownerId, @storeName, @streetAddress, @city, @state, @zipCode, @country, @status)";
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

            command.Parameters.Add("@status", System.Data.SqlDbType.Bit);
            command.Parameters["@status"].Value = newStore.Status;

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
                "select storeID, ownerID, storeName, streetAddress, city, state, zipCode, country from Stores where ownerID = @ownerId and status = 1;";
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
        /// Gives the name of the Vendor by the given vendor Id.
        /// </summary>
        /// <param name="vendorId">Vendor Id.</param>
        /// <returns>Name of the vendor</returns>
        public string NameOfVendorWithId(int vendorId)
        {
            var name = "";
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT vendorName FROM Vendor WHERE vendorID = @ID";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            command.Parameters["@ID"].Value = vendorId;
            using var reader = command.ExecuteReader();

            var vendorNameOrdinal = reader.GetOrdinal("vendorName");

            while (reader.Read())
            {
                name = reader.GetString(vendorNameOrdinal);
            }

            return name;
        }

        /// <summary>
        /// Searches the product.
        /// </summary>
        /// <param name="productName">Name of the product.</param>
        /// <returns></returns>
        public List<Product> SearchProductWithProductName(String productName)
        {
            var products = new List<Product>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT productID, productName, productSize, description, departmentName, barcode, sellingPrice FROM PRODUCT WHERE ProductName LIKE '%'+ @productName +'%'";
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
                var sellingPrice = reader.GetDecimal(sellingPriceOrdinal);

                products.Add(new Product
                {
                    Id = productId,
                    Description = description,
                    Name = name,
                    ProductSize = size,
                    DepartmentName = department,
                    SellingPrice = Decimal.ToDouble(sellingPrice),
                    Barcode = barcode
                });
            }

            return products;
        }

        /// <summary>
        /// Searches the product.
        /// </summary>
        /// <param name="productId">Id of the product.</param>
        /// <returns>Product object</returns>
        public Product SearchProductWithId(int productId)
        {
            var foundProduct = new Product();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT productName, productSize, description, departmentName, " +
                           "barcode, sellingPrice, productImage " +
                           "FROM PRODUCT WHERE productID = @productId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@productId", System.Data.SqlDbType.Int);
            command.Parameters["@productId"].Value = productId;
            using var reader = command.ExecuteReader();

            var productNameOrdinal = reader.GetOrdinal("productName");
            var productSizeOrdinal = reader.GetOrdinal("productSize");
            var descriptionOrdinal = reader.GetOrdinal("description");
            var departmentNameOrdinal = reader.GetOrdinal("departmentName");
            var barcodeOrdinal = reader.GetOrdinal("barcode");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var imageOrdinal = reader.GetOrdinal("productImage");

            while (reader.Read())
            {
                var name = reader.GetString(productNameOrdinal);
                var size = reader.IsDBNull(productSizeOrdinal) ? "" : reader.GetString(productSizeOrdinal);
                var description = reader.IsDBNull(descriptionOrdinal) ? "" : reader.GetString(descriptionOrdinal);
                var department = reader.IsDBNull(departmentNameOrdinal) ? "" : reader.GetString(departmentNameOrdinal);
                var barcode = reader.IsDBNull(barcodeOrdinal) ? "" : reader.GetString(barcodeOrdinal);
                var sellingPrice = reader.IsDBNull(sellingPriceOrdinal) ? -1 : reader.GetDecimal(sellingPriceOrdinal);
                var imageStream = reader.IsDBNull(imageOrdinal) ? Stream.Null : reader.GetStream(imageOrdinal);

                foundProduct = new Product
                {
                    Id = productId,
                    Description = description,
                    Name = name,
                    ProductSize = size,
                    DepartmentName = department,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    Image = MagicImageConverter.GetBytesFromStream(imageStream),
                    Barcode = barcode
                };
            }

            return foundProduct;
        }

        /// <summary>
        /// Search based on the product barcode.
        /// </summary>
        /// <param name="barCode">The bar code.</param>
        /// <returns></returns>
        public List<Product> SearchProductWithBarcode(String barCode)
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
        public List<Vendor> SearchVendorWithVendorName(String vendorName)
        {
            var vendors = new List<Vendor>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT vendorID, vendorName, streetAddress, city, state, zipCode, country, phoneNumber FROM Vendor WHERE vendorName LIKE '%' + @vendorName+ '%'";
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
        /// Searches the vendor by store id.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<Vendor> SearchVendorByStoreId(int storeId)
        {
            var vendors = new List<Vendor>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT Vendor.vendorID, vendorName, streetAddress, city, state, zipCode, country, phoneNumber " +
                "FROM Vendor, StoreVendors WHERE Vendor.vendorID = StoreVendors.vendorID AND StoreVendors.storeID = @storeId ";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;
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
        /// Gets all vendors.
        /// </summary>
        /// <returns></returns>
        public List<Vendor> GetAllVendors()
        {
            var vendors = new List<Vendor>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT vendorID, vendorName, streetAddress, city, state, zipCode, country, phoneNumber FROM Vendor";
            using var command = new SqlCommand(query, connection);

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
        /// Gets all managers of store.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<Users> GetAllManagersOfStore(int storeId)
        {
            var managers = new List<Users>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT firstName, lastName, userID FROM UserDetails, StoreManagers " +
                "WHERE userID = managerID AND storeID = @storeId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;
            using var reader = command.ExecuteReader();

            var userIdOrdinal = reader.GetOrdinal("userID");
            var firstNameOrdinal = reader.GetOrdinal("firstName");
            var lastNameOrdinal = reader.GetOrdinal("lastName");

            while (reader.Read())
            {
                var userId = reader.GetInt32(userIdOrdinal);
                var firstName = reader.GetString(firstNameOrdinal);
                var lastName = reader.GetString(lastNameOrdinal);

                managers.Add(new Users
                {
                    FirstName = firstName,
                    LastName = lastName,
                    UserId = userId

                });
            }

            return managers;
        }

        /// <summary>
        /// Search based on the store name.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <param name="userId">User id of store.</param>
        /// <returns></returns>
        public List<Store> SearchStoreWithStoreNameAndUserId(String storeName, int userId)
        {
            var stores = new List<Store>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT storeID, ownerID, storeName, streetAddress, city, state, zipCode, country " +
                "FROM Stores WHERE storeName LIKE '%' + @storeName + '%' and ownerID = @userId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeName", System.Data.SqlDbType.VarChar);
            command.Parameters["@storeName"].Value = storeName;

            command.Parameters.Add("@userId", System.Data.SqlDbType.Int);
            command.Parameters["@userId"].Value = userId;
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
                "INSERT INTO Product(productName, productSize, description, departmentName, barcode, sellingPrice, productImage) " +
                "VALUES (@name, @size, @description, @department, @barcode, @price, @image)";
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

            command.Parameters.Add("@image", System.Data.SqlDbType.Image);
            command.Parameters["@image"].Value = newProduct.Image;

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
        /// Adds the inventory.
        /// </summary>
        /// <param name="inventoryItem">The inventory item.</param>
        /// <param name="storeId">The store id.</param>
        public void AddInventory(InventoryItem inventoryItem, int storeId)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "INSERT Inventory (vendorID, productID, storeID, purchasePrice, sellingPrice, quantity, status) " +
                           "VALUES (@vendorID, @productID, @storeID, @purchasePrice, @sellingPrice, @quantity, @status)";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@vendorID", System.Data.SqlDbType.Int);
            command.Parameters["@vendorID"].Value = inventoryItem.VendorId;

            command.Parameters.Add("@productID", System.Data.SqlDbType.Int);
            command.Parameters["@productID"].Value = inventoryItem.Item.Id;

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;

            command.Parameters.Add("@purchasePrice", System.Data.SqlDbType.Decimal);
            command.Parameters["@purchasePrice"].Value = inventoryItem.PurchasePrice;

            command.Parameters.Add("@sellingPrice", System.Data.SqlDbType.Decimal);
            command.Parameters["@sellingPrice"].Value = inventoryItem.SellingPrice;

            command.Parameters.Add("@quantity", System.Data.SqlDbType.Int);
            command.Parameters["@quantity"].Value = inventoryItem.Quantity;

            command.Parameters.Add("@status", System.Data.SqlDbType.Bit);
            command.Parameters["@status"].Value = inventoryItem.Status;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Adds the vendor to store.
        /// </summary>
        /// <param name="vendorId">The vendor id.</param>
        /// <param name="storeId">The store id.</param>
        public void AddVendorToStore(int vendorId, int storeId)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "INSERT StoreVendors (vendorID, storeID) " +
                           "VALUES (@vendorId, @storeId)";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@vendorId", System.Data.SqlDbType.Int);
            command.Parameters["@vendorId"].Value = vendorId;

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;

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

            command.Parameters.Add("@managerId", System.Data.SqlDbType.Int);
            command.Parameters["@managerId"].Value = userId;

            command.ExecuteNonQuery();
        }


        /// <summary>
        /// Searches the name of the product with store id and product name.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="productName">Name of the product.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndName(int storeId, String productName)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT inventoryID, vendorID, purchasePrice, Inventory.sellingPrice, quantity, Inventory.productID " +
                "FROM Product,Inventory WHERE Inventory.productID = Product.productID and " +
                "Inventory.storeID = @storeID and ProductName LIKE '%' + @productName +'%'";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;
            command.Parameters.Add("@productName", System.Data.SqlDbType.VarChar);
            command.Parameters["@productName"].Value = productName;
            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    VendorId = vendorId,
                    Quantity = quantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Searches the inventory.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchInventory(int storeId)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT inventoryID, vendorID, purchasePrice, sellingPrice, quantity, productID, defaultQuantity " +
                "FROM Inventory WHERE Inventory.storeID = @storeID";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.VarChar);
            command.Parameters["@storeID"].Value = storeId;
            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var minQuantityOrdinal = reader.GetOrdinal("defaultQuantity");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);
                var minQuantity = reader.GetInt32(minQuantityOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    VendorId = vendorId,
                    Quantity = quantity,
                    MinQuantity = minQuantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Gets the name of the store.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public string GetStoreName(int storeId)
        {
            string name = "";
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT  storeName FROM Stores WHERE storeID = @storeId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;
            using var reader = command.ExecuteReader();

            var storeNameOrdinal = reader.GetOrdinal("storeName");
            while (reader.Read())
            {
                name = reader.GetString(storeNameOrdinal);
            }

            return name;
        }

        /// <summary>
        /// Checks the store vendor exists.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="vendorId">The vendor id.</param>
        /// <returns></returns>
        public bool CheckStoreVendorExists(int storeId, int vendorId)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "select count(*) from StoreVendors where storeID = @storeId and vendorId = @vendorId";

            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;

            command.Parameters.Add("@vendorId", System.Data.SqlDbType.Int);
            command.Parameters["@vendorId"].Value = vendorId;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count >= 1;
        }

        /// <summary>
        /// Searches the name of the vendors with vendor name.
        /// </summary>
        /// <param name="inputName">Name of the vendor.</param>
        /// <returns></returns>
        public List<Vendor> SearchVendorsWithName(string inputName)
        {
            var vendors = new List<Vendor>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT vendorID, vendorName, streetAddress, city, state, zipCode, country, phoneNumber FROM Vendor where vendorName LIKE '%' + @inputName + '%'";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@inputName", System.Data.SqlDbType.VarChar);
            command.Parameters["@inputName"].Value = inputName;

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
        /// Searches the inventory with vendor id.
        /// </summary>
        /// <param name="vendorId">The vendor id.</param>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchInventoryWithVendorId(int vendorId, int storeId)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT inventoryID, productName, description, productImage, purchasePrice, quantity, Inventory.productID FROM Product, Inventory " +
                "WHERE Inventory.productID = Product.productID and Inventory.vendorId = @vendorId and Inventory.storeID = @storeId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@vendorId", System.Data.SqlDbType.Int);
            command.Parameters["@vendorId"].Value = vendorId;

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;
            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var productNameOrdinal = reader.GetOrdinal("productName");
            var descriptionOrdinal = reader.GetOrdinal("description");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var imageOrdinal = reader.GetOrdinal("productImage");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var name = reader.GetString(productNameOrdinal);
                var description = reader.IsDBNull(descriptionOrdinal) ? "" : reader.GetString(descriptionOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var imageStream = reader.GetStream(imageOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    VendorId = vendorId,
                    Quantity = quantity,
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId,
                        Name = name,
                        Description = description,
                        Image = MagicImageConverter.GetBytesFromStream(imageStream),
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Searches the product with store id and barcode.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="barcode">The barcode.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndBarcode(int storeId, String barcode)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT inventoryID, vendorID, purchasePrice, Inventory.sellingPrice, quantity, Inventory.productID " +
                           "FROM Product,Inventory WHERE Inventory.productID = Product.productID " +
                           "and Inventory.storeID = @storeID and barcode LIKE '%' + @barcode +'%'";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;
            command.Parameters.Add("@barcode", System.Data.SqlDbType.VarChar);
            command.Parameters["@barcode"].Value = barcode;

            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("invetoryID");
            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    VendorId = vendorId,
                    Quantity = quantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Searches the product with store id and description.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="description">The description.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndDescription(int storeId, String description)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT inventoryID, vendorID, purchasePrice, Inventory.sellingPrice, quantity, Inventory.productID " +
                           "FROM Product,Inventory WHERE Inventory.productID = Product.productID " +
                           "and Inventory.storeID = @storeID and description LIKE '%' + @description +'%'";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;
            command.Parameters.Add("@description", System.Data.SqlDbType.VarChar);
            command.Parameters["@description"].Value = description;

            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    VendorId = vendorId,
                    Quantity = quantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Searches the product with store id and product size.
        /// </summary>
        /// <param name="storeId">The store identifier.</param>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndSize(int storeId, String size)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT inventoryID, vendorID, purchasePrice, Inventory.sellingPrice, quantity, Inventory.productID " +
                           "FROM Product,Inventory WHERE Inventory.productID = Product.productID " +
                           "and Inventory.storeID = @storeID and productSize LIKE '%' + @size +'%'";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;
            command.Parameters.Add("@size", System.Data.SqlDbType.VarChar);
            command.Parameters["@size"].Value = size;

            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    VendorId = vendorId,
                    Quantity = quantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Searches the product with store id and vendor name.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndVendorName(int storeId, String name)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT inventoryID, Inventory.vendorID, purchasePrice, Inventory.sellingPrice, quantity, Inventory.productID " +
                           "FROM Product,Inventory, Vendor WHERE Inventory.productID = Product.productID " +
                           "and Inventory.vendorID = Vendor.vendorID and Inventory.storeID = @storeID " +
                           "and Vendor.vendorName LIKE '%' + @name +'%'";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;
            command.Parameters.Add("@name", System.Data.SqlDbType.VarChar);
            command.Parameters["@name"].Value = name;

            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    VendorId = vendorId,
                    Quantity = quantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Searches the product with store id and selling price.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="price">The price.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndSellingPrice(int storeId, decimal price)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT inventoryID, vendorID, purchasePrice, Inventory.sellingPrice, quantity, Inventory.productID " +
                           "FROM Product,Inventory WHERE Inventory.productID = Product.productID " +
                           "and Inventory.storeID = @storeID and Inventory.sellingPrice = @price";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;
            command.Parameters.Add("@price", System.Data.SqlDbType.Decimal);
            command.Parameters["@price"].Value = price;

            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    VendorId = vendorId,
                    Quantity = quantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Searches the product with store id and purchase price.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="price">The price.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndPurchasePrice(int storeId, decimal price)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT inventoryID, vendorID, purchasePrice, Inventory.sellingPrice, quantity, Inventory.productID " +
                           "FROM Product,Inventory WHERE Inventory.productID = Product.productID " +
                           "and Inventory.storeID = @storeID and Inventory.purchasePrice = @price";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeID", System.Data.SqlDbType.Int);
            command.Parameters["@storeID"].Value = storeId;
            command.Parameters.Add("@price", System.Data.SqlDbType.Decimal);
            command.Parameters["@price"].Value = price;

            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var vendorIdOrdinal = reader.GetOrdinal("vendorID");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var vendorId = reader.GetInt32(vendorIdOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    VendorId = vendorId,
                    Quantity = quantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Search based on the vendor id.
        /// </summary>
        /// <param name="vendorId">Id of the vendor.</param>
        /// <returns></returns>
        public Vendor SearchVendorWithVendorId(int vendorId)
        {
            var vendor = new Vendor();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT vendorName, streetAddress, city, state, zipCode, country, phoneNumber " +
                "FROM Vendor WHERE vendorID = @vendorId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@vendorId", System.Data.SqlDbType.Int);
            command.Parameters["@vendorId"].Value = vendorId;
            using var reader = command.ExecuteReader();

            var vendorNameOrdinal = reader.GetOrdinal("vendorName");
            var streetAddressOrdinal = reader.GetOrdinal("streetAddress");
            var cityOrdinal = reader.GetOrdinal("city");
            var stateOrdinal = reader.GetOrdinal("state");
            var zipCodeOrdinal = reader.GetOrdinal("zipCode");
            var countryOrdinal = reader.GetOrdinal("country");
            var phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");

            while (reader.Read())
            {
                var name = reader.GetString(vendorNameOrdinal);
                var streetAddress = reader.GetString(streetAddressOrdinal);
                var city = reader.GetString(cityOrdinal);
                var state = reader.GetString(stateOrdinal);
                var zipCode = reader.GetString(zipCodeOrdinal);
                var country = reader.GetString(countryOrdinal);
                var phoneNumber = reader.GetString(phoneNumberOrdinal);

                vendor = new Vendor()
                {
                    Id = vendorId,
                    Name = name,
                    StreetAddress = streetAddress,
                    City = city,
                    State = state,
                    ZipCode = zipCode,
                    Country = country,
                    PhoneNumber = phoneNumber

                };
            }

            return vendor;
        }

        /// <summary>
        /// Edit the product.
        /// </summary>
        /// <param name="newProduct">The new product.</param>
        public void EditProduct(Product newProduct)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "UPDATE Product SET productName = @name, productSize = @size, " +
                           "description = @description, departmentName = @department, barcode = @barcode, " +
                           "sellingPrice = @price, productImage = @image where productID = @productId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@productId", System.Data.SqlDbType.Int);
            command.Parameters["@productId"].Value = newProduct.Id;

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

            command.Parameters.Add("@image", System.Data.SqlDbType.Image);
            command.Parameters["@image"].Value = newProduct.Image;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Places the order.
        /// </summary>
        /// <param name="order">The order.</param>
        public int PlaceOrder(Order order)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            using var command = new SqlCommand("placeOrder", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@orderDate", System.Data.SqlDbType.Date);
            command.Parameters["@orderDate"].Value = DateOnly.FromDateTime(DateTime.Now);

            command.Parameters.Add("@expectedDate", System.Data.SqlDbType.Date);
            command.Parameters["@expectedDate"].Value = DateOnly.FromDateTime(DateTime.Now).AddDays(7);

            command.Parameters.Add("@userId", System.Data.SqlDbType.Int);
            command.Parameters["@userId"].Value = order.UserId;

            command.Parameters.Add("@vendorId", System.Data.SqlDbType.Int);
            command.Parameters["@vendorId"].Value = order.VendorId;

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = order.StoreId;

            command.Parameters.Add("@orderId", System.Data.SqlDbType.Int).Direction 
                = ParameterDirection.Output;
            
            command.ExecuteNonQuery();
            int orderId = Convert.ToInt32(command.Parameters["@orderId"].Value);

            return orderId;
        }

        /// <summary>
        /// Inserts the order items.
        /// </summary>
        /// <param name="items">The inventory items.</param>
        /// <param name="orderId">The order id.</param>
        public void InsertOrderItems(List<InventoryItem> items, int orderId)
        {
            using var connection = DbConnection.GetConnection();
            
            string query = "INSERT INTO Orders(orderID, inventoryID, purchasePrice, quantity) " +
                           "VALUES (@orderID, @inventoryID, @purchasePrice, @quantity)";
            using var command = new SqlCommand(query, connection);

            foreach (var currentItem in items)
            {
                command.Parameters.Add("@orderID", System.Data.SqlDbType.Int);
                command.Parameters["@orderID"].Value = orderId;

                command.Parameters.Add("@inventoryID", System.Data.SqlDbType.Int);
                command.Parameters["@inventoryID"].Value = currentItem.InventoryId;

                command.Parameters.Add("@purchasePrice", System.Data.SqlDbType.Decimal);
                command.Parameters["@purchasePrice"].Value = currentItem.PurchasePrice;

                command.Parameters.Add("@quantity", System.Data.SqlDbType.Int);
                command.Parameters["@quantity"].Value = currentItem.Quantity;

                connection.Open();
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();
            }
        }

        /// <summary>
        /// Edit the vendor.
        /// </summary>
        /// <param name="vendor">The vendor.</param>
        public void EditVendor(Vendor vendor)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "UPDATE Vendor SET vendorName = @vendorName , streetAddress = @streetAddress, " +
                           "city = @city, state = @state, zipCode = @zipCode, country = @country, " +
                           "phoneNumber = @phoneNumber where vendorID = @vendorId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@vendorId", System.Data.SqlDbType.Int);
            command.Parameters["@vendorId"].Value = vendor.Id;

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
        /// Open orders for store.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<Order> OpenOrdersForStore(int storeId)
        {
            List<Order> orders = new List<Order>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "select orderID, Vendor.vendorName, OrderDetails.orderDate " +
                           "FROM OrderDetails, Vendor where OrderDetails.vendorID = Vendor.vendorID " +
                           "and OrderDetails.storeID = @storeId and OrderDetails.deliveredDate IS NULL";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;
            using var reader = command.ExecuteReader();

            var vendorNameOrdinal = reader.GetOrdinal("vendorName");
            var orderIdOrdinal = reader.GetOrdinal("orderID");
            var dateOrdinal = reader.GetOrdinal("orderDate");

            while (reader.Read())
            {
                var vendorName = reader.GetString(vendorNameOrdinal);
                var orderId = reader.GetInt32(orderIdOrdinal);
                var date = reader.GetDateTime(dateOrdinal);

                orders.Add(new Order
                {
                    VendorName = vendorName,
                    OrderId = orderId,
                    OrderDate = DateOnly.FromDateTime(date)
                });
            }

            return orders;
        }

        /// <summary>
        /// Receives the order.
        /// </summary>
        /// <param name="items">The inventory items.</param>
        /// <param name="orderId">The order id.</param>
        public void ReceiveOrder(List<InventoryItem> items, int orderId)
        {
            using var connection = DbConnection.GetConnection();
            
            using var command = new SqlCommand("receiveOrder", connection);
            command.CommandType = CommandType.StoredProcedure;

            foreach (var currentItem in items)
            {
                command.Parameters.Add("@orderId ", System.Data.SqlDbType.Int);
                command.Parameters["@orderId "].Value = orderId;

                command.Parameters.Add("@inventoryID", System.Data.SqlDbType.Int);
                command.Parameters["@inventoryID"].Value = currentItem.InventoryId;

                command.Parameters.Add("@newQuantity", System.Data.SqlDbType.Int);
                command.Parameters["@newQuantity"].Value = currentItem.Quantity;

                command.Parameters.Add("@deliveredDate ", System.Data.SqlDbType.Date);
                command.Parameters["@deliveredDate "].Value = DateOnly.FromDateTime(DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();
            }
        }

        /// <summary>
        /// Searches the inventory with order id.
        /// </summary>
        /// <param name="orderId">The order id.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchInventoryWithOrderId(int orderId)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT Inventory.inventoryID, productName, description, productImage, " +
                           "Orders.purchasePrice, Orders.quantity, Inventory.productID " +
                           "FROM Product, Inventory, Orders WHERE Inventory.productID = Product.productID " +
                           "and Inventory.inventoryID = Orders.inventoryID and Orders.orderID = @orderID";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@orderID", System.Data.SqlDbType.Int);
            command.Parameters["@orderID"].Value = orderId;
            using var reader = command.ExecuteReader();

            var inventoryIdOrdinal = reader.GetOrdinal("inventoryID");
            var productNameOrdinal = reader.GetOrdinal("productName");
            var descriptionOrdinal = reader.GetOrdinal("description");
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var imageOrdinal = reader.GetOrdinal("productImage");
            var productIdOrdinal = reader.GetOrdinal("productID");

            while (reader.Read())
            {
                var inventoryId = reader.GetInt32(inventoryIdOrdinal);
                var name = reader.GetString(productNameOrdinal);
                var description = reader.IsDBNull(descriptionOrdinal) ? "" : reader.GetString(descriptionOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var imageStream = reader.GetStream(imageOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    InventoryId = inventoryId,
                    Quantity = quantity,
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    Item = new Product
                    {
                        Id = productId,
                        Name = name,
                        Description = description,
                        Image = MagicImageConverter.GetBytesFromStream(imageStream),
                    }

                });
            }

            return inventoryItems;
        }

        /// <summary>
        /// Deletes the product from store.
        /// </summary>
        /// <param name="inventoryId">The inventory id.</param>
        public void DeleteProductFromStore(int inventoryId)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "Delete FROM Inventory where inventoryID = @inventoryId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@inventoryId", System.Data.SqlDbType.Int);
            command.Parameters["@inventoryId"].Value = inventoryId;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates the inventory item.
        /// </summary>
        /// <param name="inventoryItem">The inventory item.</param>
        public void UpdateInventoryItem(InventoryItem inventoryItem)
        {
            using var connection = DbConnection.GetConnection();
            connection.Open();
            string query = "UPDATE Inventory set purchasePrice = @purchasePrice, sellingPrice = @sellingPrice, " +
                           "quantity = @quantity, defaultQuantity = @minQuantity where inventoryID = @inventoryId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@inventoryId", System.Data.SqlDbType.Int);
            command.Parameters["@inventoryId"].Value = inventoryItem.InventoryId;

            command.Parameters.Add("@purchasePrice", System.Data.SqlDbType.Decimal);
            command.Parameters["@purchasePrice"].Value = inventoryItem.PurchasePrice;

            command.Parameters.Add("@sellingPrice", System.Data.SqlDbType.Decimal);
            command.Parameters["@sellingPrice"].Value = inventoryItem.SellingPrice;

            command.Parameters.Add("@quantity", System.Data.SqlDbType.Int);
            command.Parameters["@quantity"].Value = inventoryItem.Quantity;

            command.Parameters.Add("@minQuantity", System.Data.SqlDbType.Int);
            command.Parameters["@minQuantity"].Value = inventoryItem.MinQuantity;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Searches the inventory.
        /// </summary>
        /// <param name="inventoryId">The inventory id.</param>
        /// <returns></returns>
        public InventoryItem SearchInventoryWithInventoryId(int inventoryId)
        {
            var inventoryItem = new InventoryItem();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT purchasePrice, sellingPrice, quantity, defaultQuantity " +
                "FROM Inventory WHERE inventoryID = @inventoryId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@inventoryId", System.Data.SqlDbType.VarChar);
            command.Parameters["@inventoryId"].Value = inventoryId;
            using var reader = command.ExecuteReader();
            
            var purchasePriceOrdinal = reader.GetOrdinal("purchasePrice");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var minQuantityOrdinal = reader.GetOrdinal("defaultQuantity");

            while (reader.Read())
            {
                var minQuantity = reader.GetInt32(minQuantityOrdinal);
                decimal purchasePrice = reader.GetDecimal(purchasePriceOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);

                inventoryItem = new InventoryItem
                {
                    InventoryId = inventoryId,
                    Quantity = quantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    PurchasePrice = decimal.ToDouble(purchasePrice),
                    MinQuantity = minQuantity
                };
            }

            return inventoryItem;
        }

        /// <summary>
        /// Searches the vendor by store id.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<Vendor> GetVendorsWithProductsByStoreId(int storeId)
        {
            var vendors = new List<Vendor>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query =
                "SELECT DISTINCT Vendor.vendorID, vendorName, streetAddress, city, state, zipCode, country, phoneNumber " +
                "FROM Vendor, StoreVendors, Inventory WHERE Vendor.vendorID = StoreVendors.vendorID AND StoreVendors.vendorID = Inventory.VendorID AND Inventory.storeID = @storeId ";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;
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

        public Sale GetSaleDetailsBySaleId(int saleId)
        {
            var inventoryItems = new List<InventoryItem>();
            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT productName, SaleLineItem.quantity, Inventory.productID, " +
                            "Product.productSize, Inventory.sellingPrice, SaleLineItem.discount, " +
                            "Sales.saleDateTime, Sales.total, Sales.tax, Sales.paymentType, storeName " +
                           "FROM Product, Inventory, Sales, Stores, SaleLineItem WHERE SaleLineItem.saleID = Sales.saleID " +
                           "and Inventory.inventoryID = SaleLineItem.inventoryID and Inventory.productID = Product.productID " +
                           "and Sales.saleID = @saleId and Sales.storeID = Stores.storeID";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@saleId", System.Data.SqlDbType.Int);
            command.Parameters["@saleId"].Value = saleId;
            using var reader = command.ExecuteReader();

            var productIdOrdinal = reader.GetOrdinal("productID");
            var productNameOrdinal = reader.GetOrdinal("productName");
            var productSizeOrdinal = reader.GetOrdinal("productSize");
            var sellingPriceOrdinal = reader.GetOrdinal("sellingPrice");
            var quantityOrdinal = reader.GetOrdinal("quantity");
            var discountOrdinal = reader.GetOrdinal("discount");
            var saleDateTimeOrdinal = reader.GetOrdinal("saleDateTime");
            var totalOrdinal = reader.GetOrdinal("total");
            var taxOrdinal = reader.GetOrdinal("tax");
            var paymentTypeOrdinal = reader.GetOrdinal("paymentType");
            var storeNameOrdinal = reader.GetOrdinal("storeName");

            while (reader.Read())
            {
                var name = reader.GetString(productNameOrdinal);
                var discount = reader.IsDBNull(discountOrdinal) ? 0 : reader.GetDecimal(discountOrdinal);
                decimal sellingPrice = reader.GetDecimal(sellingPriceOrdinal);
                var quantity = reader.GetInt32(quantityOrdinal);
                var productId = reader.GetInt32(productIdOrdinal);
                var productSize = reader.GetString(productSizeOrdinal);

                inventoryItems.Add(new InventoryItem
                {
                    Quantity = quantity,
                    SellingPrice = decimal.ToDouble(sellingPrice),
                    Discount = decimal.ToDouble(discount),
                    Item = new Product
                    {
                        Id = productId,
                        Name = name,
                        ProductSize = productSize
                    }

                });
            }

            var saleDateTime = reader.GetDateTime(saleDateTimeOrdinal);
            decimal saleTax = reader.GetDecimal(taxOrdinal);
            var paymentType = reader.GetString(paymentTypeOrdinal);
            decimal total = reader.GetDecimal(totalOrdinal); ;
            var storeName = reader.GetString(storeNameOrdinal);

            var currentSale = new Sale
            {
                SaleDateTime = saleDateTime,
                Tax = decimal.ToDouble(saleTax),
                PaymentType = paymentType,
                Total = decimal.ToDouble(total),
                Items = inventoryItems,
                StoreName = storeName,
            };

            return currentSale;
        }

        public List<Sale> GetRecentSalesByStoreId(int storeId)
        {
            var sales = new List<Sale>();

            using var connection = DbConnection.GetConnection();
            connection.Open();

            string query = "SELECT Sales.saleDateTime, Sales.total, Sales.tax, Sales.paymentType, saleID" +
                           "FROM Sales WHERE Sales.storeID = @storeId ORDER BY saleDateTime DESC";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@storeId", System.Data.SqlDbType.Int);
            command.Parameters["@storeId"].Value = storeId;
            using var reader = command.ExecuteReader();

            var saleIdOrdinal = reader.GetOrdinal("saleID");
            var saleDateTimeOrdinal = reader.GetOrdinal("saleDateTime");
            var totalOrdinal = reader.GetOrdinal("total");
            var taxOrdinal = reader.GetOrdinal("tax");
            var paymentTypeOrdinal = reader.GetOrdinal("paymentType");

            while (reader.Read())
            {
                var saleDateTime = reader.GetDateTime(saleDateTimeOrdinal);
                decimal saleTax = reader.GetDecimal(taxOrdinal);
                var paymentType = reader.GetString(paymentTypeOrdinal);
                decimal total = reader.GetDecimal(totalOrdinal);
                var saleId = reader.GetInt32(saleIdOrdinal);

                sales.Add(new Sale
                {
                    SaleId = saleId,
                    SaleDateTime = saleDateTime,
                    Tax = decimal.ToDouble(saleTax),
                    PaymentType = paymentType,
                    Total = decimal.ToDouble(total),
                });
            }

            return sales;
        }
    }
}
