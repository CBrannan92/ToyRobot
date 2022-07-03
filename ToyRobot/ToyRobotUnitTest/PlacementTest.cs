using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotRobotTest;

namespace ToyRobotUnitTest
{
    [TestClass]
    public class PlacementTest
    {
        [TestMethod]
        public void PlacementValid()
        {
            Table table = new Table(5, 5);

            Assert.IsTrue(table.IsValidLocation(1, 1));
            Assert.IsTrue(table.IsValidLocation(3, 1));
            Assert.IsFalse(table.IsValidLocation(6, 3));
            Assert.IsFalse(table.IsValidLocation(4, 6));

        }
    }
}