using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollsAndMultiLinesApp
{
    public class MultilineDecorator : Decorator
    {
        public MultilineDecorator(Widget widget) : base(widget)
        {
            Multiline = true;
        }

        public override void Draw()
        {
            base.Draw();
            Widget.TextBox.Multiline = Multiline;
        }
    }
}
