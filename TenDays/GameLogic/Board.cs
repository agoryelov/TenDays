using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using TenDays.Models;

namespace TenDays.GameLogic
{
    public class Board
    {
        public Stack<Card> DrawPile { get; set; }
        public Stack<Card> DiscardPile_1 { get; set; } = new Stack<Card>();
        public Stack<Card> DiscardPile_2 { get; set; } = new Stack<Card>();
        public Stack<Card> DiscardPile_3 { get; set; } = new Stack<Card>();

        public void Init()
        {
            Deck deck = LoadDeck(@".\Resources\Deck.xml");

            List<Card> shuffledCards = Shuffle(deck.Cards);
            DrawPile = new Stack<Card>(shuffledCards);

            DiscardPile_1.Push(DrawPile.Pop());
            DiscardPile_2.Push(DrawPile.Pop());
            DiscardPile_3.Push(DrawPile.Pop());
        }

        private Deck LoadDeck(string filepath)
        {
            var serializer = new XmlSerializer(typeof(Deck));
            var reader = XmlReader.Create(filepath);

            return (Deck) serializer.Deserialize(reader);
        }

        private List<Card> Shuffle(List<Card> cards)
        {
            var rand = new Random();
            return cards.OrderBy(x => rand.Next()).ToList();
        }
    }
}
