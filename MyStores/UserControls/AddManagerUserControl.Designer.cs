namespace MyStores.UserControls
{
    partial class AddManagerUserControl
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
            titleLabel = new Label();
            emailErrorLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            addButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ControlText;
            titleLabel.Location = new Point(113, 15);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(130, 31);
            titleLabel.TabIndex = 90;
            titleLabel.Text = "Add Manager";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailErrorLabel.ForeColor = Color.Red;
            emailErrorLabel.Location = new Point(35, 91);
            emailErrorLabel.Margin = new Padding(2, 0, 2, 0);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(66, 19);
            emailErrorLabel.TabIndex = 93;
            emailErrorLabel.Text = "Error text";
            emailErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            emailErrorLabel.UseWaitCursor = true;
            emailErrorLabel.Visible = false;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(158, 57);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(183, 23);
            emailTextBox.TabIndex = 91;
            emailTextBox.GotFocus += EmailTextBox_GotFocus;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(35, 61);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(47, 19);
            emailLabel.TabIndex = 92;
            emailLabel.Text = "Email*";
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(136, 127);
            addButton.Margin = new Padding(2, 1, 2, 1);
            addButton.Name = "addButton";
            addButton.Size = new Size(81, 29);
            addButton.TabIndex = 105;
            addButton.Text = "Add Product";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // AddManagerUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            Controls.Add(addButton);
            Controls.Add(emailErrorLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(titleLabel);
            Name = "AddManagerUserControl";
            Size = new Size(395, 168);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label emailErrorLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private Button addButton;
    }
}
