using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Themes
{
    class Dark : Theme
    {
        //MyColor is color to flip
        //Color.FromArgb(MyColor.ToArgb()^0xffffff)
        public Dark() {
            UserControlBG = Color.FromArgb(UserControl.DefaultBackColor.ToArgb() ^ 0xffffff);
            UserControlFG = Color.FromArgb(UserControl.DefaultForeColor.ToArgb() ^ 0xffffff);
            PanelBG = Color.FromArgb(Panel.DefaultBackColor.ToArgb() ^ 0xffffff);
            PanelFG = Color.FromArgb(Panel.DefaultForeColor.ToArgb() ^ 0xffffff);
            ButtonBG = Color.FromArgb(Button.DefaultBackColor.ToArgb() ^ 0xffffff);
            ButtonFG = Color.FromArgb(Button.DefaultForeColor.ToArgb() ^ 0xffffff);
            LabelBG = Color.FromArgb(Label.DefaultBackColor.ToArgb() ^ 0xffffff);
            LabelFG = Color.FromArgb(Label.DefaultForeColor.ToArgb() ^ 0xffffff);
            TextBoxBG = Color.FromArgb(TextBox.DefaultBackColor.ToArgb() ^ 0xffffff);
            TextBoxFG = Color.FromArgb(TextBox.DefaultForeColor.ToArgb() ^ 0xffffff);
            DataGridViewBG = Color.FromArgb(DataGridView.DefaultBackColor.ToArgb() ^ 0xffffff);
            DataGridViewFG = Color.FromArgb(DataGridView.DefaultForeColor.ToArgb() ^ 0xffffff);
        }
    }
}
