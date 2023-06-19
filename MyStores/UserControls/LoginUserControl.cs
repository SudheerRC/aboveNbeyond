using MyStores.Controller;
using MyStores.Model;
using MyStores.View;

namespace MyStores.UserControls
{
    public partial class LoginUserControl : UserControl
    {
        private readonly MyStoresController _controller;

        public LoginUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            var user = new Users
            {
                Email = email,
                Password = password
            };
            if (_controller.CheckUserLogin(user))
            {
                user.UserId = _controller.GetUserId(email);
                using var mainForm = new MainDashboard();
                mainForm.SetOwner(user);
                var result = mainForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    errorLabel.Text = "You've been successfully logged out.";
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Green;
                    ClearFields();
                }
            }
            else if (emailTextBox.Text == String.Empty)
            {
                errorLabel.Text = "Please enter your email";
                errorLabel.Visible = true;
                errorLabel.ForeColor = Color.Red;
            }
            else if (passwordTextBox.Text == String.Empty)
            {
                errorLabel.Text = "Please enter your password";
                errorLabel.Visible = true;
                errorLabel.ForeColor = Color.Red;
            }
            else if (!_controller.CheckEmail(email))
            {
                errorLabel.Text = "It seems you're not registered." + Environment.NewLine + "Please register with us";
                errorLabel.Visible = true;
                errorLabel.ForeColor = Color.Red;
            }
            else
            {
                errorLabel.Text = "Wrong Email or password. Please try again";
                errorLabel.Visible = true;
                errorLabel.ForeColor = Color.Red;
            }
        }

        private void ClearFields()
        {
            emailTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void EmailTextBox_GotFocus(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void PasswordTextBox_GotFocus(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void LoginUserControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                LoginButton_Click(sender, e);
            }
        }
    }
}
