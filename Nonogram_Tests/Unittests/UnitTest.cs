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
        /*
         * een codeblok dat de nauwkeurigheid van een kleiner, geïsoleerd blok applicatiecode verifieert, meestal een functie of methode
         */

        [TestMethod]
        public void Test_UnitTest_CellCountIsGridSizeTimesGridSize()
        {
            int gridSize = 7;
            int cellCount = 0;
            int[][] testGrid = GameController.initializeGrid(gridSize);
            
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
        public void Test_UserCanBeCreated()
        {
            Users user = new Users();
            Users.SetUser(user.Email, new DPassword("", ""), new Settings("", ""), new UserHistory());
          
            var AllUsers = JSON_RW.GetUsers();

            Assert.IsNotNull(AllUsers);
            Assert.IsTrue(AllUsers.Users.Count == 1);
            Assert.AreEqual(AllUsers.Users.Last(), user);
        }
    }
}
