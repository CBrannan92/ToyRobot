using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobotTest.Classes
{
    public class Toy : IToy
    {
        public int? xPosition { get; set; }
        public int? yPosition { get; set; }
        public string direction { get; set; }
        public string toyName { get; set; }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }

        public virtual string Report()
        {
            
            throw new NotImplementedException();
        }

        public virtual void TurnLeft()
        {
            throw new NotImplementedException();
        }

        public virtual void TurnRight()
        {
            throw new NotImplementedException();
        }
    }
}
