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
            mainAddProductUserControl.Visible = false;
            mainInventoryUserControl.Visible = false;
            mainAddVendorUserControl.Visible = false;
            mainAddManagerUserControl.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            storeExpandedPanel.Visible = false;
            hideAllUserControls();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            mainAddProductUserControl.Visible = true;
        }

        private void expandPanel()
        {
            storeExpandedPanel.BringToFront();
            storeExpandedPanel.Visible = true;
        }

        private void exitStoreButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            mainInventoryUserControl.BringToFront();
            backButtonPanel.BringToFront();
            mainInventoryUserControl.Visible = true;
        }

        private void AddVendorButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            mainAddVendorUserControl.BringToFront();
            backButtonPanel.BringToFront();
            mainAddVendorUserControl.Visible = true;
        }

        private void MainAddManagerButton_Click(object sender, EventArgs e)
        {
            expandPanel();
            mainAddManagerUserControl.BringToFront();
            mainAddManagerUserControl.SetStore(_storeId);
            backButtonPanel.BringToFront();
            mainAddManagerUserControl.Visible = true;
        }
    }
}
