
using UnityEngine.UI;
using UnityEngine;

namespace MK.TCG.Core
{
    public sealed class CameraGrabber : MonoBehaviour
    {
        private Canvas canvas;

        private void Awake() {

            canvas = GetComponent<Canvas>();
        }

        private void Start() {

            if (canvas == null) {

                Debugger.Log("Camera Grabber fehlt Canvas.");
                return;
            }

            canvas.worldCamera = Camera.main;
        }
    }

}