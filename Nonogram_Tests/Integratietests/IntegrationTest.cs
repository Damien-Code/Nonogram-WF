using Nonogram_WF.Controllers;
using Nonogram_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_Tests
{
    /*
     * een type softwaretesten waarbij de verschillende eenheden, modules of componenten van een softwaretoepassing als een gecombineerd geheel worden getest
     */

    [TestClass]
    public sealed class IntegrationTest
    {

        //template
        [TestMethod]
        public void Test_Integration()
        {
            Assert.IsTrue(true);
        }

        //actual tests

        [TestMethod]
        public void Test_IntegrationTest_AccountCannotBeCreatedIfEmailExists_CheckEmailExists_ReturnsTrue()
        {
            Users user = new Users() { Email = "test@example.com" };
            Users.SetUser(user.Email, new DPassword("", ""), new Settings("", ""), new UserHistory());
            //JSON_RW.WriteFile(user); 
            //dit is waar je error zit, het is nu geen users list maar een plain user. Allusers is dan empty

            Users user2 = new Users() { Email = "test@example.com" };

            var result = LoginController.CheckEmailExists(user2.Email);
            if (result.user.Email != null)
            {
                Assert.IsTrue(result.boolean);
                return;
            }
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void Test_IntegrationTest_SessionCanBeChecked() {
            Users user = new Users() { Email = "test@example.com", Settings = new Settings("Light", ""), History = new UserHistory() };
            Session.SetSession(user.Email, user.Settings, user.History);
            //change theme
            Users currentUser = Session.GetSession();
            
            //assert
            Assert.IsTrue(currentUser.Email == user.Email);

        }
    }
}
