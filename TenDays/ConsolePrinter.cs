using System;
using System.Collections.Generic;
using System.Text;
using TenDays.GameLogic;
using TenDays.Models;

namespace TenDays
{
    public class ConsolePrinter
    {
        public const int SPACE_BETWEEN_CARDS = 4;
        public const int CARD_WIDTH = 7;

        public static void PrintCards(List<Card> cards)
        {
            var sb1 = new StringBuilder();
            var sb2 = new StringBuilder();
            var sb3 = new StringBuilder();
            var sb4 = new StringBuilder();
            var sb5 = new StringBuilder();
            var sb6 = new StringBuilder();

            var spaces = new string(' ', SPACE_BETWEEN_CARDS);

            foreach (Card card in cards)
            {
                sb1.Append(" _____ " + spaces);
                sb2.Append("|" + card.CardColor + "    |" + spaces);
                

                if (card.CardType.Equals("State"))
                {
                    sb3.Append("|     |" + spaces);
                    sb4.Append("| " + card.StateAbbr + "  |" + spaces);
                } 
                else if (card.CardType.Equals("Car"))
                {
                    sb3.Append("|-----|" + spaces);
                    sb4.Append("|-o-o-|" + spaces);
                } 
                else if (card.CardType.Equals("Plane"))
                {
                    sb3.Append("|     |" + spaces);
                    sb4.Append("|o-A-o|" + spaces);
                } 
                else
                {
                    sb3.Append("|     |" + spaces);
                    sb4.Append("|     |" + spaces);
                }

                sb5.Append("|     |" + spaces);
                sb6.Append("|____" + card.CardColor + "|" + spaces);
            }

            Console.WriteLine(sb1.ToString());
            Console.WriteLine(sb2.ToString());
            Console.WriteLine(sb3.ToString());
            Console.WriteLine(sb4.ToString());
            Console.WriteLine(sb5.ToString());
            Console.WriteLine(sb6.ToString());
        }

        public static void PrintBoard(Board gameBoard)
        {
            var boardCards = new List<Card>();
            var upsideDownCard = new Card()
            {
                CardType = "State",
                CardColor = " ",
                StateAbbr = "??",
                StateName = ""
            };

            boardCards.Add(upsideDownCard);
            boardCards.Add(gameBoard.DiscardPile_1.Peek());
            boardCards.Add(gameBoard.DiscardPile_2.Peek());
            boardCards.Add(gameBoard.DiscardPile_3.Peek());

            PrintCards(boardCards);
        }

        public static void PrintCard(string cardText, string cardColor)
        {
            var sb = new StringBuilder();
            sb.AppendLine(" _____");
            sb.AppendLine("|" + cardColor + "    |");
            sb.AppendLine("|     |");
            sb.AppendLine("| " + cardText + "  |");
            sb.AppendLine("|     |");
            sb.AppendLine("|____" + cardColor + "|");

            Console.WriteLine(sb.ToString());
        }

        public static void PrintTray(int dayCount)
        {
            var sb = new StringBuilder();
            var space = new string(' ', SPACE_BETWEEN_CARDS);

            for (int dayIndex = 1; dayIndex <= dayCount; dayIndex++)
            {
                sb.Append(" Day " + dayIndex + " ");
                sb.Append(space);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
