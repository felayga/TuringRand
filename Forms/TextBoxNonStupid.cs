using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Forms
{
    public class TextBoxNonStupid : TextBox
    {
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        this.SelectAll();
                        e.Handled = true;
                        return;
                }
            }
            base.OnKeyDown(e);
        }
    }
}
