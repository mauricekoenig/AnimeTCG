

using UnityEngine;

namespace MK.TCG.Core
{
    [CreateAssetMenu(fileName = "New Card", menuName = "Scriptable Objects/Card", order = 0)]
    public sealed class Card : ScriptableObject
    {
        public string Name;
        public int ID;
        public int Health;
        public int Attack;
        public int Resources;
        public Sprite Artwork;
        public KeywordList Keywords;
    }
}