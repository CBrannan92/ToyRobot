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

    public class ResultTest
    {
        [TestMethod]
        public void ReportResult()
        {
            Robot toy = new Robot
            {
                direction = "south",
                xPosition = 1,
                yPosition = 1,
            };

            string expectedReportResult = "1,1,SOUTH";
            string actualReportResult = toy.Report();

            Assert.AreEqual(expectedReportResult, actualReportResult);
        }
    }
}
