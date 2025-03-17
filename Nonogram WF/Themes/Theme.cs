using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Themes
{
    class Theme
    {
        private Color _userControlBG;
        private Color _userControlFG;
		public Color UserControlBG { get => _userControlBG; private set => _userControlBG = value; }
		public Color UserControlFG { get => _userControlFG; private set => _userControlFG = value; }

		/* all components
* UserControl
* Button
* Label
* Textbox
* Datagrid
*/
		public static void ChangeTheme(Theme theme, Control.ControlCollection container) {
			foreach (Control component in container)
			{
                if (component is UserControl) {
                    ChangeTheme(theme, component.Controls);
                    component.BackColor = theme.UserControlBG;
                    component.ForeColor = theme.UserControlFG;
                }
                else if (component is Button) { }                    
                else if (component is Label) { }                    
                else if (component is TextBox) { }                    
                else if (component is DataGridView) { //datagrid can be changed if needed, this is only used in the history view.    
                
                } 
                
			}
		}
    }
}
