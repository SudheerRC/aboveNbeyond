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
        }

        public void SetStore(int id)
        {
            _storeId = id;
        }

        public void refreshListView()
        {
            inventoryListView.Items.Clear();
            inventoryListView.Refresh();
        }

        public void loadListView()
        {
            refreshListView();
            List<InventoryItem> inventoryItems = _controller.SearchInventoryItem(_storeId);
            if (inventoryItems.Count > 0)
            {
                foreach (var ii in inventoryItems)
                {
                    FeedListView(ii);
                }
            }
            inventoryListView.Refresh();
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

        private void InventoryUserControl_Load(object sender, EventArgs e)
        {
            loadListView();
        }

        private void searchButton_Click(object sender, EventArgs e)
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
                searchTextBox.Clear();
            }
            else
            {
                MessageBox.Show(@"There are no products with your search input. Please try again!");
                searchTextBox.Clear();
                refreshListView();
            }
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            loadListView();
        }
    }
}
