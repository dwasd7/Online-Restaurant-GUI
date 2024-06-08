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
    public partial class orderHistoryDetailsUserControl : UserControl
    {
        public orderHistoryDetailsUserControl()
        {
            InitializeComponent();
        }

        public void UpdateOrderHistoryDetails(string orderNumber, string date)
        {
            orderNumberTextLabel.Text = orderNumber;
            dateTextLabel.Text = date;
        }

        public void LoadOrderDetails(string filePath)
        {
            StringBuilder detailBuilder = new StringBuilder();
            try
            {
                // Read all lines from the CSV file
                var lines = File.ReadAllLines(filePath);
                decimal subtotal = 0;
                decimal taxRate = 0.07m; // Assuming tax rate is 7%

                // Process each line except the first (headers) and last three (subtotals and totals)
                for (int i = 1; i < lines.Length - 3; i++)
                {
                    var columns = lines[i].Split(',');
                    if (columns.Length >= 4)
                    {
                        string itemName = columns[0];
                        int quantity = int.Parse(columns[1]);
                        decimal price = decimal.Parse(columns[2].TrimStart('$'));
                        decimal total = decimal.Parse(columns[3].TrimStart('$'));

                        subtotal += total;


                        // Format each item's details
                        detailBuilder.AppendLine($"Item: {itemName}");
                        detailBuilder.AppendLine($"Qty: {quantity}");
                        detailBuilder.AppendLine($"Subtotal: ${total:0.00}");
                        detailBuilder.AppendLine(); // Empty line

                    }
                }

                // Calculate tax and total
                decimal tax = subtotal * taxRate;
                decimal totalAmount = subtotal + tax;

                // Add subtotal, tax, and total to the details
                detailBuilder.AppendLine($"Subtotal: ${subtotal:0.00}");
                detailBuilder.AppendLine($"Tax: ${tax:0.00}");
                detailBuilder.AppendLine($"Total: ${totalAmount:0.00}");

                string orderNumber = Path.GetFileNameWithoutExtension(filePath);
                string date = orderNumber.Split('_')[0];
                date = date.Substring(0, date.Length - 6);
                date = $"{date.Substring(4, 2)}/{date.Substring(6, 2)}/{date.Substring(0, 4)}";
                UpdateOrderHistoryDetails(orderNumber, date);

            }
            catch (Exception ex)
            {
                // Handle any errors that might occur during file reading or parsing
                MessageBox.Show($"Error loading order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Display the formatted details
            displayDetailText.Text = detailBuilder.ToString();
        }

    }
}
