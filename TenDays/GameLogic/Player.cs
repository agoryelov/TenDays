using System;
using System.Collections.Generic;
using System.Text;
using TenDays.Models;

namespace TenDays.GameLogic
{
    public class Player
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public void DrawFrom(Stack<Card> cardStack, int count)
        {
            for (int i = 0; i < count && cardStack.Count > 0; i++)
            {
                Cards.Add(cardStack.Pop());
            }
        }
    }
}
