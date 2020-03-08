using System;
using System.Collections.Generic;

namespace TenDays
{
    class Program
    {
        private static int _activePlayerIndex;
        private static string _userInput;
        private static Game _tenDaysGame;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 10 Days The Game\n");

            Console.WriteLine("Enter desired number of players (2-4): ");
            _userInput = Console.ReadLine();

            var playerCount = Int32.Parse(_userInput);
            var players = new List<Player>();

            //Creating players
            for (int playerIndex = 0; playerIndex < playerCount; playerIndex++)
            {
                var newPlayer = new Player();
                players.Add(newPlayer);
            }

            _activePlayerIndex = 0;
            _tenDaysGame = new Game(players, _activePlayerIndex);

            Console.WriteLine("Displaying game board...");
            _tenDaysGame.getGameBoard();

            Console.WriteLine("Displaying your hand...");
            _tenDaysGame.getCardsInPlayerHand(_activePlayerIndex);
        }
    }
}
