

using UnityEngine;

namespace MK.TCG.Core
{
    public static class Paths
    {
        public const string GameObjects = "Prefabs/GameObjects/";
        public const string Cards = "Prefabs/Scriptable Objects/Cards/";
        public const string Audio = "Audio/";

        public static GameObject GetObject (string name) {

            return Resources.Load<GameObject>(GameObjects + name);
        }
        public static Card GetCard (string name) {

            return Resources.Load<Card>(Cards + name);
        }
        public static AudioClip GetAudioClip (string name) {

            return Resources.Load<AudioClip>(Audio + name);
        }
        
    }
}