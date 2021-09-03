
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

namespace MK.TCG.Core
{
    public abstract class NavItem : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
    {
        protected Image Panel { get; set; }
        public TextMeshProUGUI TextElement { get; protected set; }
        protected NavItemFunc Functionality { get; set; }

        public abstract Color32 GetColor();
        public abstract Color32 GetHoverColor();

        protected virtual void OnMouseHover() {

            Panel.color = GetHoverColor();
        }

        protected virtual void OnMouseLeave() {

            Panel.color = GetColor();
        }

        protected void Awake() {

            Panel = GetComponentInChildren<Image>();
            TextElement = GetComponentInChildren<TextMeshProUGUI>();
            Functionality = GetComponent<NavItemFunc>();
        }

        protected void Start() {

            gameObject.SetName("NavItem: " + TextElement.text);

            if (Functionality == null)
                Debugger.Log($"NavItem \"{gameObject.name}\" is missing its functionality");
        }

        public void OnPointerDown(PointerEventData eventData) {

            if (Functionality == null) return;
            Functionality.Execute();
            Debugger.Log("Menu Nav Item: Functionality executed.");
        }

        public void OnPointerEnter(PointerEventData eventData) {

            Debugger.Log("Menu Nav Item: OnPointerEnter");
            OnMouseHover();
        }

        public void OnPointerExit(PointerEventData eventData) {

            Debugger.Log("Menu Nav Item: OnPointerExit");
            OnMouseLeave();
        }
    }
}
