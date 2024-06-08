using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace FinalProject24
{
    public partial class mainPageForm1 : Form
    {
        // update image paths here to save time changing the path name
        string imagePathProfilePicture = @"..\..\..\..\Images\newDefaultProfilePicture.jpg"; // Going back 4 level

        private CartUC cartUCInstance;

        // Field to store userID
        private string userID;

        public mainPageForm1(string userID)
        {
            InitializeComponent();
            this.userID = userID; // Assign the passed userID to the field
            LoadUserProfile(userID);

            // For Loading Circular Shape image.
            try
            {
                // Load the image from a file and set it to the roundPictureBox1
                roundPictureBox1.Image = Image.FromFile(imagePathProfilePicture); // Make sure to provide the correct path
                //roundPictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // This will ensure the image fits within the roundPictureBox1
                roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("The specified image file cannot be found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            cartUCInstance = new CartUC();


            orderHistoryPanel.Visible = false;
            mainPanel.Visible = true;
            cartUCInstance = CartUC.Instance;
            cartUCInstance.CartItemsChanged += CartUCInstance_CartItemsChanged;
            cartUCInstance.NavigateToPayment += NavigateToPaymentUserControl;

        }

        int count = 0; // To count the item


        //............
        //public int TotalQuantity => selectedItems.Sum(item => item.Quantity);


        public struct cartArray
        {
            public string Title;
            public decimal Price;
            public string ImagePath;
            public int Quantity;
        }

        private void LoadUserProfile(string userID)
        {
            // First, check if userID is null or empty
            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("User ID cannot be null or empty.");
                return;
            }

            // Define the directory where the user folders are stored
            string relativePath = @"..\..\..\..\CustomerUserFolder\"; // Adjust this path as needed
            string directoryPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));

            if (!Directory.Exists(directoryPath))
            {
                MessageBox.Show("Directory not found: " + directoryPath);
                return;
            }

            string userFolderPath = Path.Combine(directoryPath, userID);
            string profileFilePath = Path.Combine(userFolderPath, "profile.csv");

            if (!File.Exists(profileFilePath))
            {
                MessageBox.Show("Profile file not found for user: " + userID);
                return;
            }

            // Read the profile.csv file and load user profile data
            try
            {
                string[] profileData = File.ReadAllLines(profileFilePath);
                if (profileData.Length >= 2)
                {
                    string[] profileFields = profileData[1].Split(',');
                    if (profileFields.Length >= 4) // Assuming there are 4 columns: Name, Email, Phone Number, Address
                    {
                        string name = profileFields[0].Trim();
                        string email = profileFields[1].Trim();
                        string phoneNumber = profileFields[2].Trim();
                        string address = profileFields[3].Trim();

                        nameLabel.Text = name;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }


        private void NavigateToPaymentUserControl(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(PaymentUserControl1.Instance))
            {
                mainPanel.Controls.Add(PaymentUserControl1.Instance);
                PaymentUserControl1.Instance.SetUserID(userID);  // Set the userID for the instance
                PaymentUserControl1.Instance.Dock = DockStyle.Fill;
                
                PaymentUserControl1.Instance.BringToFront();
                PaymentUserControl1.Instance.CartItems = cartUCInstance.GetCartItems();
            }
            else
            {
                PaymentUserControl1.Instance.SetUserID(userID);
                PaymentUserControl1.Instance.BringToFront();
            }
            mainPanel.Visible = true;
            menuPanel.Visible = false;
            menuLabel.Visible = false;
        }

        private void CartUCInstance_CartItemsChanged(object sender, EventArgs e)
        {
            // This method is called whenever the cart items are changed
            UpdateSelectedItemsFromCart();
        }


        private void UpdateSelectedItemsFromCart()
        {
            selectedItems = cartUCInstance.GetCartItems()
                .Select(item => new cartArray
                {
                    Title = item.FoodName,
                    Price = item.Price,
                    ImagePath = item.ImagePath,
                    Quantity = item.Quantity
                }).ToList();

            // Calculate the total quantity by summing the Quantity of each item
            count = selectedItems.Sum(item => item.Quantity);
            cartButton.Text = "Carts: " + count.ToString();
        }

        private List<cartArray> selectedItems = new List<cartArray>();

        // For + button
        // For handling card incremnt event and storing selected item to a list
        private void Card_AddButtonClicked(object sender, EventArgs e)
        {
            // Cast the sender to menuCardUserControl
            menuCardUserControl card = sender as menuCardUserControl;

            // Check if the cast was successful
            if (card != null)
            {
                cartArray item = new cartArray
                {
                    Title = card.ItemName,
                    Price = Decimal.Parse(card.ItemPrice.Replace("$", "")),
                    ImagePath = card.ImagePath // Access the ImagePath property
                };

                selectedItems.Add(item); // Add to the list
                count++;
                cartButton.Text = "Carts: " + count.ToString();
            }



            //MessageBox.Show(count.ToString());
        }




        // For handling - (remove) Button
        private void Card_RemoveButtonClicked(object sender, EventArgs e)
        {
            if (sender is menuCardUserControl card)
            {
                // Initialize a variable to store the index of the item to remove
                int indexToRemove = -1;

                // Looping through the list to find the item
                for (int i = 0; i < selectedItems.Count; i++)
                {
                    if (selectedItems[i].Title == card.ItemName)
                    {
                        indexToRemove = i;
                        break; // Stop the loop once we found the item
                    }
                }

                // Checking if we found an item to remove
                if (indexToRemove != -1)
                {
                    selectedItems.RemoveAt(indexToRemove); // Remove the item from the list
                    count--; // Decrement the count
                    cartButton.Text = "Carts: " + count.ToString(); // Update the cart count display

                }
            } // If line End

        }



        // MenuItem class to hold the data for each menu item
        public class MenuItem
        {
            public string FoodName { get; set; }
            public decimal Price { get; set; }
            public string ImagePath { get; set; }
            public string ID { get; set; } // Added ID property
        }

        // Reading menu data from CSV file.
        private List<MenuItem> LoadMenuItemsFromCsv()
        {
            string filePath = @"..\..\..\..\MenuItemsUpdated.csv";
            List<MenuItem> menuItems = new List<MenuItem>();

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"CSV file not found at path: {filePath}");
                return menuItems;
            }

            try
            {
                var lines = File.ReadAllLines(filePath);
                if (lines.Length <= 1)
                {
                    MessageBox.Show("CSV file is empty or only contains the header.");
                    return menuItems;
                }

                // Define the regex pattern for CSV fields
                var csvPattern = new Regex("(?:^|,)(\"(?:[^\"]+|\"\")*\"|[^,]*)", RegexOptions.Compiled);

                foreach (var line in lines.Skip(1))
                {
                    var matches = csvPattern.Matches(line);
                    var columns = matches.Cast<Match>().Select(m => m.Value.TrimStart(',').Replace("\"", "").Trim()).ToArray();

                    if (columns.Length < 4)
                    {
                        MessageBox.Show($"Entry does not have enough columns: {line}");
                        continue;
                    }

                    string status = columns[4]; 

                    //MessageBox.Show($"Line: {line}\nParsed Columns: {string.Join("|", columns)}\nStatus read from CSV: '{status}'");

                    if (status.Equals("TRUE", StringComparison.OrdinalIgnoreCase))
                    {
                        // Try to parse the price and add the item if successful
                        if (decimal.TryParse(columns[1].Trim(), out decimal price))
                        {
                            menuItems.Add(new MenuItem
                            {
                                FoodName = columns[0].Trim(),
                                Price = price,
                                ImagePath = columns[3].Trim(), // Index for Image Path
                                ID = columns[2].Trim() // Index for ID
                            });
                        }
                        else
                        {
                            MessageBox.Show($"Price parsing failed for entry: {line}");
                        }
                    }
                    else
                    {
                        // For deubuging.
                        //MessageBox.Show($"Entry skipped because status is not TRUE: {line}");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the CSV file: {ex.Message}");
            }

            return menuItems;
        }



        private void PopulateMenuPanel()
        {
            var menuItems = LoadMenuItemsFromCsv();

            // Clear the panel of previous items
            menuPanel.Controls.Clear();
            menuPanel.AutoScroll = true;

            int controlSpacing = 15; // Spacing between controls
            int controlWidth = 214; // Width of the user control
            int controlHeight = 178; // Height of the user control
            int numControlsPerRow = menuPanel.Width / controlWidth; // Calculate how many controls fit per row



            // Get the base directory of the application
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construct the path to the images folder
            string imagesFolderPath = Path.Combine(baseDirectory, @"..\..\..\..\Images\");
            for (int i = 0; i < menuItems.Count; i++)
            {
                var menuItem = menuItems[i];
                var menuCard = new menuCardUserControl();



                // Set the properties of the user control
                menuCard.ItemName = menuItem.FoodName;
                menuCard.ItemPrice = menuItem.Price.ToString("C"); // Format as currency
                menuCard.GetIDText = "#" + menuItem.ID;
                

                // Set the size of the control
                menuCard.Size = new Size(controlWidth, controlHeight);



                // Calculate and set the location of the control
                menuCard.Location = new Point(
                    (i % numControlsPerRow) * (controlWidth + controlSpacing), // X position
                    (i / numControlsPerRow) * (controlHeight + controlSpacing) // Y position
                );

                // Construct the full path to the image file and load the image
                try
                {
                    string imagePath = Path.Combine(imagesFolderPath, menuItem.ImagePath);
                    imagePath = Path.GetFullPath(imagePath); // Resolves to the absolute path

                    if (File.Exists(imagePath))
                    {
                        menuCard.ItemImage = Image.FromFile(imagePath);
                        menuCard.ImagePath = imagePath;
                    }
                    else
                    {
                        // Use an empty image or a default image as a placeholder
                        menuCard.ItemImage = new Bitmap(1, 1);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions if image loading fails
                    MessageBox.Show($"Failed to load image: {ex.Message}");
                }


                menuCard.AddButtonClicked += Card_AddButtonClicked;
                menuCard.RemoveButtonClicked += Card_RemoveButtonClicked;


                // Add the menu card to the panel
                menuPanel.Controls.Add(menuCard);
            }
        }


        // This is load when the Form is loaded.
        private void mainPageForm1_Load(object sender, EventArgs e)
        {
            PopulateMenuPanel();
            mainPanel.Visible = false;
        } // mainPageForm1_Load End Line


        private void cartButton_Click(object sender, EventArgs e)
        {
            orderHistoryPanel.Visible = false;

            // Check if CartUC instance is null or not already added to the main panel
            if (cartUCInstance == null || !mainPanel.Controls.Contains(cartUCInstance))
            {
                if (cartUCInstance == null)
                {
                    cartUCInstance = new CartUC();
                }
                mainPanel.Controls.Add(cartUCInstance);
                cartUCInstance.Dock = DockStyle.Fill;
            }

            // Bring the CartUC instance to the front
            cartUCInstance.BringToFront();

            // Convert the selectedItems to CartItem objects
            var itemsToLoad = selectedItems.Select(item => new CartItem
            {
                FoodName = item.Title,
                Price = item.Price,
                RestaurantName = "",
                Quantity = 1,
                ImagePath = item.ImagePath // Include the image path
            }).ToList();

            // Load the items into the cart
            cartUCInstance.LoadCartItems(itemsToLoad);

            // Set visibility to switch to the cart view
            mainPanel.Visible = true;
            menuPanel.Visible = false;
            menuLabel.Visible = false;

        }



        private void paymentButton_Click(object sender, EventArgs e)
        {
            orderHistoryPanel.Visible = false;

            // Create the instance if it does not exist
            if (!mainPanel.Controls.Contains(PaymentUserControl1.Instance))
            {
                mainPanel.Controls.Add(PaymentUserControl1.Instance);
                PaymentUserControl1.Instance.Dock = DockStyle.Fill;
            }

            // Set the userID for the PaymentUserControl1 instance
            //string userID = "theUserID"; // Retrieve the actual userID from the context
            PaymentUserControl1.Instance.SetUserID(userID);

            // Make sure the PaymentUserControl1 is visible
            PaymentUserControl1.Instance.BringToFront();

            mainPanel.Visible = true;
            menuPanel.Visible = false;
            menuLabel.Visible = false;
        }



        private void homeButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Visible = false; // Hide the mainPanel
            menuPanel.Visible = true; // Show the menuPanel
            menuLabel.Visible = true;
            orderHistoryPanel.Visible = false;

        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            // Hide unrelated panels
            orderHistoryPanel.Visible = false;
            menuPanel.Visible = false;
            menuLabel.Visible = false;
            NS_AccountSettingPageUserControl1.Instance.ClearTextBoxes();
            // Get the user email from environment variable
            string userEmail = Environment.GetEnvironmentVariable("EmailEnv");
            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Email environment variable is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit if no email set
            }

            // Set the UserEmail
            NS_AccountSettingPageUserControl1.Instance.UserEmail = userEmail;

            // Check if the user control is already added to the main panel
            if (!mainPanel.Controls.Contains(NS_AccountSettingPageUserControl1.Instance))
            {
                mainPanel.Controls.Add(NS_AccountSettingPageUserControl1.Instance);
                NS_AccountSettingPageUserControl1.Instance.Dock = DockStyle.Fill;
            }

            // Load user data, update text boxes, and ensure the user control is in front
            NS_AccountSettingPageUserControl1.Instance.LoadUserData();
            NS_AccountSettingPageUserControl1.Instance.UpdateTextBoxes();
            NS_AccountSettingPageUserControl1.Instance.BringToFront();

            // Make sure the main panel is visible
            mainPanel.Visible = true;
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form oForm = Application.OpenForms[i];
                if (oForm is mainPageForm1 || oForm is JG_loginForm || oForm is ManagerMainPageForm)
                {
                    oForm.Close();
                }
            }
            this.Close();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            // add logic to clear the cart and also any user information here

            foreach (Form oForm in Application.OpenForms)
            {
                if (oForm is JG_loginForm)
                {
                    oForm.Show();
                }
            }
            this.Hide();
        }


        private void HistoryCard_ViewDetailsClicked(object sender, EventArgs e)
        {
            if (sender is orderHistoryCard historyCard)
            {
                // Assuming the order number is set as a Tag or similar property
                string filePath = Path.Combine(@"..\..\..\..\receipts\", $"{historyCard.orderNumberText.Replace("Order #", "").Trim()}.csv");

                orderSummaryPanel.Controls.Clear(); // Clear previous details if any
                orderHistoryDetailsUserControl detailsControl = new orderHistoryDetailsUserControl();
                detailsControl.LoadOrderDetails(filePath); // Load details from the file associated with the order
                orderSummaryPanel.Controls.Add(detailsControl); // Add the details control to the summary panel
            }
        }



        private void orderButton_Click(object sender, EventArgs e)
        {

            // Ensure the order list panel is cleared before adding new items
            orderListPanel.Controls.Clear();

            // Define the path to the receipts directory
            string receiptsPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\receipts\"));

            // Check if the directory exists and get all CSV files
            if (Directory.Exists(receiptsPath))
            {
                string[] files = Directory.GetFiles(receiptsPath, "*.csv");
                int yOffset = 0;  // Initialize an offset for the Y position.

                foreach (string file in files)
                {

                    try
                    {
                        // Read the CSV file to get the order details
                        string[] lines = File.ReadAllLines(file);
                        if (lines.Length > 1 && lines.Any(line => line.StartsWith("Total,")))  // Check if there is a "Total" line
                        {
                            // Extract order details from the lines
                            string orderNumber = Path.GetFileNameWithoutExtension(file);
                            string date = DateTime.Now.ToString("yyyy-MM-dd");  // Assuming you want today's date or extract from the file name
                            decimal total = Convert.ToDecimal(lines.Last(line => line.StartsWith("Total,")).Split(',')[2].Replace("$", "").Trim()); // Total is on the last line
                            // Create the order history card
                            orderHistoryCard historyCard = new orderHistoryCard
                            {
                                dateText = date,
                                totalText = $"${total:0.00}",
                                statusText = "Completed",  // Assuming status is completed for past orders
                                orderNumberText = "Order #" + orderNumber,
                                Size = new Size(310, 77),
                                Tag = file  // Store the path to the CSV file in the Tag property
                            };
                            historyCard.Location = new Point(0, yOffset);  // Set the location for each card.
                            yOffset += historyCard.Height + 10;  // Increment yOffset for the next card.
                            // Add the order history card to the panel
                            orderListPanel.Controls.Add(historyCard);

                            // Subscribe to the ViewDetailsClicked event
                            historyCard.ViewDetailsClicked += HistoryCard_ViewDetailsClicked;
                        }
                        else
                        {
                            // Log the issue with the current file and continue with the next one
                            MessageBox.Show($"The file {file} is not in the expected format or does not contain a total.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the exception and continue with the next file
                        MessageBox.Show($"An exception occurred while processing the file {file}: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Receipts directory does not exist.", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Make the order panel visible
            orderHistoryPanel.Visible = true;
            menuPanel.Visible = false;
            menuLabel.Visible = false;
            mainPanel.Visible = true; // Show the main panel if needed

            // Make sure the panel can scroll if needed
            orderListPanel.AutoScroll = true;
        }

    } // mainPageForm1 End Line
}
