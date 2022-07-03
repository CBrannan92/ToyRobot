using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotRobotTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotUnitTest
{
    [TestClass]
    public class TurnTest
    {
        [TestMethod]
        public void FacingNorthTurnLeft()
        {
            Robot Toy = new Robot { direction = "north" };

            Toy.TurnLeft();

            Assert.AreEqual("west", Toy.direction);

        }

        [TestMethod]
        public void FacingNorthTurnRight()
        {
            Robot Toy = new Robot { direction = "north" };

            Toy.TurnRight();

            Assert.AreEqual("east", Toy.direction);

        }
    }
}
