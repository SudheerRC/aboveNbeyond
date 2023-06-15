﻿using MyStores.Dal;
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
    }
}
