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
    public partial class CartItemUC : UserControl
    {
        // Events declaration for UI interaction
        public event EventHandler QuantityIncreased; // Event triggers when quantity incrases
        public event EventHandler QuantityDecreased; // Event triggers when quantity decreases
        public event EventHandler ItemRemoved;       // Event triggers when item removed

        public event Action<CartItemUC, int> QuantityChanged;

        // Property definitions for differnet things of a cart item.
        public string FoodName
        {
            get { return myCartFoodNameLabel.Text; }
            set { myCartFoodNameLabel.Text = value; }
        }

        public decimal Price
        {
            // Parses the price, removing the currency symbol
            get { return decimal.Parse(myCartPriceLabel.Text.Substring(1)); }
            // Formats and sets the price with a currency symbol
            set { myCartPriceLabel.Text = $"${value:0.00}"; }
        }

        public string RestaurantName
        {
            get { return myCartRestaurantLabel.Text; }
            set { myCartRestaurantLabel.Text = value; }
        }

        public int Quantity
        {
            get { return int.Parse(myCartTotalItemLabel.Text); }
            set { myCartTotalItemLabel.Text = value.ToString(); }
        }

        // Holds the path to the item's image
        public string ImagePath { get; set; } 

        // Method to load an image from the ImagePath
        public void LoadImage()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ImagePath))
                {
                    // Loads and sets the image in the PictureBox
                    myCartPictureBox.Image = Image.FromFile(ImagePath);
                }
            }
            catch (Exception ex)
            // Error handling if the image fails to load
            {
                MessageBox.Show($"Failed to load image. Error: {ex.Message}"); 
            }
        }

        public CartItemUC()
        {
            InitializeComponent(); // initialize component
        }

        // Creates a CartItem object representing this UserControl's current state
        public CartItem GetCartItem()
        {
            return new CartItem
            {
                FoodName = this.FoodName,
                Price = this.Price,
                RestaurantName = this.RestaurantName,
                Quantity = this.Quantity
            };
        }

        // Event handler to handle addition of quantity
        private void myCartAddButton_Click(object sender, EventArgs e)
        {
            Quantity++; // Increase the quantity
            QuantityIncreased?.Invoke(this, EventArgs.Empty); // Raise the increased event
            QuantityChanged?.Invoke(this, 1); // Notify change by +1
            CartUC.Instance.UpdateSummaryOrder(); // Update the cart summary
        }

        // Event handler to handle reduction of quantity
        private void myCartRemoveButton_Click(object sender, EventArgs e)
        {
            if (Quantity > 1)
            {
                Quantity--; // Decrease the quantity
                QuantityDecreased?.Invoke(this, EventArgs.Empty); // Raise the decreased event
                QuantityChanged?.Invoke(this, -1); // Notify change by  -1
                CartUC.Instance.UpdateSummaryOrder(); // Update the cart summary
            }
        }

        // Event handler to handle deletion of an item
        private void myCartDeleteButton_Click(object sender, EventArgs e)
        {
            ItemRemoved?.Invoke(this, EventArgs.Empty); // raise item remove event
            CartUC.Instance.UpdateSummaryOrder(); // Update the cart summary
        }
    }
}
