using System;
using System.Collections.Generic;
using System.Text;
using TenDays.Models;

namespace TenDays.GameLogic
{
    public class Game
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public Board GameBoard { get; set; } = new Board();
        public int StartingPlayerIndex { get; set; }
        public int ActivePlayerIndex { get; set; }

        public Game(int playerCount, int startingPlayerIndex)
        {
            InitPlayers(playerCount);
            StartingPlayerIndex = startingPlayerIndex;
        }

        public void Start()
        {
            GameBoard.Init();
            ActivePlayerIndex = StartingPlayerIndex;

            foreach (Player player in Players)
            {
                player.DrawFrom(GameBoard.DrawPile, 5);
            }
        }

        public void InitPlayers(int playerCount)
        {
            for (int i = 0; i < playerCount; i++)
            {
                Players.Add(new Player());
            }
        }
    }
}
