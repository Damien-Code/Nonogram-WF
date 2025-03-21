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
        //public static List<string> RetrieveHistory()
        //{
        //    List<string> userHistory = new List<string>();
        //    Users user = Session.GetSession();

        //    int userLevel = user.History.Level;
        //    int userHint = user.History.HintCount;
        //    bool userSolve = user.History.UsedSolver;

        //    userHistory.Add(userLevel.ToString());
        //    userHistory.Add(userHint.ToString());
        //    userHistory.Add(userSolve.ToString());

        //    return userHistory;
        //}

        public static History RetrieveHistory()
        {
            Users user = Session.GetSession();
            return user.History;
        }
    }
}
