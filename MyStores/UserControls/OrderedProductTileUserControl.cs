using MyStores.Model;
using System.Data;

namespace MyStores.UserControls
{
    public partial class OrderedProductTileUserControl : UserControl
    {
        private InventoryItem _inventoryItem;

        public delegate void StatusUpdateHandler(object sender, EventArgs e);
        public event StatusUpdateHandler OnUpdateStatus;


        public OrderedProductTileUserControl()
        {
            InitializeComponent();
            _inventoryItem = new InventoryItem();
        }

        public void setInventoryItem(InventoryItem item)
        {
            _inventoryItem = item;
        }

        private void UpdateStatus()
        {
            EventArgs args = EventArgs.Empty;

            OnUpdateStatus?.Invoke(this, args);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var quantity = Convert.ToInt32(quantityTextBox.Text);
            quantity = quantity + 1;
            quantityTextBox.Text = quantity.ToString();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            var quantity = Convert.ToInt32(quantityTextBox.Text);

            if (quantity > 0)
            {
                quantity = quantity - 1;
                quantityTextBox.Text = quantity.ToString();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            quantityTextBox.Text = @"0";

            UpdateStatus();
            this.Parent.Controls.Remove(this);
        }

        private void productNameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void OrderedProductTileUserControl_Load(object sender, EventArgs e)
        {
            productImagePictureBox.Image = MagicImageConverter.ConvertByteToImage(_inventoryItem.Item.Image);
            productImagePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            productNameLinkLabel.Text = _inventoryItem.Item.Name;
            descriptionLabel.Text = _inventoryItem.Item.Description;
            priceTextBox.Text = _inventoryItem.PurchasePrice.ToString();
            quantityTextBox.Text = _inventoryItem.Quantity.ToString();
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar.Equals('.')))
            {
                e.Handled = true;
            }
        }

        private void PositiveNumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PositiveNumbersOnly(sender, e);
        }
    }
}
