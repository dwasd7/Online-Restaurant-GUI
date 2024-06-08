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
    public partial class CartUC : UserControl
    {

        private static CartUC _instance;

        public static CartUC Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CartUC();
                }
                return _instance;
            }

        }

        public CartUC()
        {
            InitializeComponent();
        }

        private List<CartItem> selectedItems = new List<CartItem>();

        public int TotalQuantity
        {
            get { return selectedItems.Sum(item => item.Quantity); }
        }

        //....
        public event EventHandler CartItemsChanged;




        // Method to load items into the CartUC and update the list
        public void LoadCartItems(IEnumerable<CartItem> items)
        {
            selectedItems.Clear(); // Clear any existing items from the list.

            var groupedItems = items
                .GroupBy(item => new { item.FoodName, item.Price }) // Group by unique name and price.
                .Select(group => new CartItem
                {
                    FoodName = group.Key.FoodName,
                    Price = group.Key.Price,
                    Quantity = group.Sum(g => g.Quantity), // Sum quantities of identical items.
                    ImagePath = group.First().ImagePath // Take the image path from the first item in each group.
                });

            selectedItems.AddRange(groupedItems); // Add grouped items to the list.
            UpdateSummaryOrder(); // Recalculate the summary order.

            loadCardPanel.Controls.Clear(); // Clear the panel for the new controls.

            int yOffset = 0; // Initialize Y-offset for the first item.

            foreach (var item in selectedItems) // Iterate over the grouped items.
            {
                var cartItemControl = new CartItemUC
                {
                    FoodName = item.FoodName,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    ImagePath = item.ImagePath,
                };



                loadCardPanel.Controls.Add(cartItemControl);

                cartItemControl.LoadImage(); // Load the item's image.

                cartItemControl.Location = new Point(0, yOffset); // Set the location with the current yOffset.
                yOffset += cartItemControl.Height + 10; // Increment yOffset for the next item.
                Size = cartItemControl.Size;
                SubscribeToItemEvents(cartItemControl);

                loadCardPanel.Controls.Add(cartItemControl); // Add the control to the panel.
            }
        }


        public List<CartItem> GetCartItems()
        {
            // Create a new list and add copies of each CartItem in selectedItems
            return selectedItems.Select(item => new CartItem
            {
                FoodName = item.FoodName,
                Price = item.Price,
                Quantity = item.Quantity,
                ImagePath = item.ImagePath
            }).ToList();
        }

        // Method to calculate the summary order
        public void UpdateSummaryOrder()
        {
            decimal subtotal = selectedItems.Sum(item => item.Price * item.Quantity);
            decimal tax = subtotal * 0.07m; // tax rate
            decimal total = subtotal + tax;
            int totalItems = selectedItems.Sum(item => item.Quantity);


            totalItemNumberLabel.Text = totalItems.ToString();
            subtotalPriceLabel.Text = $"${subtotal:0.00}";
            taxPriceLabel.Text = $"${tax:0.00}";
            totalLabelText.Text = $"${total:0.00}";

            CartItemsChanged?.Invoke(this, EventArgs.Empty); // Fire the event


        }


        //............
        // This method sets up event listeners for the CartItemUC controls.
        private void SubscribeToItemEvents(CartItemUC cartItemControl)
        {
            // When the quantity is increased on the CartItemUC control...
            cartItemControl.QuantityIncreased += (sender, args) =>
            {
                // Find the item in the cart that matches the one being changed.
                var itemInCart = selectedItems.FirstOrDefault(item => item.FoodName == cartItemControl.FoodName && item.Price == cartItemControl.Price);

                // If we find the item...
                if (itemInCart != null)
                {
                    // Increase its quantity by one.
                    itemInCart.Quantity++;

                    // Update the order summary to reflect the new quantity.
                    UpdateSummaryOrder();
                }
            };


            // When the quantity is decreased on the CartItemUC control...
            cartItemControl.QuantityDecreased += (sender, args) =>
            {
                // Find the item in the cart that matches the one being changed.
                var itemInCart = selectedItems.FirstOrDefault(item => item.FoodName == cartItemControl.FoodName && item.Price == cartItemControl.Price);

                // If we find the item and its quantity is more than one...
                if (itemInCart != null && itemInCart.Quantity > 1)
                {
                    // Decrease its quantity by one.
                    itemInCart.Quantity--;

                    // Update the order summary to reflect the new quantity.
                    UpdateSummaryOrder();
                }
            };


            // When an item is removed from the CartItemUC control...
            cartItemControl.ItemRemoved += (sender, args) =>
            {
                // Find the item in the cart that matches the one being changed.
                var itemInCart = selectedItems.FirstOrDefault(item => item.FoodName == cartItemControl.FoodName && item.Price == cartItemControl.Price);

                // If we find the item...
                if (itemInCart != null)
                {
                    // Remove it from the cart.
                    selectedItems.Remove(itemInCart);

                    // Update the order summary since an item was removed.
                    UpdateSummaryOrder();
                }

                // Remove the control representing the item from the UI.
                loadCardPanel.Controls.Remove(cartItemControl);

                // Clean up the control to free resources.
                cartItemControl.Dispose();
            };
        }


        public event EventHandler CartCleared; // Event to be triggered when the cart needs to be cleared

        // Method to clear the cart
        public void ClearCart()
        {
            selectedItems.Clear();
            loadCardPanel.Controls.Clear();

            // Optionally, update any UI elements that reflect the cart status
            UpdateSummaryOrder();  // This would reset any totals displayed to the user



            MessageBox.Show("The cart has been cleared.");  // Optional: Notify the user
        }

        public List<CartItem> orderBoard { get; private set; } = new List<CartItem>();
          
        // Event declaration
        public event EventHandler NavigateToPayment;

        private void buyNowButton_Click(object sender, EventArgs e)
        {

            // Get the current cart items
            List<CartItem> cartItems = GetCartItems();

            // Check if the PaymentUserControl1 Instance is not null and set the cart items
            PaymentUserControl1.Instance?.SetCartItemsAndDisplay(cartItems);

            NavigateToPayment?.Invoke(this, EventArgs.Empty); 
        }

    }

    // Define the CartItem class items.
    public class CartItem
    {
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public string RestaurantName { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
    }
}
