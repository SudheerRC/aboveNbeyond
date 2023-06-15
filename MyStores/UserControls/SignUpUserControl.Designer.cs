namespace MyStores.UserControls
{
    partial class SignUpUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fnameTextBox = new TextBox();
            fnameLabel = new Label();
            titleLabel = new Label();
            lnameTextBox = new TextBox();
            lnameLabel = new Label();
            dobLabel = new Label();
            genderLabel = new Label();
            dobDateTimePicker = new DateTimePicker();
            genderComboBox = new ComboBox();
            countryLabel = new Label();
            phoneNumTextBox = new TextBox();
            phoneNumLabel = new Label();
            streetAddressTextBox = new TextBox();
            streetAddLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            errorLabel = new Label();
            clearButton = new Button();
            signupButton = new Button();
            cityTextBox = new TextBox();
            cityLabel = new Label();
            stateTextBox = new TextBox();
            stateLabel = new Label();
            zipcodeTextBox = new TextBox();
            zipcodeLabel = new Label();
            countryTextBox = new TextBox();
            cancelButton = new Button();
            fnameErrorLabel = new Label();
            lnameErrorLabel = new Label();
            emailErrorLabel = new Label();
            passwordErrorLabel = new Label();
            phoneErrorLabel = new Label();
            SuspendLayout();
            // 
            // fnameTextBox
            // 
            fnameTextBox.Location = new Point(260, 135);
            fnameTextBox.Name = "fnameTextBox";
            fnameTextBox.Size = new Size(290, 39);
            fnameTextBox.TabIndex = 13;
            fnameTextBox.GotFocus += FnameTextBox_GotFocus;
            // 
            // fnameLabel
            // 
            fnameLabel.AutoSize = true;
            fnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fnameLabel.Location = new Point(42, 134);
            fnameLabel.Name = "fnameLabel";
            fnameLabel.Size = new Size(150, 37);
            fnameLabel.TabIndex = 12;
            fnameLabel.Text = "First name*";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(513, 20);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(150, 58);
            titleLabel.TabIndex = 14;
            titleLabel.Text = "Sign up";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // lnameTextBox
            // 
            lnameTextBox.Location = new Point(260, 228);
            lnameTextBox.Name = "lnameTextBox";
            lnameTextBox.Size = new Size(290, 39);
            lnameTextBox.TabIndex = 16;
            lnameTextBox.GotFocus += LnameTextBox_GotFocus;
            // 
            // lnameLabel
            // 
            lnameLabel.AutoSize = true;
            lnameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lnameLabel.Location = new Point(42, 227);
            lnameLabel.Name = "lnameLabel";
            lnameLabel.Size = new Size(148, 37);
            lnameLabel.TabIndex = 15;
            lnameLabel.Text = "Last name*";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dobLabel.Location = new Point(42, 327);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(67, 37);
            dobLabel.TabIndex = 17;
            dobLabel.Text = "DoB";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genderLabel.Location = new Point(42, 411);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(104, 37);
            genderLabel.TabIndex = 19;
            genderLabel.Text = "Gender";
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.Format = DateTimePickerFormat.Short;
            dobDateTimePicker.Location = new Point(260, 326);
            dobDateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(290, 39);
            dobDateTimePicker.TabIndex = 23;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(260, 412);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(290, 40);
            genderComboBox.TabIndex = 24;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.Location = new Point(704, 504);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(111, 37);
            countryLabel.TabIndex = 33;
            countryLabel.Text = "Country";
            // 
            // phoneNumTextBox
            // 
            phoneNumTextBox.Location = new Point(922, 588);
            phoneNumTextBox.Name = "phoneNumTextBox";
            phoneNumTextBox.Size = new Size(290, 39);
            phoneNumTextBox.TabIndex = 36;
            phoneNumTextBox.TextChanged += PhoneNumTextBox_TextChanged;
            phoneNumTextBox.GotFocus += PhoneNumTextBox_GotFocus;
            phoneNumTextBox.KeyPress += PhoneNumTextBox_KeyPress;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumLabel.Location = new Point(704, 587);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(202, 37);
            phoneNumLabel.TabIndex = 35;
            phoneNumLabel.Text = "Phone number*";
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(922, 135);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(290, 39);
            streetAddressTextBox.TabIndex = 38;
            // 
            // streetAddLabel
            // 
            streetAddLabel.AutoSize = true;
            streetAddLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            streetAddLabel.Location = new Point(704, 134);
            streetAddLabel.Name = "streetAddLabel";
            streetAddLabel.Size = new Size(186, 37);
            streetAddLabel.TabIndex = 37;
            streetAddLabel.Text = "Street Address";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(260, 489);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(290, 39);
            emailTextBox.TabIndex = 40;
            emailTextBox.GotFocus += EmailTextBox_GotFocus;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(42, 488);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(93, 37);
            emailLabel.TabIndex = 39;
            emailLabel.Text = "Email*";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(260, 583);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(290, 39);
            passwordTextBox.TabIndex = 42;
            passwordTextBox.GotFocus += PasswordTextBox_GotFocus;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(42, 582);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(139, 37);
            passwordLabel.TabIndex = 41;
            passwordLabel.Text = "Password*";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.Location = new Point(78, 683);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(125, 37);
            errorLabel.TabIndex = 43;
            errorLabel.Text = "Error text";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.UseWaitCursor = true;
            errorLabel.Visible = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.Location = new Point(562, 734);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 46);
            clearButton.TabIndex = 45;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.White;
            signupButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            signupButton.Location = new Point(208, 734);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(150, 46);
            signupButton.TabIndex = 44;
            signupButton.Text = "Sign up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += SignUpButton_Click;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(922, 228);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(290, 39);
            cityTextBox.TabIndex = 47;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cityLabel.Location = new Point(704, 227);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(63, 37);
            cityLabel.TabIndex = 46;
            cityLabel.Text = "City";
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(922, 325);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(290, 39);
            stateTextBox.TabIndex = 49;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            stateLabel.Location = new Point(704, 324);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(76, 37);
            stateLabel.TabIndex = 48;
            stateLabel.Text = "State";
            // 
            // zipcodeTextBox
            // 
            zipcodeTextBox.Location = new Point(922, 413);
            zipcodeTextBox.Name = "zipcodeTextBox";
            zipcodeTextBox.Size = new Size(290, 39);
            zipcodeTextBox.TabIndex = 51;
            zipcodeTextBox.TextChanged += ZipcodeTextBox_TextChanged;
            zipcodeTextBox.KeyPress += ZipcodeTextBox_KeyPress;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            zipcodeLabel.Location = new Point(704, 412);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new Size(136, 37);
            zipcodeLabel.TabIndex = 50;
            zipcodeLabel.Text = "Zip Code*";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(922, 502);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(290, 39);
            countryTextBox.TabIndex = 52;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cancelButton.Location = new Point(943, 734);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 46);
            cancelButton.TabIndex = 53;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // fnameErrorLabel
            // 
            fnameErrorLabel.AutoSize = true;
            fnameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fnameErrorLabel.ForeColor = Color.Red;
            fnameErrorLabel.Location = new Point(132, 181);
            fnameErrorLabel.Name = "fnameErrorLabel";
            fnameErrorLabel.Size = new Size(111, 32);
            fnameErrorLabel.TabIndex = 54;
            fnameErrorLabel.Text = "Error text";
            fnameErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            fnameErrorLabel.UseWaitCursor = true;
            fnameErrorLabel.Visible = false;
            // 
            // lnameErrorLabel
            // 
            lnameErrorLabel.AutoSize = true;
            lnameErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lnameErrorLabel.ForeColor = Color.Red;
            lnameErrorLabel.Location = new Point(132, 285);
            lnameErrorLabel.Name = "lnameErrorLabel";
            lnameErrorLabel.Size = new Size(111, 32);
            lnameErrorLabel.TabIndex = 55;
            lnameErrorLabel.Text = "Error text";
            lnameErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            lnameErrorLabel.UseWaitCursor = true;
            lnameErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailErrorLabel.ForeColor = Color.Red;
            emailErrorLabel.Location = new Point(132, 539);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(111, 32);
            emailErrorLabel.TabIndex = 56;
            emailErrorLabel.Text = "Error text";
            emailErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            emailErrorLabel.UseWaitCursor = true;
            emailErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordErrorLabel.ForeColor = Color.Red;
            passwordErrorLabel.Location = new Point(132, 639);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(111, 32);
            passwordErrorLabel.TabIndex = 57;
            passwordErrorLabel.Text = "Error text";
            passwordErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            passwordErrorLabel.UseWaitCursor = true;
            passwordErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            phoneErrorLabel.AutoSize = true;
            phoneErrorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            phoneErrorLabel.ForeColor = Color.Red;
            phoneErrorLabel.Location = new Point(847, 639);
            phoneErrorLabel.Name = "phoneErrorLabel";
            phoneErrorLabel.Size = new Size(111, 32);
            phoneErrorLabel.TabIndex = 58;
            phoneErrorLabel.Text = "Error text";
            phoneErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            phoneErrorLabel.UseWaitCursor = true;
            phoneErrorLabel.Visible = false;
            // 
            // SignUpUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(phoneErrorLabel);
            Controls.Add(passwordErrorLabel);
            Controls.Add(emailErrorLabel);
            Controls.Add(lnameErrorLabel);
            Controls.Add(fnameErrorLabel);
            Controls.Add(cancelButton);
            Controls.Add(countryTextBox);
            Controls.Add(zipcodeTextBox);
            Controls.Add(zipcodeLabel);
            Controls.Add(stateTextBox);
            Controls.Add(stateLabel);
            Controls.Add(cityTextBox);
            Controls.Add(cityLabel);
            Controls.Add(clearButton);
            Controls.Add(signupButton);
            Controls.Add(errorLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(streetAddressTextBox);
            Controls.Add(streetAddLabel);
            Controls.Add(phoneNumTextBox);
            Controls.Add(phoneNumLabel);
            Controls.Add(countryLabel);
            Controls.Add(genderComboBox);
            Controls.Add(dobDateTimePicker);
            Controls.Add(genderLabel);
            Controls.Add(dobLabel);
            Controls.Add(lnameTextBox);
            Controls.Add(lnameLabel);
            Controls.Add(titleLabel);
            Controls.Add(fnameTextBox);
            Controls.Add(fnameLabel);
            Name = "SignUpUserControl";
            Size = new Size(1296, 822);
            Load += SignUpUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fnameTextBox;
        private Label fnameLabel;
        private Label titleLabel;
        private TextBox lnameTextBox;
        private Label lnameLabel;
        private Label dobLabel;
        private Label genderLabel;
        private DateTimePicker dobDateTimePicker;
        private ComboBox genderComboBox;
        private TextBox zipcodeTextBox;
        private Label zipcodeLabel;
        private TextBox countryTextBox;
        private Label countryLabel;
        private TextBox phoneNumTextBox;
        private Label phoneNumLabel;
        private TextBox streetAddressTextBox;
        private Label streetAddLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Label errorLabel;
        private Button clearButton;
        private Button signupButton;
        private TextBox cityTextBox;
        private Label cityLabel;
        private TextBox stateTextBox;
        private Label stateLabel;
        private Button cancelButton;
        private Label fnameErrorLabel;
        private Label lnameErrorLabel;
        private Label emailErrorLabel;
        private Label passwordErrorLabel;
        private Label phoneErrorLabel;
    }
}
