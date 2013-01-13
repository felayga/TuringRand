using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Forms
{
    public class PictureBoxInterpolationMode : PictureBox
    {
        public System.Drawing.Drawing2D.InterpolationMode interpolation;

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            pevent.Graphics.InterpolationMode = interpolation;
            base.OnPaintBackground(pevent);
        }
    }
}
