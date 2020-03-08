using System.Collections.Generic;
using TenDays.Classes;

namespace TenDays
{
    class Player
    {
        private PlayerColor _color { get; set; }
        private List<Card> _cardsInHand { get; set; }

        public Player()
        {

        }

        public Player(PlayerColor color)
        {
            _color = color;
        }

        public string getCardsInHand()
        {
            return "cards in hand";
        }

        public void drawCard()
        {

        }
    }
}
