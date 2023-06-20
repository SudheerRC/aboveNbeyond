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
        /// Adds the vendor.
        /// </summary>
        /// <param name="vendor">The vendor.</param>
        public List<Product> SearchProductWithStoreIdAndName(int storeId, String productName)
        {
            return _storesDal.SearchProductWithStoreIdAndName(storeId, productName);
        }

        public void AddVendor(Vendor vendor)
        {
            _storesDal.AddVendor(vendor);
        }

        public void AddManager(int userId, int storeId)
        {
            _storesDal.AddManager(userId, storeId);
        }
    }
}
