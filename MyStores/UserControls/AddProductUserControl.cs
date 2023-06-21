using System.DirectoryServices.ActiveDirectory;
using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class AddProductUserControl : UserControl
    {
        private readonly MyStoresController _controller;
        public AddProductUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filename = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(filename);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            descriptionTextBox.Clear();
            sizeTextBox.Clear();
            departmentTextBox.Clear();
            priceTextBox.Clear();
            barcodeTextBox.Clear();
            pictureBox.Image = null;
            nameErrorLabel.Visible = false;
            priceErrorLabel.Visible = false;
            barcodeErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                {
                    nameErrorLabel.Visible = false;
                    priceErrorLabel.Visible = false;
                    barcodeErrorLabel.Visible = false;
                    errorLabel.Visible = false;

                    var newProduct = new Product
                    {
                        Name = nameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        ProductSize = sizeTextBox.Text,
                        Barcode = barcodeTextBox.Text,
                        DepartmentName = departmentTextBox.Text,
                        Image = pictureBox.Image,
                        SellingPrice = Double.Parse(priceTextBox.Text)
                    };
                    _controller.AddProduct(newProduct);
                    ClearButton_Click(sender, e);
                    errorLabel.Text = "Product has been added successfully";
                    errorLabel.ForeColor = Color.Green;
                    errorLabel.Visible = true;
                }
            }
            catch (FormatException)
            {
                errorLabel.Text = "Please give all the details to add.";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void BarcodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidateFields()
        {
            bool result = false;
            double price;
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameErrorLabel.Text = "Product name cannot be empty";
                nameErrorLabel.Visible = true;
                result = true;
            }

            if (string.IsNullOrEmpty(priceTextBox.Text))
            {
                priceErrorLabel.Text = "Product's selling price cannot be empty";
                priceErrorLabel.Visible = true;
                result = true;
            }

            if (string.IsNullOrEmpty(barcodeTextBox.Text))
            {
                barcodeErrorLabel.Text = "Product's barcode cannot be empty";
                barcodeErrorLabel.Visible = true;
                result = true;
            }

            if (!double.TryParse(priceTextBox.Text, out price))
            {
                priceErrorLabel.Text = "Product's selling price must be a valid number";
                priceErrorLabel.Visible = true;
                result = true;
            }

            return result;
        }

        private void NameTextBox_GotFocus(object sender, EventArgs e)
        {
            nameErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void PriceTextBox_GotFocus(object sender, EventArgs e)
        {
            priceErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void BarcodeTextBox_GotFocus(object sender, EventArgs e)
        {
            barcodeErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }
    }
}
