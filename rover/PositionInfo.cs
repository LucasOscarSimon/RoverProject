using System.Collections.Generic;

namespace TechTest
{
    public class PositionInfo
    {
        private IDictionary<Commands,IPositionCalculation> PositionCalculation { get; set; }

        public PositionInfo()
        {
            PositionCalculation = new Dictionary<Commands, IPositionCalculation>
            {
                { Commands.TurnLeft,new LeftCalculation()},
                { Commands.TurnRight,new RightCalculation()},
                { Commands.Forward,new ForwardCalculation()},
            };
        }

        public void CalculateNewPosition(Commands command, Position position)
        {
            PositionCalculation[command].CalculateNewPosition(position);
        }
    }
}