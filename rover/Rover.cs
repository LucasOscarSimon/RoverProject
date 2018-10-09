namespace TechTest
{
    public class Rover
    {
        private readonly Position _position;
        private readonly PositionInfo _positionInfo;

        public Rover(Position position, PositionInfo positionInfo)
        {
            _position = position;
            _positionInfo = positionInfo;
        }

        public void Move(Commands command)
        {
            //Should we include a guard clause?
            _positionInfo.CalculateNewPosition(command, _position);
        }
    }
}
