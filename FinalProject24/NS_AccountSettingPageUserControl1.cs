using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;


namespace FinalProject24 { 

    public partial class NS_AccountSettingPageUserControl1 : UserControl
    {
        // instance to ensure only one instance of this user control is created
        private static NS_AccountSettingPageUserControl1 _instance;

        // Dictionary to store user details.
        // keys are the data field names like "Email", "Name"
        private Dictionary<string, string> userDetails = new Dictionary<string, string>();

        // Stores the email of the user currently logged in or being edited
        private string userEmail;

        // Constant string to define the path to the folder containing user CSV files
        private const string CsvFolderPath = @"../../../../CustomerUserFolder";

        // Property to get the single instance of this UserControl
        public static NS_AccountSettingPageUserControl1 Instance
        {
            get
            {
                // Check if an instance already exists
                // if not, create one
                if (_instance == null)
                {
                    _instance = new NS_AccountSettingPageUserControl1();
                }
                return _instance;
            }
        }

        // Property to manage the user's email used throughout the UserControl
        public string UserEmail
        {
            // Getter returns the current email
            get => userEmail;
            set
            {
                // Setter updates the email if it is different from the current value
                if (userEmail != value)
                {
                    userEmail = value;
                    ClearUserData(); // Clears existing user data
                    LoadUserData();  // Loads new user data based on the new email
                    UpdateTextBoxes(); // Updates UI text boxes with new user data
                }
            }
        }

        // Constructor of the UserControl
        public NS_AccountSettingPageUserControl1()
        {
            // Initializes component settings
            InitializeComponent(); 
            // Gets user email from environment variables
            UserEmail = Environment.GetEnvironmentVariable("EmailEnv"); 
            LoadUserData(); 
            UpdateTextBoxes();
        }

        // Clears all user data stored in the userDetails dictionary
        private void ClearUserData()
        {
            userDetails.Clear();
        }
        private void UpdateGlobalCsvFile(string oldEmail, string newEmail)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), CsvFolderPath, "allCustomerUser.csv");

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath).ToList();
                bool updated = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    var parts = lines[i].Split(',');
                    if (parts.Length > 1 && parts[1].Trim().Equals(oldEmail, StringComparison.OrdinalIgnoreCase))
                    {
                        parts[1] = newEmail; // Update the email
                        lines[i] = string.Join(",", parts);
                        updated = true;
                        break;
                    }
                }

                if (updated)
                {
                    File.WriteAllLines(filePath, lines);
                    MessageBox.Show("Global user data updated successfully!");
                }
                else
                {
                    MessageBox.Show("No matching email found to update in global file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Global CSV file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Loads user data from a CSV file based on the current userEmail
        public void LoadUserData()
        {
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), CsvFolderPath); // Combines paths to form the full directory path

            // Iterates over each subfolder in the directory to find the correct user's CSV file
            foreach (var subFolder in Directory.GetDirectories(directoryPath))
            {
                string profilePath = Path.Combine(subFolder, "profile.csv"); // Gets the path to the profile CSV file
                if (File.Exists(profilePath)) // Checks if the file exists
                {
                    var lines = File.ReadAllLines(profilePath); // Reads all lines from the file
                    if (lines.Length > 1) // Ensures there is more than just the header line
                    {
                        var headers = lines[0].Split(',').Select(h => h.Trim()).ToList(); // Splits the first line into headers
                        var values = lines[1].Split(',').Select(v => v.Trim()).ToList(); // Splits the second line into values

                        int emailIndex = headers.IndexOf("Email"); // Finds the index of the "Email" header
                        if (emailIndex != -1 && values[emailIndex].Equals(userEmail, StringComparison.OrdinalIgnoreCase)) // Checks if the email matches
                        {
                            for (int i = 0; i < headers.Count; i++) // Iterates over all headers
                            {
                                userDetails[headers[i]] = values[i]; // Stores each value in the userDetails dictionary
                            }
                            break; // Breaks the loop once the correct file is found
                        }
                    }
                }
            }

            // If no data was loaded, shows an error message
            if (userDetails.Count == 0)
            {
                MessageBox.Show("No user data file found for the provided email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Updates the text boxes on the form with data from userDetails
        public void UpdateTextBoxes()
        {
            if (InvokeRequired) // Checks if the call is from a different thread
            {
                this.Invoke(new Action(UpdateTextBoxes)); // Invokes the method on the UI
                return;
            }

            // Sets text box values based on userDetails content, or defaults if key is missing
            NametextBox.Text = userDetails.ContainsKey("Name") ? userDetails["Name"] : "Default Name";
            EmailtextBox.Text = userDetails.ContainsKey("Email") ? userDetails["Email"] : "Default Email";
            PhonetextBox.Text = userDetails.ContainsKey("Phone Number") ? userDetails["Phone Number"] : "Default Phone Number";
        }


        // Event handler for when the 'Apply' button is clicked
        private void Applybutton_Click(object sender, EventArgs e)
        {
            // Gets the new email from the text box
            string newEmail = textBox4.Text.Trim();

            // Check if the current email is for the manager account and if the new email is different
            if (userEmail.Equals("managerAccount@gmail.com") && !newEmail.Equals(userEmail))
            {
                MessageBox.Show("This is a manager account; you cannot change the email. Please enter managerAccount@gmail.com as email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exits the method to prevent further processing
            }

            // check if the text boxes are not empty
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please enter data for every text box!");
                return; // exits the method since it should not save blank data
            }

            // Refreshes userEmail from environment variable
            UserEmail = Environment.GetEnvironmentVariable("EmailEnv");

            // Collects new values from text boxes
            string newName = textBox3.Text.Trim();
            string newPhone = textBox5.Text.Trim();

            // Saves the old email to help locate the correct CSV record
            string oldEmail = UserEmail;

            // Updates userDetails with the new values
            userDetails["Name"] = newName;
            userDetails["Email"] = newEmail;
            userDetails["Phone Number"] = newPhone;

            // Finds the CSV file path using the old email
            string filePath = FindCsvFilePath(oldEmail);
            if (!string.IsNullOrEmpty(filePath))
            {
                UpdateCsvFile(filePath); // Update individual profile
                UpdateGlobalCsvFile(oldEmail, newEmail); // Update global file
                MessageBox.Show("Changes saved successfully!");

                UserEmail = newEmail; // Update the global email variable
                Environment.SetEnvironmentVariable("EmailEnv", newEmail);
                LoadUserData(); // Reload user data based on new email
                UpdateTextBoxes(); // Update UI text boxes with new data
            }
            else
            {
                MessageBox.Show("Failed to find the CSV file to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Updates the CSV file with new user details
        private void UpdateCsvFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath).ToList(); // Reads all lines from the CSV file
            var headers = lines[0].Split(',').Select(h => h.Trim()).ToList(); // Extracts headers from the first line

            // Finds indices for columns 'Email', 'Name', and 'Phone Number'
            int emailIndex = headers.IndexOf("Email");
            int nameIndex = headers.IndexOf("Name");
            int phoneNumberIndex = headers.IndexOf("Phone Number");

            List<string> updatedLines = new List<string> { lines[0] }; // Starts with the header line

            for (int i = 1; i < lines.Count; i++)
            {
                var fields = lines[i].Split(',').Select(f => f.Trim()).ToArray();
                if (fields.Length > emailIndex && fields[emailIndex].Equals(UserEmail, StringComparison.OrdinalIgnoreCase))
                {
                    // Updates the necessary fields if the current line is the user's line
                    if (nameIndex != -1) fields[nameIndex] = userDetails["Name"];
                    if (emailIndex != -1) fields[emailIndex] = userDetails["Email"];
                    if (phoneNumberIndex != -1) fields[phoneNumberIndex] = userDetails["Phone Number"];

                    updatedLines.Add(string.Join(",", fields)); // Adds the updated line back to the list
                }
                else
                {
                    updatedLines.Add(lines[i]); // Adds unchanged lines back to the list
                }
            }

            File.WriteAllLines(filePath, updatedLines); // Writes the updated lines back to the CSV file
            MessageBox.Show("Changes saved successfully!");
        }

        // Finds the file path for the CSV file that contains the user's data using the email address
        private string FindCsvFilePath(string email)
        {
            // Forms the full path to the directory
            string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), CsvFolderPath); 

            foreach (var subFolder in Directory.GetDirectories(directoryPath))
            {
                // Forms the path to the profile CSV file
                string profilePath = Path.Combine(subFolder, "profile.csv"); 
                if (File.Exists(profilePath))
                {
                    var lines = File.ReadAllLines(profilePath);
                    if (lines.Length > 1)
                    {
                        var headers = lines[0].Split(',').Select(h => h.Trim()).ToList();
                        int emailIndex = headers.IndexOf("Email");
                        var values = lines[1].Split(',').Select(v => v.Trim()).ToArray();

                        if (values.Length > emailIndex && values[emailIndex].Equals(email, StringComparison.OrdinalIgnoreCase))
                        {
                            return profilePath; // Returns the path if the email matches
                        }
                    }
                }
            }
            MessageBox.Show("No matching email found in any profile CSV files.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Returns null if no matching email is found
            return null; 
        }


           //method that validatest he email address
        private string ValidateEmail(string email, string currentEmail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address;
            }
            catch
            {
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return currentEmail;
            }
        }
        
         //method that clears text3,text4,and text5 boxes.
        public void ClearTextBoxes()
        {
            // Assuming you have text boxes named NametextBox, EmailtextBox, PhonetextBox
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        //method that formats phone number that is passed in

        private string FormatPhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, "[a-zA-Z]"))
            {
                MessageBox.Show("Phone number cannot contain letters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return phoneNumber;
            }

            if (phoneNumber.Length == 10)
            {
                return $"{phoneNumber.Substring(0, 3)}-{phoneNumber.Substring(3, 3)}-{phoneNumber.Substring(6)}";
            }
            else
            {
                MessageBox.Show("Phone number must contain 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return phoneNumber;
            }
        }

    }
}