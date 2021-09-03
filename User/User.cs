



using System.Collections.Generic;

namespace MK.TCG.Core
{
    public sealed class User
    {
        public string InGameName { get; }
        public string LoginName { get; }
        public string Password { get; }
        public Deck ActiveDeck { get; set; }
    }
}