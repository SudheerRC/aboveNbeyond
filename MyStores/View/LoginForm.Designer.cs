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
            this.groupBox.Location = new System.Drawing.Point(340, 357);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox.Size = new System.Drawing.Size(348, 47);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpLinkLabel.Location = new System.Drawing.Point(164, 16);
            this.signUpLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(100, 19);
            this.signUpLinkLabel.TabIndex = 7;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Click to Signup";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLinkLabel_LinkClicked);
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newLabel.Location = new System.Drawing.Point(81, 14);
            this.newLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(79, 20);
            this.newLabel.TabIndex = 8;
            this.newLabel.Text = "New here?";
            // 
            // loginUserControl
            // 
            this.loginUserControl.BackColor = System.Drawing.Color.MistyRose;
            this.loginUserControl.Location = new System.Drawing.Point(340, 98);
            this.loginUserControl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.loginUserControl.Name = "loginUserControl";
            this.loginUserControl.Size = new System.Drawing.Size(348, 214);
            this.loginUserControl.TabIndex = 1;
            // 
            // signUpUserControl
            // 
            this.signUpUserControl.BackColor = System.Drawing.Color.MistyRose;
            this.signUpUserControl.Location = new System.Drawing.Point(147, 41);
            this.signUpUserControl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.signUpUserControl.Name = "signUpUserControl";
            this.signUpUserControl.Size = new System.Drawing.Size(725, 384);
            this.signUpUserControl.TabIndex = 2;
            this.signUpUserControl.Visible = false;
            this.signUpUserControl.VisibleChanged += new System.EventHandler(this.signUpUserControl_VisibleChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 471);
            this.Controls.Add(this.signUpUserControl);
            this.Controls.Add(this.loginUserControl);
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1036, 510);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1036, 510);
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