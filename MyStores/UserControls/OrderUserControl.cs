using MyStores.Controller;
using MyStores.Model;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MyStores.UserControls
{
    public partial class OrderUserControl : UserControl
    {
        private int _userId;
        private int _storeId;
        private readonly MyStoresController _controller;
        private double _orderTotal;

        private bool _isPlaceOrder;
        private bool _isReceiveOrder;

        public OrderUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();

            _orderTotal = 0.0;
        }

        public void SetStore(int id)
        {
            _storeId = id;
        }

        public void SetUser(int id)
        {
            _userId = id;
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
            listPanelComboBox.SelectedItem = null;
            mainFlowLayoutPanel.Controls.Clear();
            totalAmountLabel.Text = @"$0.00";
        }

        private void LoadOrderComboBox()
        {
            ClearComboBox();
            List<Order> orderList = _controller.OpenOrdersForStore(_storeId);
            listPanelComboBox.DataSource = orderList;
            listPanelComboBox.SelectedItem = null;
            mainFlowLayoutPanel.Controls.Clear();
            totalAmountLabel.Text = @"$0.00";
        }

        private void LoadProductList()
        {
            if (_isPlaceOrder)
            {
                var vendor = listPanelComboBox.SelectedItem as Vendor;

                if (vendor != null)
                {
                    List<InventoryItem> itemList = _controller.SearchInventoryWithVendorId(vendor.Id, _storeId);

                    mainFlowLayoutPanel.Controls.Clear();

                    LoadFlowPanel(itemList);
                }
            }
            else if (_isReceiveOrder)
            {
                var order = listPanelComboBox.SelectedItem as Order;

                if (order != null)
                {
                    //List<InventoryItem> itemList = _controller.SearchInventoryWithVendorId(vendor.Id, _storeId);

                    //mainFlowLayoutPanel.Controls.Clear();

                    //LoadFlowPanel(itemList);
                }
            }
            
        }

        private void LoadFlowPanel(List<InventoryItem> itemList)
        {
            foreach (var t in itemList)
            {
                var productTile = new OrderedProductTileUserControl();
                productTile.setInventoryItem(t);
                SetControlClickEvents(productTile);

                mainFlowLayoutPanel.Controls.Add(productTile);
            }
        }

        private void SetControlClickEvents(OrderedProductTileUserControl productTile)
        {
            productTile.Controls["removeButton"].Click += new EventHandler(OrderedProductTileUserControl_OnUpdateStatus);
            productTile.Controls["addButton"].Click += new EventHandler(OrderedProductTileUserControl_OnUpdateStatus);
            productTile.Controls["minusButton"].Click += new EventHandler(OrderedProductTileUserControl_OnUpdateStatus);
            productTile.Controls["quantityTextBox"].TextChanged +=
                new EventHandler(OrderedProductTileUserControl_OnUpdateStatus);
            productTile.Controls["priceTextBox"].TextChanged += new EventHandler(OrderedProductTileUserControl_OnUpdateStatus);
        }

        private void CalculateOrderTotal()
        {
            _orderTotal = 0.0;

            for (int i = 0; i < mainFlowLayoutPanel.Controls.Count; i++)
            {
                UserControl newControl = (OrderedProductTileUserControl)mainFlowLayoutPanel.Controls[i];
                var quantity = Convert.ToInt32(newControl.Controls["quantityTextBox"].Text);
                var purchasePrice = Convert.ToDouble(newControl.Controls["priceTextBox"].Text);

                _orderTotal += (quantity * purchasePrice);
            }

            totalAmountLabel.Text = @"$" + _orderTotal.ToString();
        }

        private void OrderedProductTileUserControl_OnUpdateStatus(object sender, EventArgs e)
        {
            CalculateOrderTotal();
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

            _isPlaceOrder = true;
            _isReceiveOrder = false;

            LoadVendorComboBox();

            SwitchPanels();
        }

        private void receiveOrderButton_Click(object sender, EventArgs e)
        {
            finalListPanelButton.Text = @"Receive Order";
            panelHeadingLabel.Text = @"Please select an Order from the list below";

            _isPlaceOrder = false;
            _isReceiveOrder = true;

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
            finalListPanelButton.Enabled = false;
        }

        private void finalListPanelButton_Click(object sender, EventArgs e)
        {
            if (_isPlaceOrder)
            {
                var vendor = listPanelComboBox.SelectedItem as Vendor;
                var newOrder = new Order
                {
                    UserId = _userId,
                    VendorId = vendor.Id,
                    StoreId = _storeId,
                };

                List<InventoryItem> itemList = GetOrderItemList();

                var orderId = _controller.PlaceOrder(newOrder);
                _controller.InsertOrderItems(itemList, orderId);

                MessageBox.Show(@"Order Placed Successfully!");
            }
            else if (_isReceiveOrder)
            {
                List<InventoryItem> itemList = GetOrderItemList();

                _controller.ReceiveOrder(itemList);

                MessageBox.Show(@"Order Received Successfully!\nYour Inventory has been updated!");
            }

            ResetUserControl();
        }

        private List<InventoryItem> GetOrderItemList()
        {
            var itemList = new List<InventoryItem>();

            for (int i = 0; i < mainFlowLayoutPanel.Controls.Count; i++)
            {
                OrderedProductTileUserControl newControl = (OrderedProductTileUserControl)mainFlowLayoutPanel.Controls[i];
                var quantity = Convert.ToInt32(newControl.Controls["quantityTextBox"].Text);
                var purchasePrice = Convert.ToDouble(newControl.Controls["priceTextBox"].Text);
                var item = newControl.getInventoryItem();

                itemList.Add(new InventoryItem
                {
                    InventoryId = item.InventoryId,
                    PurchasePrice = purchasePrice,
                    Quantity = quantity,
                });
            }

            return itemList;
        }

        private void OrderUserControl_Load(object sender, EventArgs e)
        {
            ResetUserControl();
        }

        private void listPanelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductList();
            CalculateOrderTotal();
        }
    }
}
