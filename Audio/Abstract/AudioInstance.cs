


using UnityEngine;

namespace MK.TCG.Core
{
    [RequireComponent(typeof(AudioSource))]
    public abstract class AudioInstance : MonoBehaviour
    {
        public string clipName;
        [Range(0, 1)] public float volume;
        public AudioSource Source { get; protected set; }
        public AudioClip CurrentClip { get; private set; }

        protected void Awake() {

            Source = GetComponent<AudioSource>();
            AudioManager.SetVolume(Source, volume);
            CurrentClip = Paths.GetAudioClip(clipName);
        }

        protected virtual void Start() {

            if (CurrentClip != null) AudioManager.SetClip(Source, CurrentClip);
            else Debugger.Log("AudioInstance: Der Clip existiert nicht.");
        }
    }
}