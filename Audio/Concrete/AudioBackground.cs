
namespace MK.TCG.Core
{
    public sealed class AudioBackground : AudioInstance
    {
        protected override void Start() {

            if (CurrentClip != null) AudioManager.SetPlayClip(Source, CurrentClip);
            else Debugger.Log("AudioInstance: Der Clip existiert nicht.");
        }
    }
}
