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

            messageLabel.Text = @"The above are vendors you have added to this store. If you don't find the vendor " +
                                @"you are looking for, consider adding them to your list by clicking the link below";
        }

        public void SetStore(int id)
        {
            _storeId = id;
        }

        private void hideAllPanels()
        {
            vendorPanel.Visible = false;
            pricePanel.Visible = false;
            productLookUpPanel.Visible = false;
        }

        private void loadVendorComboBox()
        {
            vendorComboBox.DataSource = null;
            vendorComboBox.Items.Clear();
            List<Vendor> vendorList = _controller.SearchVendorByStoreId(_storeId);
            vendorComboBox.DataSource = vendorList;
            vendorComboBox.SelectedIndex.Equals(0);
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
            if (vendorPanel.Visible)
            {
                hideAllPanels();
                productLookUpPanel.BringToFront();
                productLookUpPanel.Visible = true;
                previousButton.Enabled = true;
                nextButton.Enabled = false;
            }
            else if (productLookUpPanel.Visible)
            {
                hideAllPanels();
                pricePanel.BringToFront();
                pricePanel.Visible = true;
                nextButton.Enabled = false;
                addButton.Enabled = true;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (pricePanel.Visible)
            {
                hideAllPanels();
                productLookUpPanel.BringToFront();
                productLookUpPanel.Visible = true;
                nextButton.Visible = true;
                addButton.Enabled = false;

            }
            else if (productLookUpPanel.Visible)
            {
                hideAllPanels();
                vendorPanel.BringToFront();
                vendorPanel.Visible = true;
                nextButton.Enabled = true;
                previousButton.Enabled = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var selectedVendor = vendorComboBox.SelectedItem as Vendor;
            var selectedProduct = inventoryListView.SelectedItems;
            var inventoryItem = new InventoryItem();

            var currentVendorId = selectedVendor.Id;
            var currentProductId = Convert.ToInt32(selectedProduct[0].Text);
            var currentSellingPrice = Convert.ToDouble(sellingPriceTextBox.Text);
            var purchasePrice = Convert.ToDouble(purchasePriceTextBox.Text);
            var quantity = Convert.ToInt32(quantityTextBox.Text);

            try
            {
                if (!ValidateFields())
                {
                    purchasePriceErrorLabel.Visible = false;
                    sellingPriceErrorLabel.Visible = false;
                    quantityErrorLabel.Visible = false;

                    inventoryItem.VendorId = currentVendorId;
                    inventoryItem.Item = new Product
                    {
                        Id = currentProductId
                    };
                    inventoryItem.PurchasePrice = purchasePrice;
                    inventoryItem.SellingPrice = currentSellingPrice;
                    inventoryItem.Quantity = quantity;

                    _controller.AddInventory(inventoryItem, _storeId);
                    MessageBox.Show(@"Successfully added the product to your inventory!");

                    resetControl();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Please clear the errors and try again to add.");
            }
        }

        private void resetControl()
        {
            addButton.Enabled = false;
            previousButton.Enabled = false;
            nextButton.Enabled = true;

            inventoryListView.Items.Clear();
            searchTextBox.Text = "";

            hideAllPanels();
            vendorPanel.BringToFront();
            vendorPanel.Visible = true;
            loadVendorComboBox();
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

        private bool ValidateFields()
        {
            bool result = false;
            double price;
            int quantity;
            if (string.IsNullOrEmpty(purchasePriceTextBox.Text))
            {
                purchasePriceErrorLabel.Text = @"Purchase price cannot be empty";
                purchasePriceErrorLabel.Visible = true;
                result = true;
            }

            if (string.IsNullOrEmpty(sellingPriceTextBox.Text))
            {
                sellingPriceErrorLabel.Text = @"Product's selling price cannot be empty";
                sellingPriceErrorLabel.Visible = true;
                result = true;
            }

            if (string.IsNullOrEmpty(quantityTextBox.Text))
            {
                quantityErrorLabel.Text = @"Quantity cannot be empty";
                quantityErrorLabel.Visible = true;
                result = true;
            }

            if (!double.TryParse(purchasePriceTextBox.Text, out price))
            {
                purchasePriceErrorLabel.Text = @"Product's purchase price must be a valid number";
                purchasePriceErrorLabel.Visible = true;
                result = true;
            }

            if (!double.TryParse(sellingPriceTextBox.Text, out price))
            {
                sellingPriceErrorLabel.Text = @"Product's selling price must be a valid number";
                sellingPriceErrorLabel.Visible = true;
                result = true;
            }

            if (!int.TryParse(quantityTextBox.Text, out quantity))
            {
                quantityErrorLabel.Text = @"Quantity must be a valid number";
                quantityErrorLabel.Visible = true;
                result = true;
            }

            return result;
        }

        private void addVendorToStoreButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void purchasePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            purchasePriceErrorLabel.Visible = false;
        }

        private void sellingPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            sellingPriceErrorLabel.Visible = false;
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            quantityErrorLabel.Visible = false;
        }

        private void AddProductToStoreUserControl_Load(object sender, EventArgs e)
        {
            resetControl();
            setPanelParents();
        }

        private void setPanelParents()
        {
            vendorPanel.Parent = this;
            pricePanel.Parent = this;
            productLookUpPanel.Parent = this;
        }

        private void inventoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
        }
    }
}
