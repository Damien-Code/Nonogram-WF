using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Themes
{
    class Light : Theme
    {
        public Light() { 
            UserControlBG = UserControl.DefaultBackColor;
            UserControlFG = UserControl.DefaultForeColor;
            PanelBG = Panel.DefaultBackColor;
            PanelFG = Panel.DefaultForeColor;
            ButtonBG = Button.DefaultBackColor;
            ButtonFG = Button.DefaultForeColor;
            LabelBG = Label.DefaultBackColor;
            LabelFG = Label.DefaultForeColor;
            TextBoxBG = TextBox.DefaultBackColor;
            TextBoxFG = TextBox.DefaultForeColor;
            DataGridViewBG = DataGridView.DefaultBackColor;
            DataGridViewFG = DataGridView.DefaultForeColor;
			PenColor = Color.Black;
		}
    }
}
