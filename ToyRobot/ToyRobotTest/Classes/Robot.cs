using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotTest;
using ToyRobotTest.Classes;

namespace RobotRobotTest
{
    public class Robot : Toy
    {
        public Robot()
        {
            xPosition = null;
            yPosition = null;
            direction = "";
            toyName = "T-800";
        }

        public override void Move()
        {
            switch (direction)
            {
                case "east":
                    if (xPosition != 5)
                    {
                        xPosition += 1;
                    }
                    break;
                case "west":
                    if(xPosition != 0) { 
                    xPosition -= 1;
                    }
                    break;
                case "north":
                    if (yPosition != 5)
                    {
                        yPosition += 1;
                    }
                    break;
                case "south":
                    if (yPosition != 0)
                    {
                        yPosition -= 1;
                    }
                    break;
            }
        }

        public override void TurnLeft()
        {
            switch (direction)
            {
                case "east":
                    direction = "north";
                    break;
                case "west":
                    direction = "south";
                    break;
                case "north":
                    direction = "west";
                    break;
                case "south":
                    direction = "east";
                    break;
            }
        }

        public override void TurnRight()
        {
            switch (direction)
            {
                case "east":
                    direction = "south";
                    break;
                case "west":
                    direction = "north";
                    break;
                case "north":
                    direction = "east";
                    break;
                case "south":
                    direction = "west";
                    break;
            }
        }

        public override string Report()
        {
            if (xPosition != null && yPosition != null)
            {
                return xPosition + "," + yPosition + "," + direction.ToUpper();
            }
            else
            {
                return "Invalid Placement";
            }
        }
    }
}
