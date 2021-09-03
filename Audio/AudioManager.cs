using UnityEngine;

namespace MK.TCG.Core
{
    public sealed class AudioManager : MonoBehaviour
    {
        private static AudioManager Instance;

        private void Awake() {

            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            DontDestroyOnLoad(gameObject);
        }

        public static void SetVolume (AudioSource source, float volume) {

            source.volume = volume;
        }

        public static AudioClip GetClip(AudioSource source) {

            return source.clip;
        }
        public static void SetClip (AudioSource source, AudioClip audioClip) {

            source.clip = audioClip;
        }

        public static void SetPlayClip(AudioSource source, AudioClip audioClip) {

            SetClip(source, audioClip);
            PlayClip(source);
        }
        public static void PlayClip (AudioSource source) {

            if (source.clip == null) return;
            source.Play();
        }
    }

}