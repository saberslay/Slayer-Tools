using UnityEditor;
using UnityEngine;

namespace Saberslay.SlayTools.editor.PopupWindows
{
    public class PopupWindows : EditorWindow {
        [MenuItem("Slayer Tools/Help/About")]
        public static void About() {
            GetWindow<PopupWindows>("About");
        }
        void OnGUI() {
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            GUILayout.Label("If you like to support me in development in this tool");
            HelperFunctions.Button.linkButton(110, 20, "Buy me a Coffee", "https://ko-fi.com/saberslay");
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
        }
    }
}