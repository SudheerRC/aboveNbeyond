namespace MyStores.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginUserControl.Visible = true;
            groupBox.Visible = true;
            signUpUserControl.Visible = false;
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

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                loginUserControl.LoginUserControl_KeyPress(sender, e);
            }
        }
    }
}