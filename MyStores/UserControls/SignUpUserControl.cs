namespace MyStores.UserControls
{
    public partial class SignUpUserControl : UserControl
    {
        private readonly List<string> _gender;
        public SignUpUserControl()
        {
            InitializeComponent();
            _gender = new List<string>();
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
            dobDateTimePicker.MaxDate = DateTime.Now;
        }

        private void ClearButton_Click(object sender, EventArgs e)
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
            errorLabel.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearButton_Click(sender, e);
            this.Visible = false;
        }
    }
}
