

using UnityEngine;
using UnityEngine.UI;

namespace MK.TCG.Core
{
    public sealed class CardFrame : MonoBehaviour
    {
        [SerializeField] private Image artwork;

        public Sprite GetArtwork() {

            return artwork.sprite;
        }

        public void SetArtwork (Sprite sprite) {

            artwork.sprite = sprite;
        }

    }
}