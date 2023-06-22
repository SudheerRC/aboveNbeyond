using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class AddManagerUserControl : UserControl
    {
        private readonly MyStoresController _controller;
        private int _storeId;
        public AddManagerUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        public void SetStore(int id)
        {
            _storeId = id;
        }

        public void clearControl()
        {
            emailErrorLabel.Visible = false;
            emailTextBox.Text = string.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailErrorLabel.Text = "Email must not be empty.";
                emailErrorLabel.Visible = true;
                emailErrorLabel.ForeColor = Color.Red;
            }

            if (!emailErrorLabel.Visible)
            {
                if (_controller.CheckEmail(emailTextBox.Text))
                {
                    string email = emailTextBox.Text;
                    int userId = _controller.GetUserId(email);
                    int storeId = _storeId;
                    _controller.AddManager(userId, storeId);
                    emailErrorLabel.Text = email + " has been added as a manager to this store";
                    emailErrorLabel.ForeColor = Color.Green;
                    emailErrorLabel.Visible = true;
                }
                else
                {
                    emailErrorLabel.Text = "It seems you're not registered." + Environment.NewLine + "Please register with us";
                    emailErrorLabel.Visible = true;
                    emailErrorLabel.ForeColor = Color.Red;
                }
            }
        }

        private void EmailTextBox_GotFocus(object sender, EventArgs e)
        {
            emailErrorLabel.Visible = false;
        }
    }
}
