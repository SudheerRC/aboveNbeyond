using MyStores.Controller;
using MyStores.Model;

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

        private bool LoadVendorComboBox()
        {
            ClearComboBox();
            List<Vendor> vendorList = _controller.GetVendorsWithProductsByStoreId(_storeId);
            if (vendorList.Count == 0)
            {
                MessageBox.Show("There are no Vendors added or there are no products that your vendors sell to this store." +
                    Environment.NewLine + "Please add one or more vendors and add the products that they sell to place an order with them");
                return false;
            }
            listPanelComboBox.DataSource = vendorList;
            listPanelComboBox.SelectedItem = null;
            mainFlowLayoutPanel.Controls.Clear();
            totalAmountLabel.Text = @"$0.00";

            return true;
        }

        private bool LoadOrderComboBox()
        {
            ClearComboBox();
            List<Order> orderList = _controller.OpenOrdersForStore(_storeId);
            if (orderList.Count == 0)
            {
                MessageBox.Show("There are no upcoming orders being delivered!" +
                    Environment.NewLine + "Please place an order");
                return false;
            }
            listPanelComboBox.DataSource = orderList;
            listPanelComboBox.SelectedItem = null;
            mainFlowLayoutPanel.Controls.Clear();
            totalAmountLabel.Text = @"$0.00";

            return true;
        }

        private bool LoadProductList()
        {
            if (_isPlaceOrder)
            {
                var vendor = listPanelComboBox.SelectedItem as Vendor;

                if (vendor != null)
                {
                    List<InventoryItem> itemList = _controller.SearchInventoryWithVendorId(vendor.Id, _storeId);

                    if (itemList.Count == 0)
                    {
                        MessageBox.Show("The selected vendor does not sell any product to you!" +
                            Environment.NewLine + "Please add products to this store with this vendor to place an order");
                        return false;
                    }

                    mainFlowLayoutPanel.Controls.Clear();

                    LoadFlowPanel(itemList);

                    return true;
                }
            }
            else if (_isReceiveOrder)
            {
                var order = listPanelComboBox.SelectedItem as Order;

                if (order != null)
                {
                    List<InventoryItem> itemList = _controller.SearchInventoryWithOrderId(order.OrderId);

                    mainFlowLayoutPanel.Controls.Clear();

                    LoadFlowPanel(itemList);

                    return true;
                }
            }

            return false;
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

            try
            {
                for (int i = 0; i < mainFlowLayoutPanel.Controls.Count; i++)
                {
                    UserControl newControl = (OrderedProductTileUserControl)mainFlowLayoutPanel.Controls[i];
                    var quantity = Convert.ToInt32(newControl.Controls["quantityTextBox"].Text);
                    var purchasePrice = Convert.ToDouble(newControl.Controls["priceTextBox"].Text);

                    _orderTotal += (quantity * purchasePrice);
                }
            }
            catch
            {
                MessageBox.Show("Quantity and Price must be a valid positive number");
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
            if (LoadVendorComboBox())
            {
                finalListPanelButton.Text = @"Place Order";
                panelHeadingLabel.Text = @"Please select a Vendor from this list to place an order";

                _isPlaceOrder = true;
                _isReceiveOrder = false;

                SwitchPanels();
            }
        }

        private void receiveOrderButton_Click(object sender, EventArgs e)
        {
            if (LoadOrderComboBox())
            {
                finalListPanelButton.Text = @"Receive Order";
                panelHeadingLabel.Text = @"Please select an Order from the list below";

                _isPlaceOrder = false;
                _isReceiveOrder = true;

                SwitchPanels();
            }
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
            var item = listPanelComboBox.SelectedItem;
            if (item != null)
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

                    ResetUserControl();
                    MessageBox.Show(@"Order Placed Successfully!");
                }
                else if (_isReceiveOrder)
                {
                    var order = listPanelComboBox.SelectedItem as Order;

                    List<InventoryItem> itemList = GetOrderItemList();

                    _controller.ReceiveOrder(itemList, order.OrderId);

                    ResetUserControl();
                    MessageBox.Show(@"Order Received Successfully!" + Environment.NewLine + "Your Inventory has been updated!");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the drop down list!");
            }
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
            if (!LoadProductList())
            {
                mainFlowLayoutPanel.Controls.Clear();
                totalAmountLabel.Text = "$0.00";
            }
            CalculateOrderTotal();
        }
    }
}
