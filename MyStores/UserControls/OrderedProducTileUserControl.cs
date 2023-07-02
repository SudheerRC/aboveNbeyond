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
    public partial class OrderedProducTileUserControl : UserControl
    {
        public OrderedProducTileUserControl()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var quantity = Convert.ToInt32(quantityTextBox.Text);
            quantity = quantity + 1;
            quantityTextBox.Text = quantity.ToString();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            var quantity = Convert.ToInt32(quantityTextBox.Text);
            quantity = quantity - 1;
            quantityTextBox.Text = quantity.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void productNameLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
