using MyStores.Controller;
using MyStores.Model;
using MyStores.View;

namespace MyStores.UserControls
{
    public partial class SignUpUserControl : UserControl
    {
        private readonly List<string> _gender;
        private readonly MyStoresController _controller;
        public bool _isSignedIn;

        public SignUpUserControl()
        {
            InitializeComponent();
            _gender = new List<string>();
            _controller = new MyStoresController();
            _isSignedIn = false;
        }

        private void AddGender()
        {
            _gender.Add("Male");
            _gender.Add("Female");
            _gender.Add("Not Specified");
        }

        private void SignUpUserControl_Load(object sender, EventArgs e)
        {
            AddGender();
            genderComboBox.DataSource = _gender.ToArray();
            ClearFields();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Visible = false;
        }

        private void ClearFields()
        {
            fnameTextBox.Clear();
            lnameTextBox.Clear();
            emailTextBox.Clear();
            passwordTextBox.Clear();
            streetAddressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            countryTextBox.Clear();
            zipcodeTextBox.Clear();
            phoneNumTextBox.Clear();
            genderComboBox.SelectedIndex = 0;
            errorLabel.Visible = false;
            dobDateTimePicker.MaxDate = DateTime.Now;
            fnameErrorLabel.Visible = false;
            lnameErrorLabel.Visible = false;
            emailErrorLabel.Visible = false;
            passwordErrorLabel.Visible = false;
            phoneErrorLabel.Visible = false;
            fnameErrorLabel.Text = "";
            lnameErrorLabel.Text = "";
            emailErrorLabel.Text = "";
            passwordErrorLabel.Text = "";
            phoneErrorLabel.Text = "";
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                fnameErrorLabel.Visible = false;
                lnameErrorLabel.Visible = false;
                emailErrorLabel.Visible = false;
                passwordErrorLabel.Visible = false;
                phoneErrorLabel.Visible = false;
                errorLabel.Visible = false;
                var newUser = new Users
                {
                    FirstName = fnameTextBox.Text,
                    LastName = lnameTextBox.Text,
                    DOB = dobDateTimePicker.Value,
                    Gender = genderComboBox.SelectedItem.ToString(),
                    Email = emailTextBox.Text,
                    Password = passwordTextBox.Text,
                    StreetAddress = streetAddressTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateTextBox.Text,
                    Country = countryTextBox.Text,
                    PhoneNumber = phoneNumTextBox.Text,
                    ZipCode = zipcodeTextBox.Text,
                };
                _controller.RegisterUser(newUser);
                _isSignedIn = true;
                this.Hide();
            }
            else
            {
                errorLabel.Text = "Please meet the necessary requirements to successfully sign up.";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }

        }

        private bool ValidateFields()
        {
            bool result = false;
            if (string.IsNullOrEmpty(fnameTextBox.Text))
            {
                fnameErrorLabel.Text = "First name cannot be empty";
                fnameErrorLabel.Visible = true;
                result = true;
            }

            if (string.IsNullOrEmpty(lnameTextBox.Text))
            {
                lnameErrorLabel.Text = "Last name cannot be empty";
                lnameErrorLabel.Visible = true;
                result = true;
            }

            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailErrorLabel.Text = "Email must not be empty.";
                emailErrorLabel.Visible = true;
                result = true;
            }

            if (!emailErrorLabel.Visible)
            {
                if (!emailTextBox.Text.Contains("@"))
                {
                    emailErrorLabel.Text = "Text must be in email format.";
                    emailErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!emailErrorLabel.Visible)
            {
                if (_controller.CheckEmail(emailTextBox.Text))
                {
                    emailErrorLabel.Text = "Email already exists. Please choose another one to sign up.";
                    emailErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                passwordErrorLabel.Text = "Password cannot be empty.";
                passwordErrorLabel.Visible = true;
                result = true;
            }

            if (!passwordErrorLabel.Visible)
            {
                if (passwordTextBox.Text.Length < 8 || passwordTextBox.Text.Length >= 20)
                {
                    passwordErrorLabel.Text = "Length of password must be between 8 and 20 characters.";
                    passwordErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!passwordErrorLabel.Visible)
            {
                if (!passwordTextBox.Text.Any(char.IsLower))
                {
                    passwordErrorLabel.Text = "Password must have atleast one lower case letter.";
                    passwordErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!passwordErrorLabel.Visible)
            {
                if (!passwordTextBox.Text.Any(char.IsUpper))
                {
                    passwordErrorLabel.Text = "Password must have atleast one upper case letter.";
                    passwordErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (!passwordErrorLabel.Visible)
            {
                if (!passwordTextBox.Text.Any(char.IsDigit))
                {
                    passwordErrorLabel.Text = "Password must have atleast one digit.";
                    passwordErrorLabel.Visible = true;
                    result = true;
                }
            }

            if (phoneNumTextBox.Text.Length != 10)
            {
                phoneErrorLabel.Visible = true;
                phoneErrorLabel.Text = "Phone number must be of 10 digits";
                result = true;
            }

            return result;
        }

        private void ZipcodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneNumTextBox_TextChanged(object sender, EventArgs e)
        {
            phoneNumTextBox.MaxLength = 10;
        }

        private void PhoneNumTextBox_GotFocus(object sender, EventArgs e)
        {
            phoneErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void ZipcodeTextBox_TextChanged(object sender, EventArgs e)
        {
            zipcodeTextBox.MaxLength = 6;
        }

        private void FnameTextBox_GotFocus(object sender, EventArgs e)
        {
            fnameErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void LnameTextBox_GotFocus(object sender, EventArgs e)
        {
            lnameErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void EmailTextBox_GotFocus(object sender, EventArgs e)
        {
            emailErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }

        private void PasswordTextBox_GotFocus(object sender, EventArgs e)
        {
            passwordErrorLabel.Visible = false;
            errorLabel.Visible = false;
        }
    }
}
