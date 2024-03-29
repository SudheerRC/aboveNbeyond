﻿using MyStores.Controller;
using MyStores.Model;
using MyStores.View;

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
            deleteProductButton.Enabled = false;
            editButton.Enabled = false;
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
            //inventoryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            inventoryListView.Columns[9].Width = 0;

            var vendorId = ii.VendorId;
            var myVendorName = _controller.NameOfVendorWithId(vendorId);
            var currentProduct = _controller.SearchProductWithId(ii.Item.Id);
            string[] row =
            {
                currentProduct.Barcode, currentProduct.Name, currentProduct.Description, Convert.ToString(ii.Quantity),
                currentProduct.ProductSize, Convert.ToString(ii.SellingPrice), Convert.ToString(ii.PurchasePrice),
                Convert.ToString(ii.MinQuantity), myVendorName, Convert.ToString(ii.InventoryId)
            };
            var listItem = new ListViewItem(row);
            inventoryListView.Items.Add(listItem);
        }

        private void InventoryUserControl_Load(object sender, EventArgs e)
        {
            loadListView();
            criteriaComboBox.SelectedItem = "Product Name";
            inventoryListView.Scrollable = true;
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

        private void InventoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteProductButton.Enabled = true;
            editButton.Enabled = true;
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItem = inventoryListView.SelectedItems;
            int inventoryId = Convert.ToInt32(selectedItem[0].SubItems[9].Text);

            DialogResult result = MessageBox.Show("Are you sure to delete the selected product from store?", "Confirm Product Deletion",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _controller.DeleteProductFromStore(inventoryId);
                refreshListButton_Click(sender, e);
            }
            else
            {
                refreshListButton_Click(sender, e);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItem = inventoryListView.SelectedItems;
            int inventoryId = Convert.ToInt32(selectedItem[0].SubItems[9].Text);

            var editForm = new EditInventoryItemForm();
            editForm.SetInventoryId(inventoryId);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                editForm.Close();
            }
            refreshListButton_Click(sender, e);
        }
    }
}
