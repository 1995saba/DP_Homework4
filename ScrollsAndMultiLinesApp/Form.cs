using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollsAndMultiLinesApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        Widget myWidget;
        public Form()
        {
            InitializeComponent();
            myWidget = new MyTextBox();
            myWidget.TextBox.Parent = this;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            myWidget.Multiline = multilineCheckBox.Checked;
            myWidget.VsBar = vsCheckBox.Checked;
            myWidget.HsBar = hsCheckBox.Checked;

            if (myWidget.Multiline == true)
            {
                myWidget = new MultilineDecorator(myWidget);
            }
            if (myWidget.VsBar == true)
            {
                myWidget = new VerticalScrollDecorator(myWidget);
            }
            if (myWidget.Multiline == true)
            {
                myWidget = new HorizontalScrollDecorator(myWidget);
            }

            myWidget.Draw();
        }
    }
}
