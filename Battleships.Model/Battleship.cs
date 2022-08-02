namespace Battleships.Model
{
    public class Battleship : Ship
    {
        public Battleship(ShipDirection direction) : base(direction) { }

        public override int Length
        {
            get
            {
                return 5;
            }
        }

    }
}
