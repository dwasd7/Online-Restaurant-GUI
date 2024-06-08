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
    public partial class ProductDetailUserControl1 : UserControl
    {
        public ProductDetailUserControl1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = int.Parse(label7.Text);
            count = Math.Max(0, count - 1);
            label7.Text = count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = int.Parse(label7.Text); 
            count += 1;
            label7.Text = count.ToString();
        }
    }
}
