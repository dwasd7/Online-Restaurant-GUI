using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject24
{
    public partial class checkOurCardUserControl : UserControl
    {
        // Add a property to store the image path
        public string ImagePath { get; set; }

        public checkOurCardUserControl()
        {
            InitializeComponent();
        }


        public string priceText
        {
            get { return cardPriceLabel.Text; }
            set { cardPriceLabel.Text = value; }
        }

        public string foodNameText
        {
            get { return foodNameLabel.Text; }
            set { foodNameLabel.Text = value; }
        }

        public string qtyText
        {
            get { return quantityLabel.Text; }
            set { quantityLabel.Text = value; }
        }

        // Modify the ItemImage property to use the ImagePath to load the image
        public Image ItemImage
        {
            get { return cardPictureBox.Image; }
            set
            {
                if (value != null)
                {
                    cardPictureBox.Image = value;
                }
                else if (!string.IsNullOrWhiteSpace(ImagePath))
                {
                    LoadImage();
                }
            }
        }

        // Method to load the image from the ImagePath
        public void LoadImage()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ImagePath))
                {
                    cardPictureBox.Image = Image.FromFile(ImagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image from path {ImagePath}. Error: {ex.Message}", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Call this method after setting the ImagePath to load the image
        public void UpdateImage()
        {
            LoadImage();
        }



    }
}
