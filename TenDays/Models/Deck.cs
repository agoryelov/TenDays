using System.Collections.Generic;
using System.Xml.Serialization;

namespace TenDays.Models
{
    [XmlRoot("Deck")]
    public class Deck
    {
        [XmlElement("Card", typeof(Card))]
        public List<Card> Cards { get; set;  }
    }
}
