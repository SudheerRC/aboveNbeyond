using Microsoft.VisualBasic.ApplicationServices;
using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls.HomeUserControl
{
    public partial class StoreFrontUserControl : UserControl
    {
        private int _storeId;
        private Users _owner;
        private readonly MyStoresController _controller;

        public StoreFrontUserControl()
        {
            InitializeComponent();
            hideAllUserControls();
            _owner = new Users();
            _controller = new MyStoresController();
        }

        public void SetStoreId(int id)
        {
            _storeId = id;
            var fullName = _controller.GetStoreName(_storeId);
            storeNameLabel.Text = fullName;
        }

        public void SetOwner(Users setUser)
        {
            _owner = setUser;
        }

        private void hideAllUserControls()
        {
            mainAddProductToStoreUserControl.Visible = false;
            mainInventoryUserControl.Visible = false;
            mainAddVendorToStoreUserControl.Visible = false;
            mainAddManagerUserControl.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            storeExpandedPanel.Visible = false;
            backButtonPanel.Visible = false;
            hideAllUserControls();
            storeButtonsPanel.Visible = true;
            mainAddVendorToStoreUserControl.refreshListView();
            mainInventoryUserControl.refreshListView();
            mainAddProductToStoreUserControl.resetControl();
            mainAddManagerUserControl.clearControl();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            backButtonPanel.Visible = true;
            backButtonPanel.BringToFront();

            mainAddProductToStoreUserControl.SetStore(_storeId);
            mainAddProductToStoreUserControl.BringToFront();
            mainAddProductToStoreUserControl.Visible = true;
        }

        private void expandPanel()
        {
            storeExpandedPanel.BringToFront();
            storeButtonsPanel.Visible = false;
            storeExpandedPanel.Visible = true;
        }

        private void exitStoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Show();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            mainInventoryUserControl.BringToFront();
            mainInventoryUserControl.SetStore(_storeId);
            mainInventoryUserControl.loadListView();
            mainInventoryUserControl.Visible = true;
            backButtonPanel.BringToFront();
            backButtonPanel.Visible = true;
        }

        private void AddVendorButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            mainAddVendorToStoreUserControl.BringToFront();
            mainAddVendorToStoreUserControl.SetStore(_storeId);
            mainAddVendorToStoreUserControl.SetOwner(_owner);
            mainAddVendorToStoreUserControl.AddVendorToStoreUserControl_Load(sender, e);
            mainAddVendorToStoreUserControl.Visible = true;
            backButtonPanel.BringToFront();
            backButtonPanel.Visible = true;
        }

        private void MainAddManagerButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            mainAddManagerUserControl.BringToFront();
            mainAddManagerUserControl.SetStore(_storeId);
            backButtonPanel.Visible = true;
            backButtonPanel.BringToFront();
            mainAddManagerUserControl.Visible = true;
        }

        private void StoreFrontUserControl_Load(object sender, EventArgs e)
        {
            backButtonPanel.Visible = false;
            mainInventoryUserControl.SetStore(_storeId);

            mainAddVendorToStoreUserControl.SetStore(_storeId);
            mainAddVendorToStoreUserControl.SetOwner(_owner);

            mainAddManagerUserControl.SetStore(_storeId);

            mainAddProductToStoreUserControl.SetStore(_storeId);
        }
    }
}
