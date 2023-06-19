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
            signUpLinkLabel = new LinkLabel();
            newLabel = new Label();
            loginUserControl = new UserControls.LoginUserControl();
            signUpUserControl = new UserControls.SignUpUserControl();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.MistyRose;
            groupBox.Controls.Add(signUpLinkLabel);
            groupBox.Controls.Add(newLabel);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(340, 357);
            groupBox.Margin = new Padding(2, 1, 2, 1);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(2, 1, 2, 1);
            groupBox.Size = new Size(348, 47);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            // 
            // signUpLinkLabel
            // 
            signUpLinkLabel.AutoSize = true;
            signUpLinkLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            signUpLinkLabel.Location = new Point(164, 16);
            signUpLinkLabel.Margin = new Padding(2, 0, 2, 0);
            signUpLinkLabel.Name = "signUpLinkLabel";
            signUpLinkLabel.Size = new Size(100, 19);
            signUpLinkLabel.TabIndex = 7;
            signUpLinkLabel.TabStop = true;
            signUpLinkLabel.Text = "Click to Signup";
            signUpLinkLabel.LinkClicked += SignUpLinkLabel_LinkClicked;
            // 
            // newLabel
            // 
            newLabel.AutoSize = true;
            newLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            newLabel.Location = new Point(81, 14);
            newLabel.Margin = new Padding(2, 0, 2, 0);
            newLabel.Name = "newLabel";
            newLabel.Size = new Size(79, 20);
            newLabel.TabIndex = 8;
            newLabel.Text = "New here?";
            // 
            // loginUserControl
            // 
            loginUserControl.BackColor = Color.MistyRose;
            loginUserControl.Location = new Point(340, 98);
            loginUserControl.Margin = new Padding(1, 0, 1, 0);
            loginUserControl.Name = "loginUserControl";
            loginUserControl.Size = new Size(348, 214);
            loginUserControl.TabIndex = 1;
            // 
            // signUpUserControl
            // 
            signUpUserControl.BackColor = Color.MistyRose;
            signUpUserControl.Location = new Point(147, 41);
            signUpUserControl.Margin = new Padding(1, 0, 1, 0);
            signUpUserControl.Name = "signUpUserControl";
            signUpUserControl.Size = new Size(725, 384);
            signUpUserControl.TabIndex = 2;
            signUpUserControl.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1025, 488);
            Controls.Add(signUpUserControl);
            Controls.Add(loginUserControl);
            Controls.Add(groupBox);
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MaximumSize = new Size(1041, 527);
            MinimizeBox = false;
            MinimumSize = new Size(1041, 527);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyStores Home Page";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private LinkLabel signUpLinkLabel;
        private Label newLabel;
        private UserControls.LoginUserControl loginUserControl;
        private UserControls.SignUpUserControl signUpUserControl;
    }
}