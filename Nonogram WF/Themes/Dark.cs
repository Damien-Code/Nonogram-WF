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
        //Int32 colorChangeAmount = 0xbababa; //grey
        private Int32 colorChangeAmount = 0xffffff;
        public Dark() {
            UserControlBG = Color.FromArgb(UserControl.DefaultBackColor.ToArgb() ^ colorChangeAmount);
            UserControlFG = Color.FromArgb(UserControl.DefaultForeColor.ToArgb() ^ colorChangeAmount);
            PanelBG = Color.FromArgb(Panel.DefaultBackColor.ToArgb() ^ colorChangeAmount);
            PanelFG = Color.FromArgb(Panel.DefaultForeColor.ToArgb() ^ colorChangeAmount);
            ButtonBG = Color.FromArgb(Button.DefaultBackColor.ToArgb() ^ colorChangeAmount);
            ButtonFG = Color.FromArgb(Button.DefaultForeColor.ToArgb() ^ colorChangeAmount);
            LabelBG = Color.FromArgb(Label.DefaultBackColor.ToArgb() ^ colorChangeAmount);
            LabelFG = Color.FromArgb(Label.DefaultForeColor.ToArgb() ^ colorChangeAmount);
            TextBoxBG = Color.FromArgb(TextBox.DefaultBackColor.ToArgb() ^ colorChangeAmount);
            TextBoxFG = Color.FromArgb(TextBox.DefaultForeColor.ToArgb() ^ colorChangeAmount);
            DataGridViewBG = Color.FromArgb(DataGridView.DefaultBackColor.ToArgb() ^ colorChangeAmount);
            DataGridViewFG = Color.FromArgb(DataGridView.DefaultForeColor.ToArgb() ^ colorChangeAmount);
            PenColor = Color.FromArgb(Color.Black.ToArgb() ^ colorChangeAmount);
        }
    }
}
