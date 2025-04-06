using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_WF.Models
{
    /// <summary>
    /// return a list of all users in data.json
    /// </summary>
    public class AllUsers
    {
        public List<Users> Users { get; set; } = new List<Users> { }; 
    }
}
