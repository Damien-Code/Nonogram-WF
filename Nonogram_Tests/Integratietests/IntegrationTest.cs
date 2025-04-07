using Nonogram_WF.Controllers;
using Nonogram_WF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram_Tests
{
    

    [TestClass]
    public sealed class IntegrationTest
    {

        [TestMethod]
        public void Test_IntegrationTest_AccountCannotBeCreatedIfEmailExists_CheckEmailExists_ReturnsTrue()
        {
            Users user = new Users() { Email = "test@example.com" };
            /* NOTE
             *THIS DOES NOT CHECK THE EMAIL EXISTS SO MULTIPLE USERS WILL BE ADDED WHEN RUNNING THIS TEST MORE OFTEN.
             *This means that if you run the test multiple times, more users with test@example.com will be added in the database.
             *This does not mess with any of the other functionalities.
             */
            Users.SetUser(user.Email, new DPassword("", ""), new Settings(""), new UserHistory());

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
            Users user = new Users() { Email = "test@example.com", Settings = new Settings("Light"), History = new UserHistory() };
            Session.SetSession(user.Email, user.Settings, user.History);
            //change theme
            Users currentUser = Session.GetSession();
            
            //assert
            Assert.IsTrue(currentUser.Email == user.Email);

        }
    }
}
