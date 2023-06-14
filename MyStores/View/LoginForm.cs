using MyStores.Controller;
using MyStores.Model;

namespace MyStores.View
{
    public partial class LoginForm : Form
    {
        private readonly MyStoresController _controller;
        public LoginForm()
        {
            InitializeComponent();
            _controller = new MyStoresController();
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginUserControl.Visible = false;
        }
    }
}