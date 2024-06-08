using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject24
{
    public partial class JG_loginForm : Form
    {
        public JG_loginForm()
        {
            InitializeComponent(); // most up to date #2
        }

        // before implementation of a csv for email and password, use these 
        const string customerEMAIL = "123";
        const string customerPASSWORD = "123";
        const string managerEMAIL = "managerAccount@gmail.com";
        const string managerPASSWORD = "manager";


        // Loading the main form and the manager main form in memory
        //mainPageForm1 loadMainForm = new mainPageForm1();
        ManagerMainPageForm loadManagerForm = new ManagerMainPageForm();

        string userID;

        //
        private async void signinButton_Click(object sender, EventArgs e)
        {
            string inputEmail = emailTextBox.Text.Trim();
            string inputPassword = passwordTextBox.Text.Trim();

            successOrNotLabel.Text = "";

            if (string.IsNullOrWhiteSpace(inputEmail) || string.IsNullOrWhiteSpace(inputPassword))
            {
                successOrNotLabel.Text = "Please enter both an email and a password.";
                return;
            }

            if (inputEmail == managerEMAIL && inputPassword == managerPASSWORD)
            {
                Environment.SetEnvironmentVariable("EmailEnv", inputEmail);
                successOrNotLabel.ForeColor = Color.Green;
                successOrNotLabel.Text = "Success! Welcome, Manager!";
                await Task.Delay(1000);

                // Set the environment variable here for manager

                loadManagerForm.Show();
                ResetTextFields();
                this.Hide();
            }
            else
            {
                string userRole;
                string userID;
                if (AccountExists(inputEmail, inputPassword, out userRole, out userID))
                {
                    Environment.SetEnvironmentVariable("EmailEnv", inputEmail);
                    successOrNotLabel.ForeColor = Color.Green;
                    successOrNotLabel.Text = "Success! Welcome back, Customer!";
                    await Task.Delay(1000);

                    // Set the environment variable here for customer
                  

                    OpenMainForm(userID);
                }
                else
                {
                    successOrNotLabel.ForeColor = Color.Red;
                    successOrNotLabel.Text = "The email or password was incorrect.";
                    await Task.Delay(1000);
                }
            }
        }



        private void OpenMainForm(string userID)
        {
            // Check if userID is not null or empty.
            if (!string.IsNullOrEmpty(userID))
            {
                // Proceed with opening the main form with the userID
                mainPageForm1 mainForm = new mainPageForm1(userID);
                mainForm.Show(); // Show the main form
                ResetTextFields(); // Reset the text fields in the current form
                this.Hide(); // Hide the login form
            }
            else
            {
                // If userID is null or empty, show an error message.
                MessageBox.Show("User ID cannot be null or empty.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ResetTextFields()
        {
            emailTextBox.Text = "Enter your email";
            emailTextBox.ForeColor = SystemColors.WindowText;
            passwordTextBox.Text = "Enter your password";
            passwordTextBox.ForeColor = SystemColors.WindowText;
            successOrNotLabel.Text = "";
        }



        private bool EmailExistsInGlobalFile(string email)
        {
            string relativePath = @"..\..\..\..\CustomerUserFolder\allCustomerUser.csv";  // Path to the global CSV file
            string filePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length > 1 && parts[1].Trim().Equals(email, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;  // Email found in the global file
                    }
                }
            }
            return false;  // Email not found
        }


        private bool AccountExists(string email, string password, out string userRole, out string userID)
        {
            userRole = null;
            userID = null; // Initialize userID

            // First check if the email exists in the global CSV file
            if (!EmailExistsInGlobalFile(email))
            {
                Debug.WriteLine("Email does not exist in allCustomerUser.csv");
                return false;
            }

            string relativePath = @"..\..\..\..\CustomerUserFolder\";
            string directoryPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));

            if (!Directory.Exists(directoryPath))
            {
                Debug.WriteLine("Directory not found: " + directoryPath);
                return false;
            }

            foreach (string userIDFolder in Directory.GetDirectories(directoryPath))
            {
                string localUserID = Path.GetFileName(userIDFolder); // Correctly obtain the userID from the folder name
                string passwordFilePath = Path.Combine(userIDFolder, "password.txt");

                if (File.Exists(passwordFilePath))
                {
                    string storedHashedPassword = File.ReadAllText(passwordFilePath).Trim();
                    string inputHashedPassword = SecurityHelper.HashPassword(password.Trim());

                    Debug.WriteLine($"User ID: {localUserID}");
                    Debug.WriteLine($"Stored hashed password: {storedHashedPassword}");
                    Debug.WriteLine($"Input hashed password: {inputHashedPassword}");

                    if (inputHashedPassword.Equals(storedHashedPassword, StringComparison.OrdinalIgnoreCase))
                    {
                        string profileFilePath = Path.Combine(userIDFolder, "profile.csv");

                        if (File.Exists(profileFilePath))
                        {
                            string[] profileData = File.ReadAllLines(profileFilePath);
                            if (profileData.Length >= 2)
                            {
                                string[] profileFields = profileData[1].Split(',');
                                if (profileFields.Length >= 3)
                                {
                                    userRole = profileFields[2].Trim();
                                    userID = localUserID; // Set the userID here
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }


        private void signupLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!panel1.Controls.Contains(JG_signUpPageUserControl.Instance))
            { // check if there is an instance of the user control, and if not then add the instance
                panel1.Controls.Add(JG_signUpPageUserControl.Instance);
                panel1.Controls.Add(JG_blankPageUserControl.Instance);
                JG_signUpPageUserControl.Instance.Dock = DockStyle.Fill;
                JG_signUpPageUserControl.Instance.BringToFront();
                JG_blankPageUserControl.Instance.SendToBack(); // change ordering of the user controls
            }
            else
            {
                JG_signUpPageUserControl.Instance.BringToFront();
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            // also use these as a template to hide the text
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


        private void signinButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // map the enter key to do the same as clicking the button
            {
                signinButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                signinButton_Click(sender, e);
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

        private void JG_loginForm_Load(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
