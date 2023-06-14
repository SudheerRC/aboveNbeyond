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
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.BackColor = Color.MistyRose;
            groupBox.Controls.Add(signUpLinkLabel);
            groupBox.Controls.Add(newLabel);
            groupBox.ForeColor = Color.Black;
            groupBox.Location = new Point(631, 762);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(646, 100);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            // 
            // signUpLinkLabel
            // 
            signUpLinkLabel.AutoSize = true;
            signUpLinkLabel.Location = new Point(304, 35);
            signUpLinkLabel.Name = "signUpLinkLabel";
            signUpLinkLabel.Size = new Size(175, 32);
            signUpLinkLabel.TabIndex = 7;
            signUpLinkLabel.TabStop = true;
            signUpLinkLabel.Text = "Click to Signup";
            signUpLinkLabel.LinkClicked += signUpLinkLabel_LinkClicked;
            // 
            // newLabel
            // 
            newLabel.AutoSize = true;
            newLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            newLabel.Location = new Point(150, 29);
            newLabel.Name = "newLabel";
            newLabel.Size = new Size(158, 41);
            newLabel.TabIndex = 8;
            newLabel.Text = "New here?";
            // 
            // loginUserControl
            // 
            loginUserControl.BackColor = Color.MistyRose;
            loginUserControl.Location = new Point(631, 210);
            loginUserControl.Name = "loginUserControl";
            loginUserControl.Size = new Size(646, 456);
            loginUserControl.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1894, 1009);
            Controls.Add(loginUserControl);
            Controls.Add(groupBox);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1080);
            MinimizeBox = false;
            MinimumSize = new Size(1920, 1080);
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
    }
}