﻿using MyStores.Controller;
using MyStores.Model;
using MyStores.View;

namespace MyStores.UserControls.HomeUserControl
{
    public partial class HomeTabUserControl : UserControl
    {
        private Users _owner;
        private readonly MyStoresController _controller;

        public HomeTabUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
            _owner = new Users();
            loadHome();
        }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
        }

        private void loadHome()
        {
            homeFlowLayoutPanel.Controls.Clear();

            StoreChipUserControl[] homeChips = new StoreChipUserControl[99];

            List<Store> storeList = _controller.GetUserStores(_owner.UserId);

            homeFlowLayoutPanel.Controls.Add(AddStoreButton);

            for (int i = 0; i < storeList.Count; i++)
            {
                homeChips[i] = new StoreChipUserControl();

                var managersNames = "Not Assigned";
                List<Users> managers = storeList[i].Managers;
                managersNames = ManagersNames(managers, managersNames);

                homeChips[i].StoreName = storeList[i].Name;
                homeChips[i].City = storeList[i].City;
                homeChips[i].Managers = managersNames;

                homeFlowLayoutPanel.Controls.Add(homeChips[i]);
            }
        }

        private static string ManagersNames(List<Users>? managers, string managersNames)
        {
            if (managers != null && managers.Count == 1)
            {
                managersNames = managers[0].FirstName + " " + managers[0].LastName;
            }
            else if (managers != null)
            {
                for (int i = 1; i < managers.Count; i++)
                {
                    managersNames += ", " + managers[i].FirstName + " " + managers[i].LastName;
                }
            }

            return managersNames;
        }

        private void HomeTabUserControl_Load(object sender, EventArgs e)
        {
            loadHome();
        }

        private void AddStoreButton_Click(object sender, EventArgs e)
        {
            using var addStore = new AddStoreForm();
            addStore.SetOwner(_owner);
            addStore.ShowDialog();
            loadHome();
        }
    }
}