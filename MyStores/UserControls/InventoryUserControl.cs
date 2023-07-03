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
            criteriaComboBox.SelectedItem = "Product Name";
            searchTextBox.Clear();
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
                currentProduct.Barcode, currentProduct.Name, currentProduct.Description, currentProduct.ProductSize,
                Convert.ToString(ii.SellingPrice), Convert.ToString(ii.PurchasePrice), myVendorName, Convert.ToString(ii.Quantity), "", ""
            };
            var listItem = new ListViewItem(row);
            inventoryListView.Items.Add(listItem);
        }

        private void InventoryUserControl_Load(object sender, EventArgs e)
        {
            loadListView();
            criteriaComboBox.SelectedItem = "Product Name";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<InventoryItem> inventoryItems = GetInventoryItems();
            if (inventoryItems.Count > 0)
            {
                refreshListView();
                foreach (var ii in inventoryItems)
                {
                    FeedListView(ii);
                }
                searchTextBox.Clear();
                criteriaComboBox.SelectedItem = "Product Name";
            }
            else
            {
                MessageBox.Show(@"There are no products with your search input. Please try again!");
                searchTextBox.Clear();
                criteriaComboBox.SelectedItem = "Product Name";
                refreshListView();
            }
        }

        private List<InventoryItem> GetInventoryItems()
        {
            decimal price;
            var inputText = searchTextBox.Text;
            List<InventoryItem> inventoryItems = new List<InventoryItem>();
            if (criteriaComboBox.SelectedItem.Equals("Product Name"))
            {
                inventoryItems = _controller.SearchProductWithStoreIdAndName(_storeId, inputText);
            }
            else if (criteriaComboBox.SelectedItem.Equals("Description"))
            {
                inventoryItems = _controller.SearchProductWithStoreIdAndDescription(_storeId, inputText);
            }
            else if (criteriaComboBox.SelectedItem.Equals("Barcode"))
            {
                inventoryItems = _controller.SearchProductWithStoreIdAndBarcode(_storeId, inputText);
            }
            else if (criteriaComboBox.SelectedItem.Equals("Product Size"))
            {
                inventoryItems = _controller.SearchProductWithStoreIdAndSize(_storeId, inputText);
            }
            else if (criteriaComboBox.SelectedItem.Equals("Vendor Name"))
            {
                inventoryItems = _controller.SearchProductWithStoreIdAndVendorName(_storeId, inputText);
            }
            else if (criteriaComboBox.SelectedItem.Equals("Selling Price") && decimal.TryParse(inputText, out price))
            {
                decimal sPrice = Convert.ToDecimal(inputText);
                inventoryItems = _controller.SearchProductWithStoreIdAndSellingPrice(_storeId, sPrice);
            }
            else if (criteriaComboBox.SelectedItem.Equals("Purchase Price") && decimal.TryParse(inputText, out price))
            {
                decimal pPrice = Convert.ToDecimal(inputText);
                inventoryItems = _controller.SearchProductWithStoreIdAndPurchasePrice(_storeId, pPrice);
            }

            return inventoryItems;
        }

        private void refreshListButton_Click(object sender, EventArgs e)
        {
            loadListView();
            criteriaComboBox.SelectedItem = "Product Name";
        }

        private void criteriaComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (criteriaComboBox.SelectedItem.Equals("Product Name"))
            {
                searchTextBox.PlaceholderText = "Search for product based on Product Name";
            }
            else if (criteriaComboBox.SelectedItem.Equals("Description"))
            {
                searchTextBox.PlaceholderText = "Search for product based on Product's Description";
            }
            else if (criteriaComboBox.SelectedItem.Equals("Barcode"))
            {
                searchTextBox.PlaceholderText = "Search for product based on Product's Barcode";
            }
            else if (criteriaComboBox.SelectedItem.Equals("Product Size"))
            {
                searchTextBox.PlaceholderText = "Search for product based on Product's Size";
            }
            else if (criteriaComboBox.SelectedItem.Equals("Vendor Name"))
            {
                searchTextBox.PlaceholderText = "Search for product based on Vendor name";
            }
            else if (criteriaComboBox.SelectedItem.Equals("Selling Price"))
            {
                searchTextBox.PlaceholderText = "Search for product based on Selling Price";
            }
            else if (criteriaComboBox.SelectedItem.Equals("Purchase Price"))
            {
                searchTextBox.PlaceholderText = "Search for product based on Purchase Price";
            }
            else
            {
                searchTextBox.PlaceholderText = "Please select a criteria to Search for product based on";
            }
        }
    }
}
