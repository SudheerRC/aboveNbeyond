using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class OrderUserControl : UserControl
    {
        private int _storeId;
        private readonly MyStoresController _controller;

        public OrderUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        public void SetStore(int id)
        {
            _storeId = id;
        }

        private void ClearComboBox()
        {
            listPanelComboBox.DataSource = null;
            listPanelComboBox.Items.Clear();
        }

        private void LoadVendorComboBox()
        {
            ClearComboBox();
            List<Vendor> vendorList = _controller.SearchVendorByStoreId(_storeId);
            listPanelComboBox.DataSource = vendorList;
            listPanelComboBox.SelectedIndex.Equals(0);
        }

        private void LoadOrderComboBox()
        {
            ClearComboBox();
            List<Vendor> vendorList = _controller.SearchVendorByStoreId(_storeId);
            listPanelComboBox.DataSource = vendorList;
            listPanelComboBox.SelectedIndex.Equals(0);
        }

        private void LoadProductList()
        {
            var vendor = listPanelComboBox.SelectedItem as Vendor;
            List<InventoryItem> itemList = _controller.SearchInventoryWithVendorId(vendor.Id, _storeId);

            mainFlowLayoutPanel.Controls.Clear();

            foreach (var t in itemList)
            {
                var productTile = new OrderedProductTileUserControl();
                productTile.setInventoryItem(t);
                mainFlowLayoutPanel.Controls.Add(productTile);
            }
        }

        private void SwitchPanels()
        {
            mainPanel.Visible = false;
            listPanel.BringToFront();
            listPanel.Visible = true;
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            finalListPanelButton.Text = @"Place Order";
            panelHeadingLabel.Text = @"Please select a Vendor from this list to place an order";

            LoadVendorComboBox();

            SwitchPanels();
        }

        private void receiveOrderButton_Click(object sender, EventArgs e)
        {
            finalListPanelButton.Text = @"Receive Order";
            panelHeadingLabel.Text = @"Please select an Order from the list below";

            LoadOrderComboBox();

            SwitchPanels();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ResetUserControl();
        }

        public void ResetUserControl()
        {
            mainPanel.BringToFront();
            mainPanel.Visible = true;
            listPanel.Visible = false;

            mainFlowLayoutPanel.Controls.Clear();
        }

        private void finalListPanelButton_Click(object sender, EventArgs e)
        {

        }

        private void OrderUserControl_Load(object sender, EventArgs e)
        {
            ResetUserControl();
        }
    }
}
