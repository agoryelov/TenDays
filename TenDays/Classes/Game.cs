using System;
using System.Collections.Generic;
using System.Text;

namespace TenDays
{
    class Game
    {
        private List<Player> _players { get; set; }
        private int _startingPlayerIndex { get; set; }

        public Game(List<Player> players, int startingPlayerIndex)
        {
            _players = players;
            _startingPlayerIndex = startingPlayerIndex;
        }

        public String getGameBoard()
        {
            return "";
        }

        public String getCardsInPlayerHand(int playerIndex)
        {
            Player player = _players[playerIndex];
            return player.getCardsInHand();
        }
    }
}
