using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Security.Cryptography; // For hasing password.


namespace FinalProject24
{
    public partial class JG_signUpPageUserControl : UserControl
    {

        public static JG_signUpPageUserControl _instance; // make an instance of the UC

        public static JG_signUpPageUserControl Instance
        {
            get
            {
                // If the instance is null, create it
                if (_instance == null)
                {
                    _instance = new JG_signUpPageUserControl();
                }
                // Return the existing or new instance
                return _instance;

            }
        }

        public JG_signUpPageUserControl()
        {
            InitializeComponent();
            HideRadioButtons();
        }

        string newEmail, newPassword, newName, confirmPassword, isCustomer, phoneNumber;


        private void createAccountButton_Click(object sender, EventArgs e)
        {
            newName = nameTextBox.Text; // save new account variables 
            newEmail = emailTextBox.Text;
            newPassword = passwordTextBox.Text;
            confirmPassword = confirmPasswordTextBox.Text;
            phoneNumber = phoneNumberTextBox.Text;

            if (!CheckPassword()) // check if the passwords match
            {
                MessageBox.Show("Passwords do not match!!!");
            }
            else
            {
                try
                {
                    // Here we call the method to handle all the account creation logic
                    bool isCreated = SaveNewAcctToCSV(newName, newEmail, newPassword, phoneNumber);

                    // Only show the success message and hide the sign-up control if the account was created
                    if (isCreated)
                    {
                        MessageBox.Show("Your account was successfully created!");
                        JG_signUpPageUserControl.Instance.SendToBack(); // go back to the login form by hiding the UC
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while creating the account: " + ex.Message);
                }

            }
        }



        //
        private bool SaveNewAcctToCSV(string name, string email, string password, string phNumber)
        {
            string relativePath = @"..\..\..\..\CustomerUserFolder\";
            string directoryPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));

            // Ensure the main CustomerUserFolder directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Check if the email already exists in allCustomerUser.csv
            string allCustomerUserPath = Path.Combine(directoryPath, "allCustomerUser.csv");
            if (File.Exists(allCustomerUserPath))
            {
                string[] allUsers = File.ReadAllLines(allCustomerUserPath);
                foreach (string user in allUsers)
                {
                    string[] userDetails = user.Split(',');
                    if (userDetails.Length >= 2 && userDetails[1].Trim().Equals(email, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("An account with this email already exists.");
                        return false; // Exit the method without creating a new account
                    }
                }
            }

            // Generate a unique UserID (using a GUID for simplicity)
            string userID = Guid.NewGuid().ToString();

            // Hash the password using SHA-256
            string hashedPassword = SecurityHelper.HashPassword(password);

            // Create the user-specific folder
            string userFolderPath = Path.Combine(directoryPath, userID);
            Directory.CreateDirectory(userFolderPath);

            // Create the password.txt file
            File.WriteAllText(Path.Combine(userFolderPath, "password.txt"), hashedPassword);

            // Create an Images directory for the user
            string imagesFolderPath = Path.Combine(userFolderPath, "Images");
            Directory.CreateDirectory(imagesFolderPath);

            // Create the profile.csv file
            string profileFilePath = Path.Combine(userFolderPath, "profile.csv");
            File.WriteAllText(profileFilePath, $"Name,Email,Phone Number,Address\n{name},{email},{phNumber},\"\"");

            // Create a receipts directory for the user
            string receiptsFolderPath = Path.Combine(userFolderPath, "receipts");
            Directory.CreateDirectory(receiptsFolderPath);

            // Append the new user to the allCustomerUser.csv
            string newUserLine = $"{userID},{email}\n";
            File.AppendAllText(allCustomerUserPath, newUserLine);

            //MessageBox.Show("Your account was successfully created!");

            return true;

        }

        private bool CheckPassword() // bool function that determines if the passwords match
        {
            bool result = false;
            if (newPassword == confirmPassword)
            {
                result = true;
            }
            return result;
        }


        private void HideRadioButtons()
        {
            customerRadioButton.Visible = false;
            managerRadioButton.Visible = false;
        }




        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            JG_signUpPageUserControl.Instance.SendToBack(); // go back to the login form by hiding the UC
        }


        private void nameTextBox_Enter(object sender, EventArgs e) // more code to make the text grey and hidden while typing
        {
            if (nameTextBox.Text == "Enter your name")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = SystemColors.WindowText;
            }
        }


        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Text = "Enter your name";
                nameTextBox.ForeColor = Color.Gray;
            }
        }


        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Enter your email")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Text = "Enter your email";
                emailTextBox.ForeColor = Color.Gray;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Enter your password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Enter your password";
                passwordTextBox.ForeColor = Color.Gray;
            }
        }

        private void confirmPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (confirmPasswordTextBox.Text == "Confirm your password")
            {
                confirmPasswordTextBox.Text = "";
                confirmPasswordTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void confirmPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                confirmPasswordTextBox.Text = "Confirm your password";
                confirmPasswordTextBox.ForeColor = Color.Gray;
            }
        }

        private void phoneNumberTextBox_Enter(object sender, EventArgs e)
        {
            if (phoneNumberTextBox.Text == "615-123-4567")
            {
                phoneNumberTextBox.Text = "";
                phoneNumberTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void phoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
            {
                phoneNumberTextBox.Text = "615-123-4567";
                phoneNumberTextBox.ForeColor = Color.Gray;
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e) // make the enter button move forward just like the tab button
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                emailTextBox.Focus();
                e.Handled = true;
            }
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                passwordTextBox.Focus();
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                confirmPasswordTextBox.Focus();
                e.Handled = true;
            }
        }

        private void confirmPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e) // and at the end of the form, make enter click the button
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                phoneNumberTextBox.Focus();
                e.Handled = true;
            }
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                createAccountButton_Click(sender, e);
                e.Handled = true;
            }
        }


    }
}
