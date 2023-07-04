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

        private void loadVendorComboBox()
        {
            ClearComboBox();
            List<Vendor> vendorList = _controller.SearchVendorByStoreId(_storeId);
            listPanelComboBox.DataSource = vendorList;
            listPanelComboBox.SelectedIndex.Equals(0);
        }

        private void loadOrderComboBox()
        {
            ClearComboBox();
            List<Vendor> vendorList = _controller.SearchVendorByStoreId(_storeId);
            listPanelComboBox.DataSource = vendorList;
            listPanelComboBox.SelectedIndex.Equals(0);
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            finalListPanelButton.Text = @"Place Order";
            panelHeadingLabel.Text = @"Please select a Vendor from this list to place an order";

            SwitchPanels();
        }

        private void SwitchPanels()
        {
            mainPanel.Visible = false;
            listPanel.Visible = true;
        }

        private void receiveOrderButton_Click(object sender, EventArgs e)
        {
            finalListPanelButton.Text = @"Receive Order";
            panelHeadingLabel.Text = @"Please select an Order from the list below";

            SwitchPanels();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void finalListPanelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
