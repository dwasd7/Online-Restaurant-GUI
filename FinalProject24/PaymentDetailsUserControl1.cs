using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject24
{
    public partial class PaymentUserControl1 : UserControl
    {

        private static PaymentUserControl1 _instance;
        public List<CartItem> CartItems { get; set; }

        // Field to store userID
        private string userID;

        public void SetUserID(string userID)
        {
            this.userID = userID;
            CheckOrCreatePaymentCsv(userID);
            //MessageBox.Show("ID from Payment: " + userID); // This will now show the correct userID

        }

        private PaymentUserControl1()
        {
            InitializeComponent();

            DisplayCartItem(); // Call the method to add cart item controls

            applyChangeButton.Visible = false;
            cancelLabel.Visible = false;

            //enterEditLabel.Visible = false;

        }
        orderHistoryDetailsUserControl orderHistoryDetailsControl = new orderHistoryDetailsUserControl();




        public static PaymentUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PaymentUserControl1();
                }
                return _instance;
            }
        }




        // Method to clear loaded user controls and reset price labels
        public void ClearPaymentInfo()
        {
            // Clear the controls from the loadItemCardPanel
            loadItemCardPanel.Controls.Clear();

            // Reset the text of the price labels to their initial state or empty
            subtotalPriceLabel.Text = "$0.00";
            taxPriceLabel.Text = "$0.00";
            totalDuePirceLabel.Text = "$0.00";

            // Optionally, reset the text of the payment button
            button1.Text = "Pay: $0.00";

            // You can also clear the CartItems list if needed
            CartItems.Clear();
        }




        private void button1_Click(object sender, EventArgs e)
        {


            string currentDate = DateTime.Now.ToString("MMddyyyy");
            string orderNumber = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + new Random().Next(1000, 9999);
            decimal subtotal = CartItems.Sum(item => item.Price * item.Quantity);
            decimal tax = subtotal * 0.07m;
            decimal total = subtotal + tax;

            //string filePath = SaveOrderDetailsToCSV(orderNumber, CartItems, subtotal, tax, total);
            string filePath = SaveOrderDetailsToCSV(userID, orderNumber, CartItems, subtotal, tax, total);
            string forManger = SaveOrderDetailsForManager(orderNumber, CartItems, subtotal, tax, total);
            MessageBox.Show("Items added to the order board.");

            CartUC.Instance.ClearCart(); // Clear the cart after payment

            ClearPaymentInfo();

        }



        private string SaveOrderDetailsToCSV(string userID, string orderNumber, List<CartItem> items, decimal subtotal, decimal tax, decimal total)
        {
            // Construct the directory path using the userID
            string userFolderPath = Path.Combine(@"..\..\..\..\CustomerUserFolder\", userID);
            string receiptsDirectoryPath = Path.Combine(userFolderPath, "receipts");

            // Ensure the receipts directory exists
            Directory.CreateDirectory(receiptsDirectoryPath);

            // Create the file path for the new CSV file
            string filePath = Path.Combine(receiptsDirectoryPath, $"{orderNumber}.csv");

            // Open a new StreamWriter to write to the CSV file
            using (StreamWriter file = new StreamWriter(filePath))
            {
                // Write the CSV headers
                file.WriteLine("Item Name,Quantity,Price,Total");

                // Write each item's details to the CSV
                foreach (var item in items)
                {
                    file.WriteLine($"{item.FoodName},{item.Quantity},${item.Price},${item.Price * item.Quantity}");
                }

                // Write the subtotal, tax, and total to the CSV
                file.WriteLine($"Subtotal,,${subtotal:0.00}");
                file.WriteLine($"Tax,,${tax:0.00}");
                file.WriteLine($"Total,,${total:0.00}");

                // Add a final line for overall order status
                file.WriteLine($",,,Order Status: Pending");
            }

            // Return the file path in case it needs to be used (e.g., for reading or sending as an email attachment)
            return filePath;
        }





        private string SaveOrderDetailsForManager(string orderNumber, List<CartItem> items, decimal subtotal, decimal tax, decimal total)
        {
            string directoryPath = @"..\..\..\..\receipts\";
            Directory.CreateDirectory(directoryPath);
            string filePath = Path.Combine(directoryPath, $"{orderNumber}.csv");

            using (StreamWriter file = new StreamWriter(filePath))
            {
                // Remove 'Status' from the header
                file.WriteLine("Item Name,Quantity,Price,Total");
                foreach (var item in items)
                {
                    // Remove 'Pending' from each item line
                    file.WriteLine($"{item.FoodName},{item.Quantity},${item.Price},${item.Price * item.Quantity}");
                }
                // Write the subtotal, tax, and total without 'Status' column
                file.WriteLine($"Subtotal,,${subtotal:0.00}");
                file.WriteLine($"Tax,,${tax:0.00}");
                file.WriteLine($"Total,,${total:0.00}");

                // Add a final line for overall order status
                file.WriteLine($",,,Order Status: Pending");
            }
            return filePath;
        }



        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Address, City, State")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Address, City, State";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Zip Code")
            {
                textBox6.Text = "";
                textBox6.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                textBox6.Text = "Zip Code";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "XXXX-XXXX-XXXX-XXXX")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "XXXX-XXXX-XXXX-XXXX";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "CV")
            {
                textBox4.Text = "";
                textBox4.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "CV";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "MM/YY")
            {
                textBox5.Text = "";
                textBox5.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "MM/YY";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Full Name")
            {
                textBox5.Text = "";
                textBox5.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                textBox5.Text = "Full Name";
                textBox5.ForeColor = Color.Gray;
            }
        }

        public void SetCartItemsAndDisplay(List<CartItem> items)
        {
            CartItems = items; // Save the items to the local list
            DisplayCartItem(); // Display the items on the control
        }



        private void DisplayCartItem()
        {
            loadItemCardPanel.Controls.Clear(); // Clear existing controls

            if (CartItems == null || !CartItems.Any())
            {
                //MessageBox.Show("No items in cart to display.");

                // Create a new label
                Label label = new Label();

                // Set the label's properties
                label.Text = "Your Order is empty.";
                label.ForeColor = Color.Black; // Text color
                label.BackColor = Color.Transparent; // Make the background of the label transparent
                label.AutoSize = true; // Auto-size the label to fit the text
                label.Location = new Point(10, 10); // Position the label at x=10, y=10 within the panel

                // Add the label to the panel
                loadItemCardPanel.Controls.Add(label);

                return; // Exit the method as there's nothing to display
            }

            int yOffset = 0;
            const int padding = 10; // Add some space between the items

            foreach (var cartItem in CartItems)
            {
                var cardControl = new checkOurCardUserControl();
                cardControl.foodNameText = cartItem.FoodName;
                cardControl.priceText = cartItem.Price.ToString("C2");
                cardControl.qtyText = "Qty: " + cartItem.Quantity.ToString();
                cardControl.ImagePath = cartItem.ImagePath;
                cardControl.UpdateImage();


                // Set the location of each control to avoid overlapping
                cardControl.Location = new Point(0, yOffset);

                loadItemCardPanel.Controls.Add(cardControl); // Add the control to the panel

                // Update yOffset for the next control to be added below the previous one
                yOffset += cardControl.Height + padding; // Increase the space for the next item
            }

            UpdateSummaryOrder();
            // Update the panel's scrollable region if it's set to allow scrolling
            loadItemCardPanel.AutoScroll = true; // If your panel is supposed to scroll
        }


        public void UpdateSummaryOrder()
        {
            decimal subtotal = 0m;
            decimal taxRate = 0.07m; // 7% tax, for example
            decimal tax = 0m;
            decimal total = 0m;

            // Calculate the subtotal based on the CartItems
            if (CartItems != null && CartItems.Any())
            {
                subtotal = CartItems.Sum(item => item.Price * item.Quantity);
            }

            // Calculate the tax based on the subtotal
            tax = subtotal * taxRate;

            // Calculate the total
            total = subtotal + tax;

            // Update your UI elements accordingly
            subtotalPriceLabel.Text = subtotal.ToString("C2");
            taxPriceLabel.Text = tax.ToString("C2");
            totalDuePirceLabel.Text = total.ToString("C2");
            button1.Text = "Pay: " + total.ToString("C2");
        }

        private void editLabel_Click(object sender, EventArgs e)
        {
            applyChangeButton.Visible = true;
            cancelLabel.Visible = true;

            textBox1.Enabled = true;
            textBox6.Enabled = true;
            textBox2.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox3.Enabled = true;

            // Payment Details label
            label1.Text = "Edit Payment Details";

            // Main Address label
            label2.Text = "Edit Main Address:";

            // Card Number label
            label3.Text = "Edit Card Number:";

            // Card Holder Name label
            label4.Text = "Edit Card Holder Name:";


        }

        private void cancelLabel_Click(object sender, EventArgs e)
        {
            applyChangeButton.Visible = false;
            cancelLabel.Visible = false;

            textBox1.Enabled = false;
            textBox6.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox3.Enabled = false;

            // Payment Details label
            label1.Text = "Payment Details";

            // Main Address label
            label2.Text = "Main Address:";

            // Card Number label
            label3.Text = "Card Number:";

            // Card Holder Name label
            label4.Text = "Card Holder Name:";
        }



        private void CheckOrCreatePaymentCsv(string userID)
        {
            // Define the directory path for the user's data
            string userFolderPath = Path.Combine(@"..\..\..\..\CustomerUserFolder\", userID);

            // Ensure the user's folder exists, if not, create it.
            if (!Directory.Exists(userFolderPath))
            {
                Directory.CreateDirectory(userFolderPath);
            }

            // Define the file path for payment.csv
            string paymentCsvPath = Path.Combine(userFolderPath, "payment.csv");

            // Check if payment.csv exists
            if (!File.Exists(paymentCsvPath))
            {
                // If payment.csv does not exist.
                //MessageBox.Show("Payment file does not exist. Please enter payment details.");
                enterEditLabel.Visible = true; // Shows the label prompting the user to enter details.
                button1.Enabled = false; // Disable the button since there are no payment details yet.

                textBox1.Enabled = false;
                textBox6.Enabled = false;
                textBox2.Enabled = false;
                textBox4.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                // If payment.csv exists;
                enterEditLabel.Visible = false; // Hides the label since the payment details are already entered.
                button1.Enabled = true; // Enables the button since payment details exist.

                // Read the content of the payment.csv file.
                var lines = File.ReadAllLines(paymentCsvPath);
                if (lines.Length > 1)
                {
                    var data = lines[1].Split(',');

                    // Joins the first three parts to form the main address.
                    string mainAddress = string.Join(",", data.Take(3)).Trim('"'); // Removes quotes if they were added to handle the commas.

                    // Adjust the indices for the remaining data based on the structure of your CSV.
                    string zipCode = data[3].Trim('"');
                    string cardNumber = data[4].Trim('"');
                    string cvv = data[5].Trim('"');
                    string expiryDate = data[6].Trim('"');
                    string cardHolderName = data[7].Trim('"');

                    // Assign the values to the text boxes.
                    textBox1.Text = mainAddress;
                    textBox1.Enabled = false;
                    //textBox1.ReadOnly = true;

                    textBox6.Text = zipCode;
                    textBox6.Enabled = false;
                    //textBox6.ReadOnly = true;

                    textBox2.Text = cardNumber;
                    textBox2.Enabled = false;
                    //textBox2.ReadOnly = true;

                    textBox4.Text = cvv;
                    textBox4.Enabled = false;
                    //textBox4.ReadOnly = true;

                    textBox5.Text = expiryDate;
                    textBox5.Enabled = false;
                    //textBox5.ReadOnly = true;

                    textBox3.Text = cardHolderName;
                    textBox3.Enabled = false;
                    //textBox3.ReadOnly = true;
                   


                }
                else
                {
                    // Handle the case where the payment file may be empty or only contain headers.
                    MessageBox.Show("The payment file is empty or improperly formatted.");
                }
            }
        }

        private bool ValidateInputs()
        {
            // Validation for Main Address
            if (!Regex.IsMatch(textBox1.Text, @"^[\w\s]+,\s*\w+,\s*\w+$"))
            {
                MessageBox.Show("Main Address must be in the format: street address, City, State");
                return false;
            }

            // Validation for Zip Code
            if (!Regex.IsMatch(textBox6.Text, @"^\d{5}$"))
            {
                MessageBox.Show("Zip Code must be 5 digits");
                return false;
            }

            // Validate Card Number (15 or 16 digits).
            if (!Regex.IsMatch(textBox2.Text, @"^(\d{4}-){3}\d{4}$") &&
                !Regex.IsMatch(textBox2.Text, @"^(\d{4} ){3}\d{4}$") &&
                !Regex.IsMatch(textBox2.Text, @"^\d{15,16}$")) // Matches 15 or 16 continuous digits
            {
                MessageBox.Show("Card Number must be 15 or 16 digits.");
                return false;
            }





            // Validate CVV
            if (!Regex.IsMatch(textBox4.Text, @"^\d{3,4}$"))
            {
                MessageBox.Show("CVV must be 3 or 4 digits");
                return false;
            }

            // Validate Expiry Date
            if (!ValidExpiryDate(textBox5.Text))
            {
                MessageBox.Show("Expiry Date must be in the format: MM/YY and cannot be in the past.");
                return false;
            }

            // Validate Card Holder's Name
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Card Holder's Name cannot be empty.");
                return false;
            }

            return true;
        }

        private bool ValidExpiryDate(string expiryDate)
        {
            if (!Regex.IsMatch(expiryDate, @"^(0[1-9]|1[0-2])\/\d{2}$"))
            {
                return false;
            }

            DateTime expiry;
            if (!DateTime.TryParseExact(expiryDate, "MM/yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out expiry) || expiry < DateTime.UtcNow)
            {
                return false;
            }

            return true;
        }





        private void applyChangeButton_Click(object sender, EventArgs e)
        {


            // Perform all validations
            if (!ValidateInputs())
            {
                return; // Stop processing if validation fails
            }


            // Collect data from the text boxes
            string mainAddress = textBox1.Text;
            string zipCode = textBox6.Text;
            string cardNumber = textBox2.Text;
            string cvv = textBox4.Text;
            string expiryDate = textBox5.Text;
            string cardHolderName = textBox3.Text;





            // Define the directory path for the user's data
            string userFolderPath = Path.Combine(@"..\..\..\..\CustomerUserFolder\", userID);

            // Ensure the user's folder exists
            if (!Directory.Exists(userFolderPath))
            {
                Directory.CreateDirectory(userFolderPath);
            }

            // Define the file path for payment.csv
            string paymentCsvPath = Path.Combine(userFolderPath, "payment.csv");

            // Prepare the CSV content
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine("Main Address,Zip Code,Card Number,CVV,Expiry Date,Card Holder Name");

            // Wrap each field in quotes to ensure that commas within fields do not split the data incorrectly
            // Use string.Format or interpolation to handle adding the quotes easily
            string csvLine = string.Format("\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\"",
                mainAddress, zipCode, cardNumber, cvv, expiryDate, cardHolderName);

            // Append the new line of data
            csvContent.AppendLine(csvLine);

            // Write the content to payment.csv
            File.WriteAllText(paymentCsvPath, csvContent.ToString());

            // Provide feedback to the user
            MessageBox.Show("Payment details have been updated.");

            // Make the text box emtpy:
            textBox1.Text = "";
            textBox6.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";


            applyChangeButton.Visible = false;
            cancelLabel.Visible = false;

            // Change back the label
            // Payment Details label
            label1.Text = "Payment Details";

            // Main Address label
            label2.Text = "Main Address:";

            // Card Number label
            label3.Text = "Card Number:";

            // Card Holder Name label
            label4.Text = "Card Holder Name:";

            CheckOrCreatePaymentCsv(userID); 
        }
    }
}
