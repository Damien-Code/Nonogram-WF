using Nonogram_WF.Database;
using Nonogram_WF.Themes;
using Nonogram_WF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Nonogram_WF.Models
{
    public class History
    {
        private int _level;
        
        private bool _usedSolver;

        public int Level
        {
            get => _level;
            set => _level = value;
        }
       
        public bool UsedSolver
        {
            get => _usedSolver;
            set => _usedSolver = value;
        }


        public History(int level, bool usedSolver)
        {
            Level = level;
            UsedSolver = usedSolver;
        }

        public History()
        {

        }
        /// <summary>
        /// Sets the game in the gamehistory and sets this in the users profile in data.json and in its session
        /// </summary>
        /// <param name="user"></param>
        /// <param name="gameHistory"></param>
        public static void SetWin(Users user, History gameHistory)
        {
            AllUsers allUsers = JSON_RW.GetUsers();
            Users currentUser = allUsers.Users.Find(x => x.Email == user.Email);
            currentUser.History.AllHistory.Add(gameHistory);
            JSON_RW.UpdateUserSettings(allUsers);
            JSON_RW.UpdateSessionSettings(currentUser);
        }
    }
}
