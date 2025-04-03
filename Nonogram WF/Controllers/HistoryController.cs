using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nonogram_WF.Models;

namespace Nonogram_WF.Controllers
{
    public class HistoryController
    {
        /// <summary>
        /// A method that retrieves the user via the users current session
        /// Only returns the history from that user, because the history is the only part we need to retrieve
        /// 
        /// </summary>
        /// <returns type="History"></returns>
        public static (Users user, UserHistory history) RetrieveHistory()
        {
            Users user = Session.GetSession();
            return (user, user.History);
            //check to make sure the part below isnt needed for history to work
            //if (user.History == null)
            //{
            //    return new History(0, 0, true);
            //}
            //return user.History;
        }
        public static void SetWin(Users user, History userHistory) {
            History.SetWin(user, userHistory);
            
        }
    }
}
