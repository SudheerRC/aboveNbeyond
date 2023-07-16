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
            titleLabel.Location = new Point(210, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(260, 58);
            titleLabel.TabIndex = 90;
            titleLabel.Text = "Add Manager";
            titleLabel.UseCompatibleTextRendering = true;
            // 
            // emailErrorLabel
            // 
            emailErrorLabel.AutoSize = true;
            emailErrorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailErrorLabel.ForeColor = Color.Red;
            emailErrorLabel.Location = new Point(65, 194);
            emailErrorLabel.Name = "emailErrorLabel";
            emailErrorLabel.Size = new Size(125, 37);
            emailErrorLabel.TabIndex = 93;
            emailErrorLabel.Text = "Error text";
            emailErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            emailErrorLabel.UseWaitCursor = true;
            emailErrorLabel.Visible = false;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(294, 122);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(337, 39);
            emailTextBox.TabIndex = 91;
            emailTextBox.GotFocus += EmailTextBox_GotFocus;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(65, 130);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(93, 37);
            emailLabel.TabIndex = 92;
            emailLabel.Text = "Email*";
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.Location = new Point(252, 270);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(151, 62);
            addButton.TabIndex = 105;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // AddManagerUserControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 211, 177);
            Controls.Add(addButton);
            Controls.Add(emailErrorLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddManagerUserControl";
            Size = new Size(733, 358);
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
