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
    public partial class AddProductUserControl : UserControl
    {
        public AddProductUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filename = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(filename);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }
    }
}
