using Newtonsoft.Json;
using Nonogram_WF;
using Nonogram_WF.Controllers;
using Nonogram_WF.Database;
using Nonogram_WF.Models;

namespace Nonogram_Tests
{
    [TestClass]
    public sealed class UnitTest
    {
        

        [TestMethod]
        public void Test_UnitTest_CellCountIsGridSizeTimesGridSize()
        {
            int gridSize = 7;
            int cellCount = 0;
            int[][] testGrid = GameController.InitializeGrid(gridSize);
            
            foreach (int[] row in testGrid)
            {
                foreach (int cell in row)
                {
                    cellCount++;
                }
            }

            Assert.IsTrue(cellCount == (gridSize*gridSize));
        }

        [TestMethod]
        public void Test_AccountCannotBeCreatedIf_PasswordIsLessThan6Char_CheckPassword_ReturnsFalse()
        {
            string TestPassword = "test";
            
            Assert.IsFalse(UserController.CheckPassword(TestPassword));  
        }

        [TestMethod]
        public void Test_AccountCanBeCreatedIf_PasswordIsMoreThan6Char_CheckPassword_ReturnsTrue()
        {
            string TestPassword = "testing";

            Assert.IsTrue(UserController.CheckPassword(TestPassword));
        }

        [TestMethod]
        public void Test_AccountCannotBeCreatedIf_EmailDoesNotMatchSpecifications_CheckEmail_ReturnsFalse()
        {
            // Does not contain @
            string TestEmail = "testingemail.nl";

            Assert.IsFalse(UserController.CheckEmail(TestEmail));
        }

        [TestMethod]
        public void Test_AccountCanBeCreatedIf_EmailDoesMatchSpecifications_CheckEmail_ReturnsTrue()
        {
            
            string TestEmail = "testing@email.nl";

            Assert.IsTrue(UserController.CheckEmail(TestEmail));
        }

    }
}
