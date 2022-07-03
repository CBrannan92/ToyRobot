using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ToyRobotTest.Classes;

namespace RobotRobotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot toy = new Robot();

            List<string> commands = new List<string>();
            Console.WriteLine("Please enter commands for {0}", toy.toyName);
            while (true)
            {
                string line = Console.ReadLine();
                commands.Add(line.ToUpper());

                if (line.ToUpper().Equals("REPORT"))
                {
                    Console.WriteLine(Commander(commands, toy));
                    commands.Clear();
                    
                }

            }
        }

        public static string Commander(List<string> commands, Toy toy)
        {
            Processor processor = new Processor();
            return processor.Start(commands, toy);
        }
    }
}
