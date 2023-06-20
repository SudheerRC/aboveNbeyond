using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class AddProductToStoreUserControl : UserControl
    {
        private int _storeId;
        private readonly MyStoresController _controller;
        public AddProductToStoreUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
            loadVendorComboBox();
        }

        public void SetStore(int id)
        {
            _storeId = id;
        }

        private void hideAllPanels()
        {
            vendorInfoPanel.Visible = false;
            pricePanel.Visible = false;
            productLookUpPanel.Visible = false;
        }

        private void loadVendorComboBox()
        {
            vendorComboBox.Items.Clear();
            vendorComboBox.DisplayMember = "Name";
            vendorComboBox.ValueMember = "Id";
            vendorComboBox.DataSource = _controller.SearchVendorByStoreId(_storeId);
            vendorComboBox.SelectedIndex = 0;
        }

        public void refreshListView()
        {
            inventoryListView.Items.Clear();
        }

        private void loadListView(String searchTerm)
        {
            refreshListView();
            if (_controller.SearchProduct(searchTerm).Count == 0)
            {
                MessageBox.Show(@"There are no products with your search input. Please try again!");
            }
            else
            {
                foreach (var currentProduct in _controller.SearchProduct(searchTerm))
                {
                    FeedListView(currentProduct);
                }
            }
        }

        private void FeedListView(Product currentProduct)
        {
            string[] row =
            {
                Convert.ToString(currentProduct.Id), currentProduct.Barcode, currentProduct.Name, currentProduct.Description, currentProduct.ProductSize, Convert.ToString(currentProduct.SellingPrice)
            };
            var listItem = new ListViewItem(row);
            inventoryListView.Items.Add(listItem);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (vendorInfoPanel.Visible)
            {
                hideAllPanels();
                productLookUpPanel.Visible = true;
                previousButton.Visible = true;

            }
            else if (productLookUpPanel.Visible)
            {
                hideAllPanels();
                pricePanel.Visible = true;
                nextButton.Enabled = false;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (pricePanel.Visible)
            {
                hideAllPanels();
                productLookUpPanel.Visible = true;
                nextButton.Visible = true;
                addButton.Enabled = false;

            }
            else if (productLookUpPanel.Visible)
            {
                hideAllPanels();
                vendorInfoPanel.Visible = true;
                nextButton.Enabled = true;
                previousButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var selectedVendor = vendorComboBox.SelectedItem as Vendor;
            var selectedProduct = inventoryListView.SelectedItems;

            var currentVendorId = selectedVendor.Id;
            var currentProductId = Convert.ToInt32(selectedProduct[0].Text);
            var currentSellingPrice = Convert.ToDouble(sellingPriceTextBox.Text);
            var purchasePrice = Convert.ToDouble(purchasePriceTextBox.Text);
            var quantity = Convert.ToInt32(quantityTextBox.Text);

            var inventoryItem = new InventoryItem
            {
                VendorId = currentVendorId,
                Item = new Product
                {
                    Id = currentProductId
                },
                PurchasePrice = purchasePrice,
                SellingPrice = currentSellingPrice,
                Quantity = quantity
            };

            _controller.AddInventory(inventoryItem, _storeId);
            MessageBox.Show(@"Successfully added the product to your inventory!");

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchTerm = searchTextBox.Text;
            if (!string.IsNullOrEmpty(searchTerm))
            {
                searchTerm = searchTerm.Trim();
                loadListView(searchTerm);
            }
            else
            {
                MessageBox.Show(@"Please enter a valid text or number in the search field.");
            }
        }
    }
}
