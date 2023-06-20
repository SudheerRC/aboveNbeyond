using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class AddVendorUserControl : UserControl
    {
        private readonly MyStoresController _controller;
        public AddVendorUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        private void PhoneNumTextBox_TextChanged(object sender, EventArgs e)
        {
            phoneErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void PhoneNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ZipcodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ZipcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            zipcodeTextBox.MaxLength = 6;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            streetAddressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            countryTextBox.Clear();
            zipcodeTextBox.Clear();
            phoneNumTextBox.Clear();
            nameErrorLabel.Visible = false;
            phoneErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void NameTextBox_GotFocus(object sender, EventArgs e)
        {
            nameErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void PhoneNumTextBox_GotFocus(object sender, EventArgs e)
        {
            phoneErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                nameErrorLabel.Visible = false;
                phoneErrorLabel.Visible = false;
                errorLabel.Visible = false;

                var newVendor = new Vendor
                {
                    Name = nameTextBox.Text,
                    StreetAddress = streetAddressTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateTextBox.Text,
                    Country = countryTextBox.Text,
                    PhoneNumber = phoneNumTextBox.Text,
                    ZipCode = zipcodeTextBox.Text
                };

                _controller.AddVendor(newVendor);
                errorLabel.Text = "Vendor has been added succesfully";
                errorLabel.ForeColor = Color.Green;
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Text = "Please meet the necessary requirements to add successfully";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private bool ValidateFields()
        {
            bool result = false;
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                nameErrorLabel.Text = "Vendor's name cannot be empty";
                nameErrorLabel.Visible = true;
                result = true;
            }

            if (phoneNumTextBox.Text.Length != 10)
            {
                phoneErrorLabel.Visible = true;
                phoneErrorLabel.Text = "Phone number must be of 10 digits";
                result = true;
            }

            return result;
        }
    }
}
