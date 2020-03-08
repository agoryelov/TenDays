using System;
using System.Collections.Generic;
using TenDays.GameLogic;

namespace TenDays
{
    class Program
    {
        private static string UserInput;
        private static Game TenDaysGame;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 10 Days The Game\n");

            Console.WriteLine("Enter desired number of players (2-4): ");
            UserInput = Console.ReadLine();

            var playerCount = int.Parse(UserInput);
            TenDaysGame = new Game(playerCount, 0);
            TenDaysGame.Start();

            Console.WriteLine("\n\t\tBoard:");
            ConsolePrinter.PrintBoard(TenDaysGame.GameBoard);

            Console.WriteLine("\n\t\tYour Hand:");
            ConsolePrinter.PrintCards(TenDaysGame.Players[0].Cards);
        }
    }
}
