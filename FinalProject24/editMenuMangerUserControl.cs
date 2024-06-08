using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject24
{
    // UserControl for managing menu items in a restaurant application.
    public partial class editMenuMangerUserControl : UserControl
    {
        // Class to represent a menu item.
        public class MenuItem
        {
            public string MenuID { get; set; }
            public string MenuName { get; set; }
            public string MenuPrice { get; set; }
            public string ImagePath { get; set; }
            public bool Status { get; set; } // True if the menu item is active, false otherwise.
        }

        // Path to the CSV file where menu items are stored.
        private string csvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\MenuItemsUpdated.csv");
        // Path to the folder where menu item images are stored.
        private string imagesFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\Images");
        // The file name of the selected image for a menu item.
        private string selectedImageFileName;

        // Singleton instance of this UserControl.
        public static editMenuMangerUserControl _instance;

        // Property to get the singleton instance of this UserControl.
        public static editMenuMangerUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new editMenuMangerUserControl();
                }
                return _instance;
            }
        }

        // Constructor that initializes components and creates the images directory if it doesn't exist.
        public editMenuMangerUserControl()
        {
            InitializeComponent();
            Directory.CreateDirectory(imagesFolderPath);
        }

        // Loads menu items from a CSV file and returns them as a list of MenuItem.
        private List<MenuItem> LoadMenuItems()
        {
            var items = new List<MenuItem>();
            if (File.Exists(csvFilePath))
            {
                string[] lines = File.ReadAllLines(csvFilePath);
                foreach (var line in lines.Skip(1)) // Skip the header line.
                {
                    var columns = line.Split(',');
                    if (columns.Length >= 5) // Ensure there are enough columns.
                    {
                        items.Add(new MenuItem
                        {
                            MenuName = columns[0].Trim(),
                            MenuPrice = columns[1].Trim(),
                            MenuID = columns[2].Trim(),
                            ImagePath = columns[3].Trim(),
                            Status = columns[4].Trim().Equals("TRUE", StringComparison.OrdinalIgnoreCase) // Parse the status as a boolean.
                        });
                    }
                }
            }
            else
            {
                MessageBox.Show("The CSV file does not exist.");
            }
            return items;
        }

        // Saves a list of MenuItem to the CSV file.
        private void SaveMenuItems(List<MenuItem> items)
        {
            using (StreamWriter writer = new StreamWriter(csvFilePath, false))
            {
                writer.WriteLine("Food Name,Price,ID,Image Path,Status"); // Write the header line.
                foreach (var item in items)
                {
                    writer.WriteLine($"{item.MenuName},{item.MenuPrice},{item.MenuID},{item.ImagePath},{item.Status}");
                }
            }
        }

        // Event handler for the "Select Image" button. Opens a dialog to choose an image file.
        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                selectedImageFileName = Path.GetFileName(openFileDialog.FileName);
            }
        }

        // Generates a unique file path if the same file name already exists.
        private string GetUniqueImagePath(string baseFilePath)
        {
            string filePath = baseFilePath;
            string directory = Path.GetDirectoryName(baseFilePath);
            string fileName = Path.GetFileNameWithoutExtension(baseFilePath);
            string extension = Path.GetExtension(baseFilePath);
            int count = 1;

            while (File.Exists(filePath))
            {
                filePath = Path.Combine(directory, $"{fileName}_{count}{extension}");
                count++;
            }

            return filePath;
        }

        // Event handler for the "Apply Changes" button. Updates or adds menu items based on user input.
        private void ApplyChangeButton_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string price = textBox3.Text;
            bool status = checkBox1.Checked;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Menu ID cannot be empty.");
                return;
            }

            List<MenuItem> items = LoadMenuItems();
            var existingItem = items.FirstOrDefault(i => i.MenuID == id);

            // Update an existing item or add a new one.
            if (existingItem != null)
            {
                existingItem.MenuName = name;
                existingItem.MenuPrice = price;
                existingItem.Status = status;

                // Update image if a new one is selected.
                if (!string.IsNullOrWhiteSpace(selectedImageFileName))
                {
                    string filePath = Path.Combine(imagesFolderPath, selectedImageFileName);

                    if (File.Exists(filePath))
                    {
                        filePath = GetUniqueImagePath(filePath);
                        selectedImageFileName = Path.GetFileName(filePath);
                    }

                    existingItem.ImagePath = selectedImageFileName;

                    // Save the image using a temporary Bitmap to avoid file locking issues.
                    using (var tempImage = new Bitmap(pictureBox1.Image))
                    {
                        tempImage.Save(filePath);
                    }
                }
            }
            else
            {
                // Add a new item if ID does not exist.
                if (string.IsNullOrWhiteSpace(selectedImageFileName))
                {
                    MessageBox.Show("Please select an image for the menu item.");
                    return;
                }

                var newItem = new MenuItem
                {
                    MenuID = id,
                    MenuName = name,
                    MenuPrice = price,
                    ImagePath = selectedImageFileName,
                    Status = status
                };
                items.Add(newItem);

                string newFilePath = Path.Combine(imagesFolderPath, selectedImageFileName);

                if (File.Exists(newFilePath))
                {
                    newFilePath = GetUniqueImagePath(newFilePath);
                    newItem.ImagePath = Path.GetFileName(newFilePath);
                }

                // Save the image using a temporary Bitmap to avoid file locking issues.
                using (var tempImage = new Bitmap(pictureBox1.Image))
                {
                    tempImage.Save(newFilePath);
                }
            }

            SaveMenuItems(items); // Save changes to CSV file.

            MessageBox.Show("The menu item has been updated successfully.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            pictureBox1.Image = null;
            selectedImageFileName = null;
        }
    }
}
