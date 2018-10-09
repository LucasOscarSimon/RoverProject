using System;

namespace TechTest
{
    public class ForwardCalculation : IPositionCalculation
    {
        public void CalculateNewPosition(Position actualPosition)
        {
            switch (actualPosition.Facing)
            {
                case CardinalPoints.North:
                    actualPosition.Coordinates.X++;
                    break;
                case CardinalPoints.East:
                    actualPosition.Coordinates.Y++;
                    break;
                case CardinalPoints.South:
                    actualPosition.Coordinates.X--;
                    break;
                case CardinalPoints.West:
                    actualPosition.Coordinates.Y--;
                    break;
            }
            Console.WriteLine($"Rover is now at {actualPosition.Coordinates.X}, {actualPosition.Coordinates.Y} - facing {actualPosition.Facing}");
        }
    }
}