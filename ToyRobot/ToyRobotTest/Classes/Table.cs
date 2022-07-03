using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotRobotTest
{
    public  class Table
    {
        public int width;
        public int length;

        public bool IsValidLocation(int xPosition, int yPosition)
        {
            if (xPosition >= 0 && xPosition <= width && yPosition >= 0 && yPosition <= length)
            {
                return true;
            }
            else
            {              
                return false;
            }
        }

        public Table(int width, int length)
        {
            this.width = width;
            this.length = length;
        }
    }
}
