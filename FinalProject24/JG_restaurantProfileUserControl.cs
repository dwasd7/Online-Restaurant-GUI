using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject24
{
    
    public partial class JG_restaurantProfileUserControl : UserControl
    {
        // instance of the UserControl to make sure  only one instance exists
        private static JG_restaurantProfileUserControl _instance;
        // File path to the CSV file storing restaurant information
        private static readonly string CsvFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../../resturantinformation/resturantInformation.csv");
        // Username to load and update profiles based on current user
        private string currentUsername;

        // Property to access the instance
        public static JG_restaurantProfileUserControl Instance
        {
            get
            {
                if (_instance == null) // Check if the instance already exists
                {
                    _instance = new JG_restaurantProfileUserControl(); // Create a new instance if not
                }
                return _instance; // Return the existing or new instance
            }
        }

        // Constructor initializing
        public JG_restaurantProfileUserControl()
        {
            InitializeComponent();
            currentUsername = Environment.GetEnvironmentVariable("EmailEnv");
            EnsureCsvFileExists();
        }

        // make sure the CSV file exists
        // creates it if it doesn't
        private void EnsureCsvFileExists()
        {
            if (!File.Exists(CsvFilePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(CsvFilePath));
                File.WriteAllText(CsvFilePath, "Username,RestaurantName,RestaurantAddress,RestaurantPhone,RestaurantEmail,RestaurantDescription\n");
            }
        }

        // Event handler for applying changes to the profile
        private void applyChangeButton_Click(object sender, EventArgs e)
        {
            if (newNameTextBox.Text == "" || newAddressTextBox.Text == "" || newEmailTextBox.Text == "" || 
                newPhoneNumberTextBox.Text == "" || newDescriptionTextBox.Text == "")
            {
                MessageBox.Show("Please fill in every text box!");
                return;
            }
            UpdateProfile(newNameTextBox.Text, newAddressTextBox.Text, newPhoneNumberTextBox.Text,
                          newEmailTextBox.Text, newDescriptionTextBox.Text);
            LoadProfile(currentUsername);
        }

        // Event handler to load the profile on UserControl load
        private void JG_restaurantProfileUserControl_Load(object sender, EventArgs e)
        {
            LoadProfile(currentUsername);
        }

        // Method to load a profile
        private void LoadProfile(string username)
        {
            var profiles = ReadCsvFile(); // Read profiles from the CSV file
            var profile = profiles.FirstOrDefault(p => !string.IsNullOrWhiteSpace(p.Username) && p.Username.Equals(username, StringComparison.OrdinalIgnoreCase)); // Find profile matching the username

            if (profile == null) // If no profile found
            {
                DisplayProfile(new RestaurantProfile($"{username},n/a,n/a,n/a,n/a,n/a")); // Display default data
            }
            else
            {
                DisplayProfile(profile); // Display found profile
            }
        }

        // Method to update or create a profile
        private void UpdateProfile(string name, string address, string phone, string email, string description)
        {
            var profiles = ReadCsvFile(); // Read existing profiles from CSV
            var profile = profiles.FirstOrDefault(p => p.Username == currentUsername); // Find the current user's profile

            if (profile == null && IsAnyFieldNonEmpty(name, address, phone, email, description)) // Check if the profile doesn't exist but fields are filled
            {
                profile = new RestaurantProfile($"{currentUsername},n/a,n/a,n/a,n/a,n/a"); // Create a new profile with default values
                profiles.Add(profile); // Add new profile to the list
            }

            if (profile != null) // If profile exists or just created
            {
                // Update the profile's data
                profile.RestaurantName = string.IsNullOrWhiteSpace(name) ? "n/a" : name;
                profile.RestaurantAddress = string.IsNullOrWhiteSpace(address) ? "n/a" : address;
                profile.RestaurantPhone = string.IsNullOrWhiteSpace(phone) ? "n/a" : phone;
                profile.RestaurantEmail = string.IsNullOrWhiteSpace(email) ? "n/a" : email;
                profile.RestaurantDescription = string.IsNullOrWhiteSpace(description) ? "n/a" : $"\"{description}\"";
                WriteCsvFile(profiles); // Write updated profiles back to the CSV file
            }
        }

        // Checks if any of the provided fields are non-empty
        private bool IsAnyFieldNonEmpty(params string[] fields)
        {
            return fields.Any(field => !string.IsNullOrWhiteSpace(field));
        }

        // Displays the profile information on the UserControl
        private void DisplayProfile(RestaurantProfile profile)
        {
            currNameLabel.Text = profile.RestaurantName;
            currAddressLabel.Text = profile.RestaurantAddress;
            currPhoneNumberLabel.Text = profile.RestaurantPhone;
            currEmailLabel.Text = profile.RestaurantEmail;
            currDescriptionLabel.Text = profile.RestaurantDescription.Trim('"');
        }

        private List<RestaurantProfile> ReadCsvFile()
        {
            EnsureCsvFileExists(); // make sure the CSV file exists
            var lines = File.ReadAllLines(CsvFilePath).Skip(1); // Read all lines from the file skipping the header
            return lines.Select(line => new RestaurantProfile(line)).ToList(); // Convert each line to a RestaurantProfile object and return the list
        }

        // Method to write profiles to the CSV file
        private void WriteCsvFile(List<RestaurantProfile> profiles)
        {
            try
            {
                var data = new StringBuilder("Username,RestaurantName,RestaurantAddress,RestaurantPhone,RestaurantEmail,RestaurantDescription\n"); // Start with the header
                foreach (var profile in profiles)
                {
                    data.AppendLine(profile.ToString()); // Add each profile's string representation to the data
                }
                File.WriteAllText(CsvFilePath, data.ToString()); // Write all data to the CSV file
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Failed to write to the file: {ex.Message}", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if writing fails
            }
        }
    }

    // Class to represent a restaurant profile
    public class RestaurantProfile
    {
        // Properties for each piece of data in a restaurant profile
        public string Username { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public string RestaurantPhone { get; set; }
        public string RestaurantEmail { get; set; }
        public string RestaurantDescription { get; set; }

        // Constructor to parse a CSV line into a restaurant profile
        public RestaurantProfile(string csvLine)
        {
            var values = ParseCsvLine(csvLine); // Parse the CSV line
            Username = values[0]; // Set the username
            RestaurantName = values.Length > 1 ? values[1] : "n/a"; // Set the restaurant name or default
            RestaurantAddress = values.Length > 2 ? values[2] : "n/a"; // Set the address or default
            RestaurantPhone = values.Length > 3 ? values[3] : "n/a"; // Set the phone number or default
            RestaurantEmail = values.Length > 4 ? values[4] : "n/a"; // Set the email or default
            RestaurantDescription = values.Length > 5 ? values[5].Trim('"') : "n/a"; // Set the description or default, trimming quotes
        }

        // Method to parse a CSV line considering potential quotes around fields
        private string[] ParseCsvLine(string csvLine)
        {
            // List to hold parsed fields
            var columns = new List<string>();
            // StringBuilder to construct each field
            var column = new StringBuilder();
            // Flag to indicate whether the current character is within quotes
            bool inQuotes = false;

            foreach (char ch in csvLine) 
            {
                if (ch == '\"') 
                {
                    inQuotes = !inQuotes; // Toggle the inQuotes flag If the character is a quote
                }
                else if (ch == ',' && !inQuotes) // If it's a comma and not in quotes, Add the field to the list
                {
                    columns.Add(column.ToString()); 
                    column.Clear(); 
                }
                else
                {
                    column.Append(ch); // Add the character to the current field
                }
            }
            columns.Add(column.ToString()); // Add the last field to the list
            return columns.ToArray(); // Return the fields as an array
        }

        // Converts the restaurant profile back to a CSV format string
        public override string ToString()
        {
            // make sure the description is enclosed in quotes if it contains a comma or quotes
            string safeDescription = RestaurantDescription.Contains(",") || RestaurantDescription.Contains("\"") ? $"\"{RestaurantDescription.Replace("\"", "\"\"")}\"" : RestaurantDescription;
            return $"{Username},{RestaurantName},{RestaurantAddress},{RestaurantPhone},{RestaurantEmail},{safeDescription}"; // Return the CSV string
        }
    }

}
