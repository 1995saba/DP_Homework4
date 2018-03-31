using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollsAndMultiLinesApp
{
    public class EditControl
    {
        public bool Multiline { get; set;}
        public bool VsBar { get; set; }
        public bool HsBar { get; set; }

        public EditControl()
        {
            Multiline = false;
            VsBar = false;
            HsBar = false;
        }
    }
}
