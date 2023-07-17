using MyStores.Controller;
using MyStores.Model;

namespace MyStores.View
{
    public partial class EditInventoryItemForm : Form
    {
        private int _inventoryId;
        private readonly MyStoresController _controller;
        public EditInventoryItemForm()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        public void SetInventoryId(int inventoryId)
        {
            _inventoryId = inventoryId;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                {
                    purchasePriceErrorLabel.Visible = false;
                    sellingPriceErrorLabel.Visible = false;
                    quantityErrorLabel.Visible = false;

                    var currentSellingPrice = Convert.ToDouble(sellingPriceTextBox.Text);
                    var purchasePrice = Convert.ToDouble(purchasePriceTextBox.Text);
                    var quantity = Convert.ToInt32(quantityTextBox.Text);
                    var defaultQuantity = Convert.ToInt32(defaultQuantityTextBox.Text);

                    var inventoryItem = new InventoryItem
                    {
                        InventoryId = _inventoryId,
                        SellingPrice = currentSellingPrice,
                        PurchasePrice = purchasePrice,
                        Quantity = quantity,
                        MinQuantity = defaultQuantity
                    };
                    _controller.UpdateInventoryItem(inventoryItem);
                    ClearFields();
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Please enter valid values in all the fields");
            }

        }

        private bool ValidateFields()
        {
            bool result = false;
            double purchasePrice;
            double sellingPrice;
            int quantity;
            int minQuantity;

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

            if (string.IsNullOrEmpty(defaultQuantityTextBox.Text))
            {
                defaultQuantityErrorLabel.Text = @"Minimum Preferred Quantity cannot be empty";
                defaultQuantityErrorLabel.Visible = true;
                result = true;
            }

            if (!purchasePriceErrorLabel.Visible)
            {
                if (!double.TryParse(purchasePriceTextBox.Text, out purchasePrice))
                {
                    purchasePriceErrorLabel.Text = @"Product's purchase price must be a valid number";
                    purchasePriceErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!purchasePriceErrorLabel.Visible)
            {
                purchasePrice = Convert.ToDouble(purchasePriceTextBox.Text);
                if (purchasePrice <= 0)
                {
                    purchasePriceErrorLabel.Text = @"Product's purchase price must be a valid positive number";
                    purchasePriceErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!sellingPriceErrorLabel.Visible)
            {
                if (!double.TryParse(sellingPriceTextBox.Text, out sellingPrice))
                {
                    sellingPriceErrorLabel.Text = @"Product's selling price must be a valid number";
                    sellingPriceErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!sellingPriceErrorLabel.Visible)
            {
                sellingPrice = Convert.ToDouble(sellingPriceTextBox.Text);
                if (sellingPrice <= 0)
                {
                    sellingPriceErrorLabel.Text = @"Product's selling price must be a valid positive number";
                    sellingPriceErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!quantityErrorLabel.Visible)
            {
                if (!int.TryParse(quantityTextBox.Text, out quantity))
                {
                    quantityErrorLabel.Text = @"Quantity must be a valid number";
                    quantityErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!quantityErrorLabel.Visible)
            {
                quantity = Convert.ToInt32(quantityTextBox.Text);
                if (quantity <= 0)
                {
                    quantityErrorLabel.Text = @"Quantity must be a valid positive number";
                    quantityErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!defaultQuantityErrorLabel.Visible)
            {
                if (!int.TryParse(defaultQuantityTextBox.Text, out minQuantity))
                {
                    defaultQuantityErrorLabel.Text = @"Min Preferred Quantity must be a valid number";
                    defaultQuantityErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!defaultQuantityErrorLabel.Visible)
            {
                minQuantity = Convert.ToInt32(defaultQuantityTextBox.Text);
                if (minQuantity <= 0)
                {
                    defaultQuantityErrorLabel.Text = @"Min Preferred Quantity must be a valid positive number";
                    defaultQuantityErrorLabel.Visible = true;
                    result = true;
                }
            }

            return result;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            sellingPriceTextBox.Clear();
            purchasePriceTextBox.Clear();
            quantityTextBox.Clear();
            defaultQuantityTextBox.Clear();
            sellingPriceErrorLabel.Visible = false;
            purchasePriceErrorLabel.Visible = false;
            quantityErrorLabel.Visible = false;
            defaultQuantityErrorLabel.Visible = false;
            saveButton.Enabled = false;
        }

        private void SellingPriceTextBox_GotFocus(object sender, EventArgs e)
        {
            sellingPriceErrorLabel.Visible = false;
        }

        private void PurchasePriceTextBox_GotFocus(object sender, EventArgs e)
        {
            purchasePriceErrorLabel.Visible = false;
        }

        private void QuantityTextBox_GotFocus(object sender, EventArgs e)
        {
            quantityErrorLabel.Visible = false;
        }

        private void DefaultQuantityTextBox_GotFocus(object sender, EventArgs e)
        {
            defaultQuantityErrorLabel.Visible = false;
        }

        private void SellingPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void PurchasePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void DefaultQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }

        private void EditInventoryItemForm_Load(object sender, EventArgs e)
        {
            var inventoryItem = _controller.SearchInventoryWithInventoryId(_inventoryId);
            purchasePriceTextBox.Text = inventoryItem.PurchasePrice.ToString();
            sellingPriceTextBox.Text = inventoryItem.SellingPrice.ToString();
            quantityTextBox.Text = inventoryItem.Quantity.ToString();
            defaultQuantityTextBox.Text = inventoryItem.MinQuantity.ToString();

            saveButton.Enabled = false;
            sellingPriceErrorLabel.Visible = false;
            purchasePriceErrorLabel.Visible = false;
            quantityErrorLabel.Visible = false;
            defaultQuantityErrorLabel.Visible = false;
        }
    }
}
