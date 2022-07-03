using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ToyRobotTest.Classes;

namespace RobotRobotTest
{
    public class Processor
    {
        public Command Command;
        public Table Table = new Table(5, 5);
        public string Message = "";      
        public string Start(List<string> commands, Toy toy)
        {
            Command = new Command(Table, toy);
            foreach (string command in commands)
            {
                ProcessCommand(command);               
                if (Message.Length > 1)
                {
                    break;
                }
            }
            return Message;
        }

        public void ProcessCommand(string command)
        {
            if (Regex.IsMatch(command, "^PLACE"))
            {
                string[] coordinates = command.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (coordinates.Length == 4)
                {
                    int xPosition = Int32.Parse(coordinates[1]);
                    int yPosition = Int32.Parse(coordinates[2]);

                    Command.Place(xPosition, yPosition, coordinates[3]);

                }
                if (Command.Toy == null)
                {
                    Message = "Invalid Placement";
                }
            }
            else if (command.Equals("MOVE") || command.Equals("RIGHT") || command.Equals("LEFT"))
            {
                Command.RobotMoves(command.ToLower());
            }
            else if (command.Equals("REPORT"))
            {
                Message = Command.Report();
            }
            else
            {
                Message = "Invalid Command";
            }
        }
    }
}
