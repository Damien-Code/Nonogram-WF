using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Interfaces
{
    public interface IUser
    {
        string Email { get; set; }

        static void SetUser() { }
    }
}
