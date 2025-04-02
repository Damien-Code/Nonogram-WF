using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Interfaces
{
    interface ITheme
    {
        public Color UserControlBG { get; set; }
        public Color UserControlFG { get; set; }
        public Color PanelBG { get; set; }
        public Color PanelFG { get; set; }
        public Color ButtonBG { get; set; }
        public Color ButtonFG { get; set; }
        public Color LabelBG { get; set; }
        public Color LabelFG { get; set; }
        public Color TextBoxBG { get; set; }
        public Color TextBoxFG { get; set; }
        public Color DataGridViewBG { get; set; }
        public Color DataGridViewFG { get; set; }
    }
}
