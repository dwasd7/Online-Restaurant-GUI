using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalProject24.NS_MEditPageUserControl1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinalProject24
{
    public partial class NS_ResOwnSetPageUserControl1 : UserControl
    {
        string profileName;
        string profileEmail;
        string profileAddress;
        string profileNumber;

        public class Profile
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public Image ProfileImage { get; set; } // New property for image
        }

        public NS_ResOwnSetPageUserControl1()
        {
            InitializeComponent();
        }

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
                    NewPictureBox.Image = Image.FromFile(selectedImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not open selected image file. " + ex.Message);
                }
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {

            // Retrieve the text entered by the user in the TextBoxes
            
            string profileName = NameTextBox.Text;
            string profileEmail = EmailTextBox.Text;
            string profileAddress = AddressTextBox.Text;
            string profileNumber = NumberTextBox.Text;

            // Create a new Profile Object ???
            Profile newProfile = new Profile
            {
                Name = profileName,
                Email = profileEmail,
                Address = profileAddress,
                PhoneNumber = profileNumber,
                ProfileImage = NewPictureBox.Image // Set the image from the PictureBox
            };

            // Update labels with the new profile information
            NameLabel.Text = newProfile.Name;
            EmailLabel.Text = newProfile.Email;
            AddressLabel.Text = newProfile.Address;
            NumberLabel.Text = newProfile.PhoneNumber;


            MessageBox.Show("Profile Edited successfully.");


            NameTextBox.Clear();
            EmailTextBox.Clear();
            AddressTextBox.Clear();
            NumberTextBox.Clear();
            NewPictureBox.Image = null;
        }
    }
}
