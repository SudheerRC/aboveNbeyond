using MyStores.Dal;
using MyStores.Model;

namespace MyStores.Controller
{
    public class MyStoresController
    {
        private readonly MyStoresDal _storesDal;

        public MyStoresController()
        {
            _storesDal = new MyStoresDal();
        }

        public bool CheckUserLogin(Users user)
        {
            return _storesDal.CheckUserLogin(user);
        }

        public bool CheckEmail(string email)
        {
            return _storesDal.CheckEmail(email);
        }

        public void RegisterUser(Users newUser)
        {
            _storesDal.RegisterUser(newUser);
        }

        public void AddStore(Store newStore)
        {
            _storesDal.AddStore(newStore);
        }

        public List<Store> GetUserStores(int userId)
        {
            return _storesDal.GetUserStores(userId);
        }

        public int GetUserId(string email)
        {
            return _storesDal.GetUserId(email);
        }

        public void AddProduct(Product product)
        {
            _storesDal.AddProduct(product);
        }
    }
}
