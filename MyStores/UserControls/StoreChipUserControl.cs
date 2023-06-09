﻿using System;
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
        private int _id;

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

        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                idLabel.Text = value.ToString();
            }
        }

        #endregion

        #region Hover

        private void StoreChipUserControl_MouseEnter(object sender, EventArgs e)
        {
            var rang = Color.FromArgb(28, 44, 98);
            this.BackColor = rang;
            this.storeImagePictureBox.BackColor = rang;
            this.cityLabel.BackColor = rang;
            this.managerLabel.BackColor = rang;
            this.managerNameLabel.BackColor = rang;
            this.storeNameLabel.BackColor = rang;
        }

        private void StoreChipUserControl_MouseLeave(object sender, EventArgs e)
        {
            var rang = Color.FromArgb(28, 44, 78);
            this.BackColor = rang;
            this.storeImagePictureBox.BackColor = rang;
            this.cityLabel.BackColor = rang;
            this.managerLabel.BackColor = rang;
            this.managerNameLabel.BackColor = rang;
            this.storeNameLabel.BackColor = rang;
        }

        #endregion

        private void chipClick()
        {
            //this.Parent.Hide();
        }

        private void managerNameLabel_Click(object sender, EventArgs e)
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

        private void StoreChipUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            chipClick();
        }

        private void managerLabel_Click(object sender, EventArgs e)
        {
            chipClick();
        }
    }
}
