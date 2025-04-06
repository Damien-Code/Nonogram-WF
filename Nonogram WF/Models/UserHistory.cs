using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Models
{
    /// <summary>
    /// returns a list of type History of the gamehistory of the user
    /// </summary>
    public class UserHistory
    {
        public List<History> AllHistory { get; set; } = new List<History> { };
    }
}
