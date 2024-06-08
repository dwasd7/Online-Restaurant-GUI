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
    public partial class JG_blankPageUserControl : UserControl
    {
        private static JG_blankPageUserControl _instance;

        public static JG_blankPageUserControl Instance
        {
            get
            {
                // If the instance is null, create it
                if (_instance == null)
                {
                    _instance = new JG_blankPageUserControl();
                }
                // Return the existing or new instance
                return _instance;
            }
        }


        public JG_blankPageUserControl()
        {
            InitializeComponent();
        }
    }
}
