using System;
using System.Collections.Generic;
using TechTest;

namespace mr_tech_test_master
{
    public class RoverConsoleApp
    {
        public static void Main()
        {
            var rover = new Rover(new Position(), new PositionInfo());
            var equivalenceCommands = new Dictionary<string,Commands>
            {
                { "L", Commands.TurnLeft},
                { "R", Commands.TurnRight},
                { "F", Commands.Forward}
            };

            while (true)
            {
                var userInput = Console.ReadLine()?.ToUpper();

                if (equivalenceCommands.TryGetValue(userInput, out var command))
                {
                    rover.Move(command);
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }   
            }
        }
    }
}
