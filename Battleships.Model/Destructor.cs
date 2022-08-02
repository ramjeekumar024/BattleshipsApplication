namespace Battleships.Model
{
    public class Destructor : Ship
    {
        public Destructor(ShipDirection direction) : base(direction) { }

        public override int Length
        {
            get
            {
                return 4;
            }
        }
    }
}
