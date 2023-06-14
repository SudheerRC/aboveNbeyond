namespace MyStores.View
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            groupBox = new GroupBox();
            passwordTextBox = new MaskedTextBox();
            signUpLinkLabel = new LinkLabel();
            newLabel = new Label();
            errorLabel = new Label();
            clearButton = new Button();
            loginButton = new Button();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            label1 = new Label();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.MistyRose;
            groupBox.Controls.Add(passwordTextBox);
            groupBox.Controls.Add(signUpLinkLabel);
            groupBox.Controls.Add(newLabel);
            groupBox.Controls.Add(errorLabel);
            groupBox.Controls.Add(clearButton);
            groupBox.Controls.Add(loginButton);
            groupBox.Controls.Add(usernameTextBox);
            groupBox.Controls.Add(passwordLabel);
            groupBox.Controls.Add(usernameLabel);
            groupBox.Controls.Add(label1);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(511, 214);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(870, 512);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(414, 234);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(288, 39);
            passwordTextBox.TabIndex = 4;
            // 
            // signUpLinkLabel
            // 
            signUpLinkLabel.AutoSize = true;
            signUpLinkLabel.Location = new Point(444, 455);
            signUpLinkLabel.Name = "signUpLinkLabel";
            signUpLinkLabel.Size = new Size(175, 32);
            signUpLinkLabel.TabIndex = 7;
            signUpLinkLabel.TabStop = true;
            signUpLinkLabel.Text = "Click to Signup";
            // 
            // newLabel
            // 
            newLabel.AutoSize = true;
            newLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            newLabel.Location = new Point(290, 449);
            newLabel.Name = "newLabel";
            newLabel.Size = new Size(158, 41);
            newLabel.TabIndex = 8;
            newLabel.Text = "New here?";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.Location = new Point(183, 291);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(125, 37);
            errorLabel.TabIndex = 7;
            errorLabel.Text = "Error text";
            errorLabel.Visible = false;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Location = new Point(522, 366);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 46);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.Location = new Point(200, 366);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 46);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(414, 136);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(290, 39);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(156, 231);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(143, 41);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(156, 130);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(152, 41);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(376, 35);
            label1.Name = "label1";
            label1.Size = new Size(114, 58);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.UseCompatibleTextRendering = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1894, 1009);
            Controls.Add(groupBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyStores Home Page";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private Label label1;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private Button loginButton;
        private Label errorLabel;
        private Button clearButton;
        private LinkLabel signUpLinkLabel;
        private Label newLabel;
        private MaskedTextBox passwordTextBox;
    }
}