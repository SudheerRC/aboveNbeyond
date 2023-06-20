namespace MyStores.UserControls.HomeUserControl
{
    public partial class StoreFrontUserControl : UserControl
    {
        private int _storeId;
        public StoreFrontUserControl()
        {
            InitializeComponent();
            hideAllUserControls();
        }

        public void SetStoreId(int id)
        {
            _storeId = id;
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
