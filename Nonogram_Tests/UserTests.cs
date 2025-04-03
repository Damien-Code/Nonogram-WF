//using Newtonsoft.Json;
//using Nonogram_WF;
//using Nonogram_WF.Controllers;
//using Nonogram_WF.Database;
//using Nonogram_WF.Models;

//namespace Nonogram_Tests
//{
//    [TestClass]
//    public sealed class UserTests
//    {
//        [TestMethod]
//        public void Test_StoreUser()
//        {
//            //Users user = new Users();
//            //JSON_RW.WriteFile(user);

//            //var AllUsers = JSON_RW.GetUsers();

//            //Assert.IsNotNull(AllUsers);
//            //Assert.IsTrue(AllUsers.Users.Count == 1);
//            //Assert.AreEqual(AllUsers.Users.Last(), user);
//        }

//        [TestMethod]
//        public void Test_AccountCannotBeCreatedIfEmailExists_CheckEmailExists_ReturnsTrue()
//        {
//            Users user = new Users() { Email = "test@example.com" };
//            Users.SetUser(user.Email, new DPassword("",""), new Settings("",""),new UserHistory());
//            //JSON_RW.WriteFile(user); 
//            //dit is waar je error zit, het is nu geen users list maar een plain user. Allusers is dan empty
            
//            Users user2 = new Users(){ Email = "test@example.com" };

//            var result = LoginController.CheckEmailExists(user2.Email);
//            if (result.user.Email != null) {
//                Assert.IsTrue(result.boolean);
//                return;
//            }
//            Assert.IsFalse(true);
//        }

//        [TestMethod]
//        public void TestMethod2()
//        {
//        }
//    }
//}
