using Microsoft.VisualBasic.ApplicationServices;
using MyStores.Model;

namespace MyStores.UserControls.HomeUserControl
{
    public partial class StoreFrontUserControl : UserControl
    {
        private int _storeId;
        private Users _owner;
        public StoreFrontUserControl()
        {
            InitializeComponent();
            hideAllUserControls();
            _owner = new Users();
        }

        public void SetStoreId(int id)
        {
            _storeId = id;
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
            backButton.Visible = false;
            hideAllUserControls();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            backButton.Visible = true;
            backButtonPanel.BringToFront();
            mainAddProductToStoreUserControl.SetStore(_storeId);
            mainAddProductToStoreUserControl.BringToFront();
            mainAddProductToStoreUserControl.Visible = true;
        }

        private void expandPanel()
        {
            storeExpandedPanel.BringToFront();
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
            backButton.Visible = true;
            backButtonPanel.BringToFront();
            mainInventoryUserControl.Visible = true;
        }

        private void AddVendorButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            mainAddVendorToStoreUserControl.BringToFront();
            mainAddVendorToStoreUserControl.SetStore(_storeId);
            mainAddVendorToStoreUserControl.SetOwner(_owner);
            backButton.Visible = true;
            backButtonPanel.BringToFront();
            mainAddVendorToStoreUserControl.Visible = true;
        }

        private void MainAddManagerButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            mainAddManagerUserControl.BringToFront();
            mainAddManagerUserControl.SetStore(_storeId);
            backButton.Visible = true;
            backButtonPanel.BringToFront();
            mainAddManagerUserControl.Visible = true;
        }
    }
}
