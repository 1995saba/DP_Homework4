using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollsAndMultiLinesApp
{
    public abstract class Widget:EditControl
    {
        public RichTextBox TextBox { get; set; }
        public abstract void Draw();
    }
}
