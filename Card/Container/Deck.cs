

using System.Collections.Generic;

namespace MK.TCG.Core
{
    public sealed class Deck
    {
        public string Name { get; }
        public List<Card> Cards { get; private set; }

        public Deck (List<Card> cards, string name) {

            Cards = cards;
            Name = name;
        }
    }
}