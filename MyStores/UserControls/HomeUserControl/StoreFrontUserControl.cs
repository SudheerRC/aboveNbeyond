namespace MyStores.UserControls.HomeUserControl
{
    public partial class StoreFrontUserControl : UserControl
    {
        public StoreFrontUserControl()
        {
            InitializeComponent();
        }

        private void hideAllUserControls()
        {
            mainAddProductUserControl.Visible = false;
            mainInventoryUserControl.Visible = false;
            mainAddVendorUserControl.Visible = false;
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
            this.Visible = false;
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
    }
}
