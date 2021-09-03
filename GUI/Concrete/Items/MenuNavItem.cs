
using UnityEngine;

namespace MK.TCG.Core
{
    public sealed class MenuNavItem : NavItem
    {
        public override Color32 GetColor() {

            return ColorProperties.MenuNavItemTint;
        }

        public override Color32 GetHoverColor() {

            return ColorProperties.MenuNavItemHoverTint;
        }
    }
}
