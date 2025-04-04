using Nonogram_WF.Models;
using Nonogram_WF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram_Tests
{
    [TestClass]
    public sealed class AcceptatieTest
    {
        /*
         * geschreven vanuit de blik van de user 
         */

        [TestMethod]
        public void Test_Acceptatie_SessionEmptyAfterLogout()
        {
            Nonogram_WF.Views.Settings x = new Nonogram_WF.Views.Settings();
            //assert
            x.testLogout();
            Users? y = Session.GetSession();

            Assert.IsTrue(y.Email == "" && y.Password == null);
        }

        [TestMethod]
        public void Test_HistoryTableHasContent()
        {
            Users user = new Users();
            Nonogram_WF.Models.History ModelHistory = new Nonogram_WF.Models.History(1, 1, false);
            Users.SetUser(user.Email, new DPassword("", ""), new Nonogram_WF.Models.Settings("", ""), new UserHistory());
            
            Nonogram_WF.Views.History ViewHistory = new Nonogram_WF.Views.History();
            
            DataGridViewRow Row =  ViewHistory.dataGridView1.Rows.Cast<DataGridViewRow>().Where(x => x.Cells["HintsUsed"].Value.Equals(ModelHistory.HintCount)).FirstOrDefault();
            Assert.IsNotNull(Row);
            

        }

       
    }
}
