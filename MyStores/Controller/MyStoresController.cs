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
        public List<Product> SearchProductWithProductName(String productName)
        {
            return _storesDal.SearchProductWithProductName(productName);
        }

        /// <summary>
        /// Searches the vendors.
        /// </summary>
        /// <param name="vendorName">Name of the vendor.</param>
        /// <returns></returns>
        public List<Vendor> SearchVendorWithVendorName(String vendorName)
        {
            return _storesDal.SearchVendorWithVendorName(vendorName);
        }

        /// <summary>
        /// Searches the product barcode.
        /// </summary>
        /// <param name="productBarcode">The product barcode.</param>
        /// <returns></returns>
        public List<Product> SearchProductWithBarcode(String productBarcode)
        {
            return _storesDal.SearchProductWithBarcode(productBarcode);
        }

        /// <summary>
        /// Searches the store.
        /// </summary>
        /// <param name="storeName">Name of the store.</param>
        /// <returns></returns>
        public List<Store> SearchStoreWithStoreName(String storeName)
        {
            return _storesDal.SearchStoreWithStoreName(storeName);
        }

        /// <summary>
        /// Searches the product with store id and product name
        /// </summary>
        /// <param name="storeId">The store identifier.</param>
        /// <param name="productName">Name of the product.</param>
        /// <returns>List of Inventory Items</returns>
        public List<InventoryItem> SearchProductWithStoreIdAndName(int storeId, String productName)
        {
            return _storesDal.SearchProductWithStoreIdAndName(storeId, productName);
        }

        /// <summary>
        /// Searches the inventory item.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchInventoryItem(int storeId)
        {
            return _storesDal.SearchInventory(storeId);
        }

        /// <summary>
        /// Adds the vendor.
        /// </summary>
        /// <param name="vendor">The vendor.</param>
        public void AddVendor(Vendor vendor)
        {
            _storesDal.AddVendor(vendor);
        }

        /// <summary>
        /// Adds the manager.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="storeId">The store id.</param>
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

        /// <summary>
        /// Searches the vendor by store id.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<Vendor> SearchVendorByStoreId(int storeId)
        {
            return _storesDal.SearchVendorByStoreId(storeId);
        }

        /// <summary>
        /// Gets all vendors.
        /// </summary>
        /// <returns></returns>
        public List<Vendor> GetAllVendors()
        {
            return _storesDal.GetAllVendors();
        }

        /// <summary>
        /// Adds the vendor to store.
        /// </summary>
        /// <param name="vendorId">The vendor id.</param>
        /// <param name="storeId">The store id.</param>
        public void AddVendorToStore(int vendorId, int storeId)
        {
            _storesDal.AddVendorToStore(vendorId, storeId);
        }

        /// <summary>
        /// Adds the inventory.
        /// </summary>
        /// <param name="inventoryItem">The inventory item.</param>
        /// <param name="storeId">The store id.</param>
        public void AddInventory(InventoryItem inventoryItem, int storeId)
        {
            _storesDal.AddInventory(inventoryItem, storeId);
        }

        /// <summary>
        /// Checks the store vendor exists.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="vendorId">The vendor id.</param>
        /// <returns></returns>
        public bool CheckStoreVendorExists(int storeId, int vendorId)
        {
            return _storesDal.CheckStoreVendorExists(storeId, vendorId);
        }

        /// <summary>
        /// Searches the vendors with vendor name
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public List<Vendor> SearchVendorsWithName(string name)
        {
            return _storesDal.SearchVendorsWithName(name);
        }

        /// <summary>
        /// Gets all managers of store.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<Users> GetAllManagersOfStore(int storeId)
        {
            return _storesDal.GetAllManagersOfStore(storeId);
        }

        /// <summary>
        /// Searches the inventory with vendor id.
        /// </summary>
        /// <param name="vendorId">The vendor id.</param>
        /// <param name="storeId">The store id.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchInventoryWithVendorId(int vendorId, int storeId)
        {
            return _storesDal.SearchInventoryWithVendorId(vendorId, storeId);
        }

        /// <summary>
        /// Searches the product with store id and barcode.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="barcode">The barcode.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndBarcode(int storeId, String barcode)
        {
            return _storesDal.SearchProductWithStoreIdAndBarcode(storeId, barcode);
        }

        /// <summary>
        /// Searches the product with store id and description.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="description">The description.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndDescription(int storeId, String description)
        {
            return _storesDal.SearchProductWithStoreIdAndDescription(storeId, description);
        }

        /// <summary>
        /// Searches the product with store id and size.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndSize(int storeId, String size)
        {
            return _storesDal.SearchProductWithStoreIdAndSize(storeId, size);
        }

        /// <summary>
        /// Searches the product with store id and vendor name.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndVendorName(int storeId, String name)
        {
            return _storesDal.SearchProductWithStoreIdAndVendorName(storeId, name);
        }

        /// <summary>
        /// Searches the product with store id and selling price.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="price">The price.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndSellingPrice(int storeId, decimal price)
        {
            return _storesDal.SearchProductWithStoreIdAndSellingPrice(storeId, price);
        }

        /// <summary>
        /// Searches the product with store id and purchase price.
        /// </summary>
        /// <param name="storeId">The store id.</param>
        /// <param name="price">The price.</param>
        /// <returns></returns>
        public List<InventoryItem> SearchProductWithStoreIdAndPurchasePrice(int storeId, decimal price)
        {
            return _storesDal.SearchProductWithStoreIdAndPurchasePrice(storeId, price);
        }
    }
}
