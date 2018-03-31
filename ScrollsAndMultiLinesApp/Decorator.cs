using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollsAndMultiLinesApp
{
    public abstract class Decorator : Widget
    {
        public Widget Widget { get; set; }

        public Decorator(Widget widget)
        {
            Widget = widget;
        }
        public override void Draw()
        {
            Widget.Draw();
        }
    }
}
