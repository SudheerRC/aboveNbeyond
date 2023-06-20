using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStores.UserControls
{
    public partial class StoreChipUserControl : UserControl
    {

        public StoreChipUserControl()
        {
            InitializeComponent();
        }

        #region Properties

        private Image _icon;
        private string _name;
        private string _city;
        private string _managers;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                storeImagePictureBox.Image = value;
            }
        }

        [Category("Custom Props")]
        public string StoreName
        {
            get { return _name; }
            set
            {
                _name = value;
                storeNameLabel.Text = value;
            }
        }

        [Category("Custom Props")]
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                cityLabel.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Managers
        {
            get { return _managers; }
            set
            {
                _managers = value;
                managerNameLabel.Text = value;
            }
        }

        #endregion

        #region Hover

        private void StoreChipUserControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 44, 98);
            this.storeImagePictureBox.BackColor = Color.FromArgb(28, 44, 98);
        }

        private void StoreChipUserControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 44, 78);
            this.storeImagePictureBox.BackColor = Color.FromArgb(28, 44, 78);
        }

        #endregion

        private void chipClick()
        {

        }

        private void managerNameLabel_Click(object sender, EventArgs e)
        {
            chipClick();
        }

        private void StoreChipUserControl_Load(object sender, EventArgs e)
        {
            chipClick();
        }

        private void storeImagePictureBox_Click(object sender, EventArgs e)
        {
            chipClick();
        }

        private void storeNameLabel_Click(object sender, EventArgs e)
        {
            chipClick();
        }

        private void cityLabel_Click(object sender, EventArgs e)
        {
            chipClick();
        }

        private void StoreChipUserControl_Click(object sender, EventArgs e)
        {
            chipClick();
        }
    }
}
