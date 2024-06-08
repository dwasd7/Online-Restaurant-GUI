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
    public partial class statusUserControl : UserControl
    {
        // Add a public event to the statusUserControl for when the status button is clicked
        public event EventHandler StatusButtonClicked;
        public event EventHandler CancelButtonClicked;




        public statusUserControl()
        {
            InitializeComponent();
            statusButton.Click += statusButton_Click;
            cancelButton.Click += cancelButton_Click;
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            // Raise the event, indicating the status button has been clicked
            StatusButtonClicked?.Invoke(this, EventArgs.Empty);

        }


        public string GetName
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }

        // Property to get and set the status button text
        public string StatusButtonText
        {
            get { return statusButton.Text; }
            set { statusButton.Text = value; }
        }



        // Method to add an item to the list box
        public void AddItemToListBox(string item)
        {
            itemsListBox.Items.Add(item);
        }


        // Method to remove an item from the list box
        public void RemoveItemFromListBox(string item)
        {
            itemsListBox.Items.Remove(item);
        }


        // Method to clear all items from the list box
        public void ClearListBox()
        {
            itemsListBox.Items.Clear();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                // Remove the control from its parent.
                this.Parent.Controls.Remove(this);
            }
            else
            {
                // If there is no parent, log the error or notify the user.
                // This could be due to the control not being added to a parent yet,
                // or the parent being disposed of before this method was called.

                // Log the error
                Console.WriteLine("Error: Control does not have a parent to be removed from.");

               
            }
        }

        public bool StatusButtonVisible
        {
            get { return statusButton.Visible; }
            set { statusButton.Visible = value; }
        }



        // Setting all items at once
        public IEnumerable<string> ListBoxItems
        {
            get => itemsListBox.Items.Cast<string>();
            set
            {
                itemsListBox.Items.Clear();
                foreach (var item in value)
                {
                    itemsListBox.Items.Add(item);
                }
            }
        }


    }
}
