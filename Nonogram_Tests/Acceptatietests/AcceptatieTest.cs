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

       
    }
}
