using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Controllers;

namespace Nonogram_WF.Interfaces
{
    // Interface that the Users class will inherit
    public interface IUser
    {
        // Properties that the Users class need to have
        //string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }

        // Methods that the Users class need to have
        static void SetUser(string email, string password) { }
    }
}
