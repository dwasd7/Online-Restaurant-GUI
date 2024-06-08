using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace FinalProject24
{
    public class RoundPictureBox : PictureBox
    {
        // Override the OnPaint method
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Create a path that consists of a single ellipse that covers the client area
            GraphicsPath gPath = new GraphicsPath();
            gPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

            // Set the region of the control to the ellipse (to make it round)
            this.Region = new Region(gPath);

            // Call the OnPaint method of the base class
            base.OnPaint(pe);

            // Dispose of the path
            gPath.Dispose();
        }
    }



}
