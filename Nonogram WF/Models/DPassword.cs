using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Models
{
    // A class to make the using and setting of the hash and salt easier
    public class DPassword
    {
        // Properties of the DPassword class
        public string Hash;
        public string Salt;

        // Construct when a object with arguments of this class is created
        public DPassword(string hash, string salt)
        {
            Salt = salt;
            Hash = hash;
        }
    }
}
