using System;

namespace TechTest
{
    public class LeftCalculation : IPositionCalculation
    {
        public Position CalculateNewPosition(Position actualPosition)
        {
            actualPosition.Facing = actualPosition.Facing == CardinalPoints.North ? CardinalPoints.West : (CardinalPoints)((int)actualPosition.Facing -1);
            Console.WriteLine($"Rover is now at {actualPosition.Coordinates.X}, {actualPosition.Coordinates.Y} - facing {actualPosition.Facing}");
            return actualPosition;
        }
    }
}