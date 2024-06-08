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
    public partial class NS_MEditPageUserControl1 : UserControl
    {
        public NS_MEditPageUserControl1()
        {
            InitializeComponent();
        }
        public class MenuItem
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public Image ItemImage { get; set; } // The actual image
            public string ImagePath { get; set; } // The path to the image file
        }

        private List<MenuItem> menuItems = new List<MenuItem>();

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            // Should open file, allow you to choose an image then it should display the image in the pic box.
            // Create and configure an OpenFileDialog instance
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Image";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the selected file name and display it in a PictureBox
                    string selectedImagePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during file loading
                    MessageBox.Show("Error: Could not open selected image file. " + ex.Message);
                }
            }
        }

        private string csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\MenuItemsUpdated.csv");
        private string imagesFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string itemID = MenuIDtextBox.Text;
            string itemName = NametextBox.Text;
            if (!decimal.TryParse(PricetextBox.Text, out decimal itemPrice))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }
            string selectedImagePath = pictureBox.Image?.Tag as string; // The image path is stored in the Tag property

            // Load existing items
            List<MenuItem> items = LoadMenuItems();

            // Check if the item with the ID exists and update or add it
            var existingItem = items.FirstOrDefault(item => item.ID == itemID);
            if (existingItem != null)
            {
                // Update existing item
                existingItem.Name = itemName;
                existingItem.Price = itemPrice;
                if (!string.IsNullOrWhiteSpace(selectedImagePath))
                {
                    existingItem.ItemImage = pictureBox.Image;
                }
            }
            else
            {
                // Add new item if the ID doesn't exist
                items.Add(new MenuItem
                {
                    ID = itemID,
                    Name = itemName,
                    Price = itemPrice,
                    ItemImage = pictureBox.Image // Set the image
                });
            }

            // Save the image file to the "Images" folder, if a new image was chosen
            if (!string.IsNullOrWhiteSpace(selectedImagePath))
            {
                string fileName = Path.GetFileName(selectedImagePath);
                string saveImagePath = Path.Combine(imagesFolderPath, fileName);
                pictureBox.Image.Save(saveImagePath);
                // Update the image path for the new item or the existing item
                if (existingItem != null)
                {
                    existingItem.ImagePath = fileName;
                }
                else
                {
                    items.Last().ImagePath = fileName;
                }
            }

            // Save all items back to the CSV
            SaveMenuItems(items);

            MessageBox.Show("Menu item changes saved successfully.");

            // Clear input fields and the PictureBox
            MenuIDtextBox.Clear();
            NametextBox.Clear();
            PricetextBox.Clear();
            pictureBox.Image = null;
        }

        private List<MenuItem> LoadMenuItems()
        {
            var items = new List<MenuItem>();
            if (File.Exists(csvFilePath))
            {
                var lines = File.ReadAllLines(csvFilePath);
                foreach (var line in lines.Skip(1)) // Skip header line
                {
                    var columns = line.Split(',');
                    if (columns.Length >= 4)
                    {
                        items.Add(new MenuItem
                        {
                            ID = columns[0],
                            Name = columns[1],
                            Price = decimal.Parse(columns[2]),
                            ItemImage = LoadImage(columns[3])
                        });
                    }
                }
            }
            return items;
        }

        private Image LoadImage(string imageName)
        {
            string imagePath = Path.Combine(imagesFolderPath, imageName);
            return File.Exists(imagePath) ? Image.FromFile(imagePath) : null;
        }

        private void SaveMenuItems(List<MenuItem> items)
        {
            using (var writer = new StreamWriter(csvFilePath, false))
            {
                writer.WriteLine("ID,Name,Price,ImagePath"); // Assuming these are the headers
                foreach (var item in items)
                {
                    writer.WriteLine($"{item.ID},{item.Name},{item.Price},{item.ImagePath ?? string.Empty}");
                }
            }
        }
    }
}