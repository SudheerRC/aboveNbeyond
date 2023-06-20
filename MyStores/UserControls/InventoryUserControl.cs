using MyStores.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            refreshListView();
            foreach (var ii in _controller.SearchInventoryItem(_storeId))
            {
                FeedListView(ii);
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

            refreshListView();
            foreach (var ii in _controller.SearchProductWithStoreIdAndName(_storeId, inputText))
            {
                FeedListView(ii);
            }
        }
    }
}
