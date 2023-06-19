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

        private void openButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Store");
        }
    }
}
