using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Models
{
    public class Settings
    {
        public string Theme { get; set; }

        public Settings(string theme)
        {
            Theme = theme;
        }

    }
}
