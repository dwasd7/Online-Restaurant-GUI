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
    public partial class NS_ManagerEditPageUserControl1 : UserControl
    {

        public NS_ManagerEditPageUserControl1()
        {
            InitializeComponent();

        }
        /* The purpose of this control is to allow the manager to update the menu
         * They could add, remove, or clear the items on the list and see the availability of the items
         * and they could see the amount of items on the menu
         */
        private void Addbutton_Click(object sender, EventArgs e)
        {
            // These are dummy values meant to be replaced when backend is connected
            // should be an if statement that checks the db
            // as long as the db has items it should create items on this listview
            ListViewItem item = new ListViewItem("Cheeseburger");
            item.SubItems.Add("5.75");
            item.SubItems.Add("While Supplies Last");
            listView1.Items.Add(item);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            // This is straightforward, but when it comes time to implement the backend
            // This needs to be changed to not only update the list, but also the db
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void Countbutton_Click(object sender, EventArgs e)
        {
            // simple and nice to have, but maybe unnecessary later on
            MessageBox.Show(listView1.Items.Count.ToString());
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            // I believe a manager might like this feature, but this might be taken out later
            listView1.Items.Clear();
        }
    }
}

