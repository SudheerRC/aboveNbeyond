using MyStores.Controller;
using MyStores.Model;

namespace MyStores.UserControls
{
    public partial class AddManagerUserControl : UserControl
    {
        private readonly MyStoresController _controller;
        private Store _store;
        public AddManagerUserControl()
        {
            InitializeComponent();
            _controller = new MyStoresController();
            _store = new Store();
        }

        public void SetStore(Store store)
        {
            _store = store;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailErrorLabel.Text = "Email must not be empty.";
                emailErrorLabel.Visible = true;
            }

            if (!emailErrorLabel.Visible)
            {
                if (_controller.CheckEmail(emailTextBox.Text))
                {
                    string email = emailTextBox.Text;
                    int userId = _controller.GetUserId(email);
                    int storeId = _store.Id;
                    _controller.AddManager(userId, storeId);
                    emailErrorLabel.Text = email + " has been added as a manager to this store";
                    emailErrorLabel.ForeColor = Color.Green;
                    emailErrorLabel.Visible = true;
                }
            }

        }
    }
}
