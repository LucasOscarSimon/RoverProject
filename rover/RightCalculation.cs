using System;

namespace TechTest
{
    public class RightCalculation : IPositionCalculation
    {
        public void CalculateNewPosition(Position actualPosition)
        {
            actualPosition.Facing = actualPosition.Facing == CardinalPoints.West ? CardinalPoints.North : (CardinalPoints)((int)actualPosition.Facing + 1);
            Console.WriteLine($"Rover is now at {actualPosition.Coordinates.X}, {actualPosition.Coordinates.Y} - facing {actualPosition.Facing}");
        }
    }
}