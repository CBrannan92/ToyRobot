using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotTest
{
     interface IToy
    {      
        void Move();
        void TurnLeft();
        void TurnRight();
        string Report();
    }
}
