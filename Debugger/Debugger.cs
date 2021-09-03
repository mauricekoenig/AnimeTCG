


using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MK.TCG.Core
{
    public sealed class Debugger : MonoBehaviour
    {
        private Canvas canvas;
        private Image console;
        private TextMeshProUGUI messages;
        private List<string> cache = new List<string>();

        [SerializeField] private TMP_InputField clipToChange;
        [SerializeField] private TMP_InputField desiredClip;

        private static Debugger Instance;

        private void Awake() {

            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            canvas = GetComponentInChildren<Canvas>();
            console = GetComponentInChildren<Image>();
            messages = GetComponentInChildren<TextMeshProUGUI>();

            DontDestroyOnLoad(this);
        }

        private void PrivateLog (object obj) {

            if (MessageBoxIsFilled()) messages.text = string.Empty;
            if (cache.Count == 48) cache.Clear();

            messages.text += "\n" + obj.ToString();
            cache.Add(obj.ToString());
        }

        private bool MessageBoxIsFilled() {

            switch (cache.Count) {

                case 8:
                    return true;
                case 16:
                    return true;
                case 24:
                    return true;
                case 32:
                    return true;
                case 40:
                    return true;
                case 48:
                    return true;

                default:
                    return false;
            }
        }

        public static void Log (object obj) {

            Instance.PrivateLog(obj);
        }


        public void ManipulateAudioClip () {

            var gameObject = GameObject.Find(clipToChange.text);

            if (gameObject == null) {

                Log($"Object {clipToChange.text} does not exist.");
                return;
            }

            var instance = gameObject.GetComponent<AudioInstance>();
            if (instance == null) return;

            var clip = Paths.GetAudioClip(desiredClip.text);
            if (clip == null) {

                Log($"AudioManager: \"{desiredClip.text}\" does not exist.");
                return;
            }

            AudioManager.SetPlayClip(instance.Source, clip);
            Log($"AudioManager: \"{desiredClip.text}\" is playing....");
        }
    }

}