using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollsAndMultiLinesApp
{
    public class MyTextBox:Widget
    {
        public MyTextBox():base()
        {
            TextBox = new RichTextBox
            {
                Width = 250,
                Height = 250,
                Multiline = base.Multiline,
                ScrollBars = RichTextBoxScrollBars.None,
                WordWrap = false
            };
        }

        public override void Draw()
        {
            TextBox.Parent.Controls.Add(TextBox);
        }
    }
}
