
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MK.TCG.Core
{
    public sealed class NavItemFuncChangeScene : NavItemFunc
    {
        [SerializeField] private int sceneID;

        public override void Execute() {

            SceneManager.LoadScene(sceneID);
        }
    }
}
