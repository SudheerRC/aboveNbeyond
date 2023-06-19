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

        public string _storeName { get; set; }
        public string _city { get; set; }
        public string _managers { get; set; }

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
