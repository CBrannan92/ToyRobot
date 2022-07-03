using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobotTest.Classes;

namespace RobotRobotTest
{
    public class Command
    {
        public Table Table;
        public Toy Toy;

        public Command(Table table, Toy toy)
        {
            Table = table;
            Toy = toy;
        }

        public void Place(int xPosition, int yPosition, string direction)
        {
            if (Table.IsValidLocation(xPosition, yPosition))
            {
                Toy.direction = direction.ToLower();
                Toy.xPosition = xPosition;
                Toy.yPosition = yPosition;
            }

        }

        public void RobotMoves(string movement)
        {
            switch (movement)
            {
                case "move":
                    if (Table.IsValidLocation(Toy.xPosition.Value, Toy.yPosition.Value))
                    {
                        Toy.Move();
                    }
                    break;
                case "right":
                    Toy.TurnRight();
                    break;
                case "left":
                    Toy.TurnLeft();
                    break;
            }
        }

        public string Report()
        {
            return Toy.Report();
        }
    }
}
