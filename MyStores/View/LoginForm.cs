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
            signUpUserControl.Parent = this;
            loginUserControl.Parent = this;
        }

        private void SignUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUpUserControl.Visible = true;
        }

        private void signUpUserControl_VisibleChanged(object sender, EventArgs e)
        {
            if (signUpUserControl._isSignedIn)
            {
                loginUserControl.SetLoginLabel();
            }
        }
    }
}