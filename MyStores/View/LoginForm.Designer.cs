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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.newLabel = new System.Windows.Forms.Label();
            this.loginUserControl = new MyStores.UserControls.LoginUserControl();
            this.signUpUserControl = new MyStores.UserControls.SignUpUserControl();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox.Controls.Add(this.signUpLinkLabel);
            this.groupBox.Controls.Add(this.newLabel);
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(631, 762);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox.Size = new System.Drawing.Size(646, 100);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpLinkLabel.Location = new System.Drawing.Point(305, 34);
            this.signUpLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(195, 37);
            this.signUpLinkLabel.TabIndex = 7;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Click to Signup";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLinkLabel_LinkClicked);
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newLabel.Location = new System.Drawing.Point(150, 30);
            this.newLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(158, 41);
            this.newLabel.TabIndex = 8;
            this.newLabel.Text = "New here?";
            // 
            // loginUserControl
            // 
            this.loginUserControl.BackColor = System.Drawing.Color.MistyRose;
            this.loginUserControl.Location = new System.Drawing.Point(631, 209);
            this.loginUserControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginUserControl.Name = "loginUserControl";
            this.loginUserControl.Size = new System.Drawing.Size(646, 457);
            this.loginUserControl.TabIndex = 1;
            // 
            // signUpUserControl
            // 
            this.signUpUserControl.BackColor = System.Drawing.Color.MistyRose;
            this.signUpUserControl.Location = new System.Drawing.Point(273, 87);
            this.signUpUserControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUpUserControl.Name = "signUpUserControl";
            this.signUpUserControl.Size = new System.Drawing.Size(1346, 819);
            this.signUpUserControl.TabIndex = 2;
            this.signUpUserControl.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1885, 973);
            this.Controls.Add(this.signUpUserControl);
            this.Controls.Add(this.loginUserControl);
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1911, 1044);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1911, 1044);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyStores Home Page";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox;
        private LinkLabel signUpLinkLabel;
        private Label newLabel;
        private UserControls.LoginUserControl loginUserControl;
        private UserControls.SignUpUserControl signUpUserControl;
    }
}