using Newtonsoft.Json;
using Nonogram_WF;
using Nonogram_WF.Controllers;
using Nonogram_WF.Database;
using Nonogram_WF.Models;

namespace Nonogram_Tests
{
    [TestClass]
    public sealed class UserTests
    {
        [TestMethod]
        public void Test_StoreUser()
        {
            //Users user = new Users();
            //JSON_RW.WriteFile(user);

            //var AllUsers = JSON_RW.GetUsers();

            //Assert.IsNotNull(AllUsers);
            //Assert.IsTrue(AllUsers.Users.Count == 1);
            //Assert.AreEqual(AllUsers.Users.Last(), user);
        }

        [TestMethod]
        public void Test_AccountCannotBeCreatedIfEmailExists_CheckEmailExists_ReturnsTrue()
        {
            Users user = new Users() { Email = "test@example.com" };
            JSON_RW.WriteFile(user);
            Users user2 = new Users(){ Email = "test@example.com" };

            var result = LoginController.CheckEmailExists(user2.Email);

            Assert.IsFalse(result.boolean);
        }

        [TestMethod]
        public void TestMethod2()
        {
        }
    }
}
