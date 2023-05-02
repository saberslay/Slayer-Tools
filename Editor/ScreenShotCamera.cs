using UnityEditor;
using UnityEngine;

namespace Saberslay.SlayTools.editor.ScreenShotCamera {
    [CustomEditor(typeof(HiResScreenShots))]
    public class ScreenShotCamera : Editor {
        public override void OnInspectorGUI() {
            HiResScreenShots ScreenShots = (HiResScreenShots)target;
            base.OnInspectorGUI();
            GUILayout.Space(10);
            if (GUILayout.Button("Take the picture now!!!")) {
                ScreenShots.Taketheshot();
            }
        }
    }
}