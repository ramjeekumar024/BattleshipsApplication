using Battleships.Business;
using System;

namespace Battleships
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var simpleRandomBoardFactory = new SimpleRandomBoardFactory();
            var consoleInterface = new ConsoleInterface();
            var game = new GameProcessor(simpleRandomBoardFactory, consoleInterface);
            game.Play();
            Environment.Exit(0);
        }
    }
}
