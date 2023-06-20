using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class InventoryUserControl : UserControl
    {
        private int _storeId;
        private readonly MyStoresController _controller;
        public InventoryUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
            loadListView();
        }

        public void SetStore(int id)
        {
            _storeId = id;
        }

        public void refreshListView()
        {
            inventoryListView.Items.Clear();
        }

        private void loadListView()
        {
            List<InventoryItem> inventoryItems = _controller.SearchInventoryItem(_storeId);
            if (inventoryItems.Count > 0)
            {
                refreshListView();
                foreach (var ii in inventoryItems)
                {
                    FeedListView(ii);
                }
            }
        }

        private void FeedListView(InventoryItem ii)
        {
            var vendorId = ii.VendorId;
            var myVendorName = _controller.NameOfVendorWithId(vendorId);
            var currentProduct = _controller.SearchProductWithId(ii.Item.Id);
            string[] row =
            {
                currentProduct.Barcode, currentProduct.Name, currentProduct.Description, currentProduct.ProductSize, Convert.ToString(ii.SellingPrice),
                Convert.ToString(ii.PurchasePrice), myVendorName, Convert.ToString(ii.Quantity), "", ""
            };
            var listItem = new ListViewItem(row);
            inventoryListView.Items.Add(listItem);
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            var inputText = searchTextBox.Text;

            List<InventoryItem> inventoryItems = _controller.SearchProductWithStoreIdAndName(_storeId, inputText);
            if (inventoryItems.Count > 0)
            {
                refreshListView();
                foreach (var ii in inventoryItems)
                {
                    FeedListView(ii);
                }
            }
        }
    }
}
