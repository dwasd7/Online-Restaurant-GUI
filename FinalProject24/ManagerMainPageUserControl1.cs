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
    public partial class ManagerMainPageUserControl1 : UserControl
    {

        private static ManagerMainPageUserControl1 _instance;

        public ManagerMainPageUserControl1()
        {
            InitializeComponent();
            LoadStatusUserControl();
        }


        public static ManagerMainPageUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManagerMainPageUserControl1();
                }
                return _instance;
            }
        }


        private void UpdateStatusUserControlPositions()
        {
            int yOffset = 0;
            foreach (Control control in pendingPanel.Controls)
            {
                control.Location = new Point(0, yOffset);
                yOffset += control.Height + 10; // Adjust the space between controls if necessary
            }
        }
        private void UpdateAcceptUserControlPositions()
        {
            int yOffset = 0;
            foreach (Control control in acceptedPanel.Controls)
            {
                control.Location = new Point(0, yOffset);
                yOffset += control.Height + 10; // Adjust the space between controls if necessary
            }
        }
        private void UpdateReadyUserControlPositions()
        {
            int yOffset = 0;
            foreach (Control control in readyPanel.Controls)
            {
                control.Location = new Point(0, yOffset);
                yOffset += control.Height + 10; // Adjust the space between controls if necessary
            }
        }

        private void LoadStatusUserControl()
        {
            string directoryPath = @"..\..\..\..\receipts\";

            // Clear existing controls from the pendingPanel
            pendingPanel.Controls.Clear();

            if (Directory.Exists(directoryPath))
            {
                string[] csvFiles = Directory.GetFiles(directoryPath, "*.csv");
                int yOffset = 0; // Initialize an offset for the Y position

                foreach (string csvFilePath in csvFiles)
                {
                    var lines = File.ReadAllLines(csvFilePath);
                    string orderStatusLine = lines.LastOrDefault();

                    if (orderStatusLine != null && orderStatusLine.Contains("Order Status: Pending"))
                    {
                        statusUserControl statusControl = new statusUserControl();

                        // Extract the order number from the file name
                        string orderNumber = Path.GetFileNameWithoutExtension(csvFilePath);

                        // Configure properties of statusControl
                        statusControl.GetName = $"Order #{orderNumber}";
                        statusControl.StatusButtonText = "Accept";

                        // Extract item details and add to ListBoxItems
                        List<string> itemList = new List<string>();
                        for (int i = 1; i < lines.Length - 3; i++) // Skip header and last 3 lines
                        {
                            string[] columns = lines[i].Split(',');
                            if (columns.Length > 3) // Ensure there are enough columns
                            {
                                string itemName = columns[0].Trim();
                                string quantity = columns[1].Trim();
                                string itemTotal = columns[3].Trim();
                                itemList.Add($"{itemName} x{quantity} - {itemTotal}");
                            }
                        }
                        statusControl.ListBoxItems = itemList;

                        // Subscribe to the StatusButtonClicked event
                        statusControl.StatusButtonClicked += StatusControl_StatusButtonClicked;

                        // Subscribe to the CancelButtonClicked event
                        statusControl.CancelButtonClicked += StatusControl_CancelButtonClicked;

                        // Set the size of the control
                        statusControl.Size = new Size(258, 248); // Adjust height as needed

                        // Set the location of the control
                        statusControl.Location = new Point(0, yOffset);

                        // Add the height of the control plus some margin to the offset for the next control
                        yOffset += statusControl.Height + 10; // Adjust margin space as needed

                        // Add the statusControl to the pendingPanel
                        pendingPanel.Controls.Add(statusControl);
                    }
                }
            }
            else
            {
                MessageBox.Show($"Directory not found: {directoryPath}");
            }
        }

        

       



        // Event handler for the CancelButtonClicked event
        private void StatusControl_CancelButtonClicked(object sender, EventArgs e)
        {
            var statusControl = sender as statusUserControl;
            if (statusControl != null)
            {
                MessageBox.Show("Oder has been cancel");
            }
        }




        // Event handler for the StatusButtonClicked event
        private void StatusControl_StatusButtonClicked(object sender, EventArgs e)
        {
            var statusControl = sender as statusUserControl;
            if (statusControl != null)
            {
                if (statusControl.StatusButtonText == "Accept")
                {
                    // Logic to move the status control to the accepted panel and change the button text
                    pendingPanel.Controls.Remove(statusControl);
                    acceptedPanel.Controls.Add(statusControl);
                    statusControl.StatusButtonText = "Ready";
                    // Subscribe to the new click event for the "Ready" button
                    statusControl.StatusButtonClicked -= StatusControl_StatusButtonClicked;
                    statusControl.StatusButtonClicked += StatusControl_ReadyButtonClicked;

                    UpdateAcceptUserControlPositions();
                }
            }
        }



        private void StatusControl_ReadyButtonClicked(object sender, EventArgs e)
        {
            var statusControl = sender as statusUserControl;
            if (statusControl != null)
            {
                if (statusControl.StatusButtonText == "Ready")
                {
                    // Logic to move the status control to the ready panel
                    acceptedPanel.Controls.Remove(statusControl);
                    readyPanel.Controls.Add(statusControl);
                    statusControl.StatusButtonText = "Finished"; // Change the button text to "Finished"
                                                                 // Subscribe to the new click event for the "Finished" button
                    statusControl.StatusButtonClicked -= StatusControl_ReadyButtonClicked;
                    statusControl.StatusButtonClicked += StatusControl_FinishedButtonClicked;

                    UpdateReadyUserControlPositions();
                }
            }
        }


        private void StatusControl_FinishedButtonClicked(object sender, EventArgs e)
        {
            var statusControl = sender as statusUserControl;
            if (statusControl != null && statusControl.StatusButtonText == "Finished")
            {
                // Update the CSV file to set the Order Status to Finished
                string orderNumber = statusControl.GetName.Replace("Order #", "").Trim();
                UpdateOrderStatusInCSV(orderNumber, "Finished");


                MessageBox.Show("Order has been finished and archived.");

                // Logic for what happens when "Finished" is clicked
                readyPanel.Controls.Remove(statusControl);



                // Optionally dispose the control if it's no longer needed
                statusControl.Dispose();
            }
        }





        private void UpdateOrderStatusInCSV(string orderNumber, string newStatus)
        {
            string directoryPath = @"..\..\..\..\receipts\";
            string filePath = Path.Combine(directoryPath, $"{orderNumber}.csv");

            try
            {
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath).ToList();

                    // Find the index of the line that starts with ",,,Order Status:"
                    int statusLineIndex = lines.FindIndex(line => line.Trim().StartsWith(",,,Order Status:"));
                    if (statusLineIndex != -1)
                    {
                        // Update the status line with the new status
                        lines[statusLineIndex] = $",,,Order Status: {newStatus}";

                        // Write the updated lines back to the CSV file
                        File.WriteAllLines(filePath, lines);

                        MessageBox.Show("Order status updated to Finished."); // Confirmation message
                    }
                    else
                    {
                        MessageBox.Show("Order Status line not found in the file.");
                    }
                }
                else
                {
                    MessageBox.Show($"Order file not found: {filePath}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating the CSV file: {ex.Message}");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadStatusUserControl();
        }






    }
}
