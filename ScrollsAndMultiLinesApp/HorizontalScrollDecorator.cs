using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollsAndMultiLinesApp
{
    public class HorizontalScrollDecorator : Decorator
    {
        public HorizontalScrollDecorator(Widget widget) : base(widget)
        {
            widget.HsBar = true;
        }
        public override void Draw()
        {
            base.Draw();
            if (Widget.HsBar == false && Widget.VsBar == false)
            {
                Widget.TextBox.ScrollBars =
                System.Windows.Forms.RichTextBoxScrollBars.None;
            }
            if (Widget.VsBar == true)
            {
                Widget.TextBox.ScrollBars =
                System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            }
            else 
            {
                Widget.TextBox.ScrollBars =
                System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            }
        }
    }
}
