using System.ComponentModel;

namespace MyStores.UserControls
{
    public partial class IconUserControl : UserControl
    {
        public IconUserControl()
        {
            InitializeComponent();
        }

        #region Properties

        private Image _icon;
        private string _name;

        [Category ("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set
            { 
                _icon = value;
                iconPictureBox.Image = value;
            }
        }

        [Category("Custom Props")]
        public string IconName
        {
            get { return _name; }
            set
            {
                _name = value;
                iconLabel.Text = value;
            }
        }

        #endregion

        #region Hover

        private void iconPictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 192, 192);
            this.iconPictureBox.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void iconPictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 192, 192);
            this.iconPictureBox.BackColor = Color.FromArgb(243, 239, 245);
        }

        #endregion

        private void iconPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void iconLabel_Click(object sender, EventArgs e)
        {

        }

        private void IconUserControl_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
