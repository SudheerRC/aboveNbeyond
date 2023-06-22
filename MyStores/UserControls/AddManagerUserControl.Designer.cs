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
            titleLabel.Location = new Point(129, 20);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(162, 37);
            titleLabel.TabIndex = 90;
            titleLabel.Text = "Add Manager";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailErrorLabel.ForeColor = Color.Red;
            emailErrorLabel.Location = new Point(40, 121);
            emailErrorLabel.Margin = new Padding(2, 0, 2, 0);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(81, 23);
            emailErrorLabel.TabIndex = 93;
            emailErrorLabel.Text = "Error text";
            emailErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            emailErrorLabel.UseWaitCursor = true;
            emailErrorLabel.Visible = false;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(181, 76);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(209, 27);
            emailTextBox.TabIndex = 91;
            emailTextBox.GotFocus += EmailTextBox_GotFocus;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(40, 81);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(58, 23);
            emailLabel.TabIndex = 92;
            emailLabel.Text = "Email*";
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(155, 169);
            addButton.Margin = new Padding(2, 1, 2, 1);
            addButton.Name = "addButton";
            addButton.Size = new Size(93, 39);
            addButton.TabIndex = 105;
            addButton.Text = "Add Product";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // AddManagerUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(addButton);
            Controls.Add(emailErrorLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddManagerUserControl";
            Size = new Size(451, 224);
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
