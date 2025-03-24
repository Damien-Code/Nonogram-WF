using Nonogram_WF.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Themes
{
    class Theme : ITheme
    {
        private Color _userControlBG;
        private Color _userControlFG;
        private Color _panelBG;
        private Color _panelFG;
        private Color _buttonBG;
        private Color _buttonFG;
        private Color _labelBG;
        private Color _labelFG;
        private Color _textBoxBG;
        private Color _textBoxFG;
        private Color _dataGridViewBG;
        private Color _dataGridViewFG;
		public Color UserControlBG { get { return _userControlBG; } set { _userControlBG = value; } }
		public Color UserControlFG { get { return _userControlFG; } set { _userControlFG = value; } }
		public Color PanelBG { get { return _panelBG; } set { _panelBG = value; } }
		public Color PanelFG { get { return _panelFG; } set { _panelFG = value; } }
		public Color ButtonBG { get { return _buttonBG; } set { _buttonBG = value; } }
		public Color ButtonFG { get { return _buttonFG; } set { _buttonFG = value; } }
		public Color LabelBG { get { return _labelBG; } set { _labelBG = value; } }
		public Color LabelFG { get { return _labelFG; } set { _labelFG = value; } }
		public Color TextBoxBG { get { return _textBoxBG; } set { _textBoxBG = value; } }
		public Color TextBoxFG { get { return _textBoxFG; } set { _textBoxFG = value; } }
		public Color DataGridViewBG { get { return _dataGridViewBG; } set { _dataGridViewBG = value; } }
		public Color DataGridViewFG { get { return _dataGridViewFG; } set { _dataGridViewFG = value; } }
        public Theme() { 
            
        }

		/* all components
* UserControl
* Button
* Label
* Textbox
* Datagrid
*/
		public static bool ChangeTheme(Theme theme, Control.ControlCollection container) {
			foreach (Control component in container)
			{
                if (component is UserControl)
                {
                    ChangeTheme(theme, component.Controls);
                    component.BackColor = theme.UserControlBG;
                    component.ForeColor = theme.UserControlFG;
                }
                else if (component is Panel) {
                    component.BackColor = theme.PanelBG;
                    component.ForeColor = theme.PanelFG;
                    ChangeTheme(theme, component.Controls);
                }
                else if (component is Button)
                {
                    component.BackColor = theme.ButtonBG;
                    component.ForeColor = theme.ButtonFG;
                }
                else if (component is Label)
                {
                    component.BackColor = theme.LabelBG;
                    component.ForeColor = theme.LabelFG;
                }
                else if (component is TextBox)
                {
                    component.BackColor = theme.TextBoxBG;
                    component.ForeColor = theme.TextBoxFG;
                }
                else if (component is DataGridView)
                { //datagrid can be changed if needed, this is only used in the history view.    
                    component.BackColor = theme.DataGridViewBG;
                    component.ForeColor = theme.DataGridViewFG;
                }
                return true;
			}
		}
    }
}
