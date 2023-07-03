namespace MyStores.UserControls
{
    partial class LoginUserControl
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
            passwordTextBox = new MaskedTextBox();
            errorLabel = new Label();
            loginButton = new Button();
            emailTextBox = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(282, 226);
            passwordTextBox.Margin = new Padding(4, 2, 4, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(288, 39);
            passwordTextBox.TabIndex = 12;
            passwordTextBox.GotFocus += PasswordTextBox_GotFocus;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.Location = new Point(69, 292);
            errorLabel.Margin = new Padding(4, 0, 4, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(125, 37);
            errorLabel.TabIndex = 15;
            errorLabel.Text = "Error text";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.UseWaitCursor = true;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(241, 363);
            loginButton.Margin = new Padding(4, 2, 4, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 58);
            loginButton.TabIndex = 13;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(282, 128);
            emailTextBox.Margin = new Padding(4, 2, 4, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(290, 39);
            emailTextBox.TabIndex = 11;
            emailTextBox.TextChanged += EmailTextBox_GotFocus;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(69, 226);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(143, 41);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(69, 126);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(88, 41);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 58);
            label1.TabIndex = 8;
            label1.Text = "Login";
            label1.UseCompatibleTextRendering = true;
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(passwordTextBox);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(emailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(label1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "LoginUserControl";
            Size = new Size(646, 476);
            Load += LoginUserControl_Load;
            KeyDown += LoginUserControl_KeyDown;
            KeyPress += LoginUserControl_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox passwordTextBox;
        private Label errorLabel;
        private Button loginButton;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private Label emailLabel;
        private Label label1;
    }
}
