

using UnityEngine;

namespace MK.TCG.Core
{
    public static class CardCreator
    {
        public static GameObject CreateFrame (string cardName) {

            var data = Paths.GetCard(cardName);
            Debugger.Log(data.name);
            Debugger.Log(data.Attack);

            var instance = Object.Instantiate(Paths.GetObject("CardFrame"));
            var frame = instance.GetComponent<CardFrame>();
            frame.SetArtwork(data.Artwork);
            instance.SetName("Card: " + data.Name);

            return instance;
        }
        public static GameObject CreateFrame(string cardName, Vector3 destination) {

            var data = Paths.GetCard(cardName);
            var instance = Object.Instantiate(Paths.GetObject("CardFrame"));
            var frame = instance.GetComponent<CardFrame>();

            frame.SetArtwork(data.Artwork);
            instance.SetName("Card: " + data.Name);
            instance.SetPosition(destination);

            return instance;
        }
        public static GameObject CreateFrame(string cardName, Vector3 destination, Quaternion rotation) {

            var data = Paths.GetCard(cardName);
            var instance = Object.Instantiate(Paths.GetObject("CardFrame"));
            var frame = instance.GetComponent<CardFrame>();

            frame.SetArtwork(data.Artwork);
            instance.SetName("Card: " + data.Name);
            instance.SetPosition(destination);
            instance.SetRotation(rotation);

            return instance;
        }
    }

}