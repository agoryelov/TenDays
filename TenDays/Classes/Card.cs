using System;
using System.Collections.Generic;
using System.Text;

namespace TenDays.Classes
{
    class Card
    {
        private String _stateName { get; set; }
        private String _stateAbbreviation { get; set; }

        public Card(String stateName, String stateAbbreviation)
        {
            _stateName = stateName;
            _stateAbbreviation = stateAbbreviation;
        }
    }
}
