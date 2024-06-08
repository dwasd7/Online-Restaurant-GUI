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
    public partial class orderHistoryCard : UserControl
    {

        // Event declaration
        public event EventHandler ViewDetailsClicked;

       

        public orderHistoryCard()
        {
            InitializeComponent();

            viewDetailButton.Click += viewDetailButton_Click; // Make sure the button click is wired up
        }


        public string dateText
        {
            get { return dateTextLabel.Text; }
            set { dateTextLabel.Text = value; }
        }


        public string totalText
        {
            get { return totalTextLabel.Text; }
            set { totalTextLabel.Text = value; }
        }


        public string statusText
        {
            get { return statusTextLabel.Text; }
            set { statusTextLabel.Text = value; }

        }

        private void viewDetailButton_Click(object sender, EventArgs e)
        {
            ViewDetailsClicked?.Invoke(this, EventArgs.Empty);
        }

        public string orderNumberText
        {
            get { return orderNumberLabel.Text; }
            set { orderNumberLabel.Text = value; }
        }

    }
}
