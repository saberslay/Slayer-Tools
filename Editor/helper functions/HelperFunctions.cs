using System.Collections;
using UnityEngine;

namespace Saberslay.SlayTools.HelperFunctions {
    public class Button {
        public static void linkButton(int Width, int Height, string title, string link) {
            if (GUILayout.Button(title, GUILayout.Width(Width), GUILayout.Height(Height))) {
                Application.OpenURL(link);
            }
        }
    }
    public class Timer {
        public static IEnumerator Wait_ForSecondsRealtime(float TimeToWait) {
            yield return new WaitForSecondsRealtime(TimeToWait);
        }
    }
}
