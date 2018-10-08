namespace TechTest
{
    public class Position
    {
        public CardinalPoints Facing { get; set; }
        public Coordinates Coordinates { get; set; }

        public Position()
        {
            Facing = CardinalPoints.North;
            Coordinates = new Coordinates();
        }
    }
}