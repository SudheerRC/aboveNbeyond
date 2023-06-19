using MyStores.Controller;
using MyStores.Model;

namespace MyStores.View
{
    public partial class AddStoreForm : Form
    {
        private MyStoresController _controller;
        public AddStoreForm()
        {
            InitializeComponent();
            _controller = new MyStoresController();
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
            storeNametextBox.Clear();
            streetAddressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            countryTextBox.Clear();
            zipcodeTextBox.Clear();
            errorLabel.Visible = false;
            storeNameErrorLabel.Visible = false;
            cityErrorLabel.Visible = false;
            stateErrorLabel.Visible = false;
        }

        private void AddStoreButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                storeNameErrorLabel.Visible = false;
                cityErrorLabel.Visible = false;
                stateErrorLabel.Visible = false;
                errorLabel.Visible = false;

                var newStore = new Store
                {
                    Name = storeNametextBox.Text,
                    StreetAddress = streetAddressTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateTextBox.Text,
                    Country = countryTextBox.Text,
                    ZipCode = zipcodeTextBox.Text,
                };
                _controller.AddStore(newStore);
                this.Close();
            }
            else
            {
                errorLabel.Text = "Please meet the necessary requirements to add a store successfully.";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private bool ValidateFields()
        {
            bool result = false;
            if (string.IsNullOrEmpty(storeNametextBox.Text))
            {
                storeNameErrorLabel.Text = "Store name cannot be empty";
                storeNameErrorLabel.Visible = true;
                result = true;
            }

            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                cityErrorLabel.Text = "City name cannot be empty";
                cityErrorLabel.Visible = true;
                result = true;
            }

            if (string.IsNullOrEmpty(stateTextBox.Text))
            {
                stateErrorLabel.Text = "State name cannot be empty";
                stateErrorLabel.Visible = true;
                result = true;
            }

            return result;
        }

        private void StoreNameTextBox_GotFocus(object sender, EventArgs e)
        {
            storeNameErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void CityTextBox_GotFocus(object sender, EventArgs e)
        {
            cityErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void StateTextBox_GotFocus(object sender, EventArgs e)
        {
            stateErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }
    }
}
