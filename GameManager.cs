



using System.Collections.Generic;
using UnityEngine;

namespace MK.TCG.Core
{
    public sealed class GameManager : MonoBehaviour
    {
        public List<GameObject> cards = new List<GameObject>();

        private void Start() {

            for (int i = 0; i < 5; i++) {

                var t = (float)i / (5 - 1);

                var x = Mathf.Lerp(-5, 5, t) * .5f;
                var y = Mathf.Sin(t * Mathf.PI) * .5f;
                var z = Mathf.Lerp(0.3f, 0, t);
                var zRot = Mathf.Lerp(20, -20, t) * 1f;

                var pos = Vec.Get(x, y, z);
                var rot = Quaternion.Euler(0, 0, zRot);

                cards.Add(CardCreator.CreateFrame("Young Goku", pos, rot));

            }

        }

        //private void Update() {

        //    if (!instantiated) return;

        //    for (int i = 0; i < cards.Count; i++) {

        //        var t = (float)i / (cards.Count - 1);

        //        var x = Mathf.Lerp(-5, 5, t) * .5f;
        //        var y = Mathf.Sin(t * Mathf.PI) * .5f;
        //        var z = Mathf.Lerp(20, -20, t) * 1f;

        //        var pos = Vec.Get(x, y, 0);
        //        var rot = Quaternion.Euler(0, 0, z);

        //        cards[i].SetPosition(pos);
        //        cards[i].SetRotation(rot);

        //    }
        //}

    }
}