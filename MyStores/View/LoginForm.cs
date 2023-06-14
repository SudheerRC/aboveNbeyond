namespace MyStores.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            errorLabel.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string name = usernameTextBox.Text;
            string password = passwordTextBox.Text;

        }
    }
}