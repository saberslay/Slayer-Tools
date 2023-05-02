using System.Collections;
using UnityEditor;
using UnityEngine;

namespace Saberslay.SlayTools.HelperFunctions {
    public class Button {
        public static void linkButton(int Width, int Height, string title, string link) {
            if (GUILayout.Button(title, GUILayout.Width(Width), GUILayout.Height(Height))) {
                Application.OpenURL(link);
            }
        }
    }
    public class Directory {
        public static string CreateFolder(string FolderName) {
            string guid = AssetDatabase.CreateFolder("Assets", $"{FolderName}");
            string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            return newFolderPath;
        }
    }
    public class Timer {
        public static IEnumerator Wait_ForSecondsRealtime(float TimeToWait) {
            yield return new WaitForSecondsRealtime(TimeToWait);
        }
    }
}
