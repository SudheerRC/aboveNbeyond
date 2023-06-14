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
            loginUserControl.Visible = true;
            groupBox.Visible = true;
            signUpUserControl.Visible = false;
            _controller = new MyStoresController();
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUpUserControl.Visible = true;
        }
    }
}