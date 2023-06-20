using MyStores.Dal;
using MyStores.Model;

namespace MyStores.Controller
{
    /// <summary>
    /// This class is used to connect DAL and view
    /// </summary>
    public class MyStoresController
    {
        private readonly MyStoresDal _storesDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyStoresController"/> class.
        /// </summary>
        public MyStoresController()
        {
            _storesDal = new MyStoresDal();
        }

        /// <summary>
        /// Checks the user login.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public bool CheckUserLogin(Users user)
        {
            return _storesDal.CheckUserLogin(user);
        }

        /// <summary>
        /// Checks if the email exists.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool CheckEmail(string email)
        {
            return _storesDal.CheckEmail(email);
        }

        /// <summary>
        /// Registers the user.
        /// </summary>
        /// <param name="newUser">The new user.</param>
        public void RegisterUser(Users newUser)
        {
            _storesDal.RegisterUser(newUser);
        }

        /// <summary>
        /// Adds the store.
        /// </summary>
        /// <param name="newStore">The new store.</param>
        public void AddStore(Store newStore)
        {
            _storesDal.AddStore(newStore);
        }

        /// <summary>
        /// Gets the user stores.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        public List<Store> GetUserStores(int userId)
        {
            return _storesDal.GetUserStores(userId);
        }

        /// <summary>
        /// Gets the user id.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public int GetUserId(string email)
        {
            return _storesDal.GetUserId(email);
        }

        /// <summary>
        /// Adds the product.
        /// </summary>
        /// <param name="product">The product.</param>
        public void AddProduct(Product product)
        {
            _storesDal.AddProduct(product);
        }

        /// <summary>
        /// Searches the product.
        /// </summary>
        /// <param name="productName">Name of the product.</param>
        /// <returns></returns>
        public List<Product> SearchProduct(String productName)
        {
            return _storesDal.SearchProduct(productName);
        }

        /// <summary>
        /// Searches the vendors.
        /// </summary>
        /// <param name="vendorName">Name of the vendor.</param>
        /// <returns></returns>
        public List<Vendor> SearchVendors(String vendorName)
        {
            return _storesDal.SearchVendor(vendorName);
        }

        /// <summary>
        /// Searches the product barcode.
        /// </summary>
        /// <param name="productBarcode">The product barcode.</param>
        /// <returns></returns>
        public List<Product> SearchProductBarcode(String productBarcode)
        {
            return _storesDal.SearchProductBarcode(productBarcode);
        }

        /// <summary>
        /// Searches the store.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <returns></returns>
        public List<Store> SearchStore(String storeName)
        {
            return _storesDal.SearchStore(storeName);
        }

        /// <summary>
        /// Searches the name of the product with store identifier and.
        /// </summary>
        /// <param name="storeId">The store identifier.</param>
        /// <param name="productName">Name of the product.</param>
        /// <returns>List of Inventory Items</returns>
        public List<InventoryItem> SearchProductWithStoreIdAndName(int storeId, String productName)
        {
            return _storesDal.SearchProductWithStoreIdAndName(storeId, productName);
        }

        public List<InventoryItem> SearchInventoryItem(int storeId)
        {
            return _storesDal.SearchInventory(storeId);
        }

        public void AddVendor(Vendor vendor)
        {
            _storesDal.AddVendor(vendor);
        }

        public void AddManager(int userId, int storeId)
        {
            _storesDal.AddManager(userId, storeId);
        }

        /// <summary>
        /// Gives the name of the Vendor by the given vendor Id.
        /// </summary>
        /// <param name="vendorId">Vendor Id.</param>
        /// <returns>Name of the vendor</returns>
        public string NameOfVendorWithId(int vendorId)
        {
            return _storesDal.NameOfVendorWithId(vendorId);
        }

        /// <summary>
        /// Searches the product.
        /// </summary>
        /// <param name="productId">Id of the product.</param>
        /// <returns>Product object</returns>
        public Product SearchProductWithId(int productId)
        {
            return _storesDal.SearchProductWithId(productId);
        }

        /// <summary>
        /// Gets the name of the store.
        /// </summary>
        /// <param name="id">The store id.</param>
        /// <returns></returns>
        public string GetStoreName(int id)
        {
            return _storesDal.GetStoreName(id);
        }

        public List<Vendor> SearchVendorByStoreId(int storeId)
        {
            return _storesDal.SearchVendorByStoreId(storeId);
        }

        public List<Vendor> GetAllVendors()
        {
            return _storesDal.GetAllVendors();
        }

        public void AddVendorToStore(int vendorId, int storeId)
        {
            _storesDal.AddVendorToStore(vendorId, storeId);
        }

        public void AddInventory(InventoryItem inventoryItem, int storeId)
        {
            _storesDal.AddInventory(inventoryItem, storeId);
        }

        public bool CheckStoreVendorExists(int storeId, int vendorId)
        {
           return _storesDal.CheckStoreVendorExists(storeId, vendorId);
        }

        public List<Vendor> SearchVendorsWithName(string name)
        {
            return _storesDal.SearchVendorsWithName(name);
        }
    }
}
