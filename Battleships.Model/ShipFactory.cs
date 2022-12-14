using System;

namespace Battleships.Model
{
    public class ShipFactory
    {
        public Ship Get(string shipType, ShipDirection direction)
        {
            switch (shipType)
            {
                case "Battleship":
                    return new Battleship(direction);
                case "Destructor":
                    return new Destructor(direction);
                default:
                    throw new InvalidOperationException("The ship type is invalid");
            }
        }
    }
}
