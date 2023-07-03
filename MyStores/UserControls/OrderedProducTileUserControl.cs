using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class OrderedProductTileUserControl : UserControl
    {
        private InventoryItem _inventoryItem;

        public OrderedProductTileUserControl()
        {
            InitializeComponent();
            _inventoryItem = new InventoryItem();
        }

        public void setInventoryItem(InventoryItem item)
        {
            _inventoryItem = item;
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
            quantity = quantity - 1;
            quantityTextBox.Text = quantity.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PositiveNumbersOnly(sender, e);
        }
    }
}
