using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram_WF.Themes
{
    class DarkBlue : Theme
    {
		private Int32 colorChangeAmount = 0xead5b2;
		public DarkBlue()
		{
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
