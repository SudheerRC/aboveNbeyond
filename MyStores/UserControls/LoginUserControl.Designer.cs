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
            passwordTextBox.Location = new Point(152, 106);
            passwordTextBox.Margin = new Padding(2, 1, 2, 1);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(157, 23);
            passwordTextBox.TabIndex = 12;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.Location = new Point(37, 137);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(66, 19);
            errorLabel.TabIndex = 15;
            errorLabel.Text = "Error text";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            errorLabel.UseWaitCursor = true;
            errorLabel.Visible = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(130, 170);
            loginButton.Margin = new Padding(2, 1, 2, 1);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(81, 27);
            loginButton.TabIndex = 13;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(152, 60);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(158, 23);
            emailTextBox.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(37, 106);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(37, 59);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 31);
            label1.TabIndex = 8;
            label1.Text = "Login";
            label1.UseCompatibleTextRendering = true;
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(passwordTextBox);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(emailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoginUserControl";
            Size = new Size(348, 223);
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
