using UnityEditor;
using UnityEngine;

namespace Saberslay.SlayTools.editor.PopupWindows
{
    public class PopupWindows : EditorWindow {
        static bool showpop = true;
        [MenuItem("Slayer Tools/Info")]
        public static void Init() {
                PopupWindows window = ScriptableObject.CreateInstance<PopupWindows>();
                window.position = new Rect(Screen.width / 2, Screen.height / 2, 440, 150);
                window.ShowPopup();
        }
        void OnGUI() {
            
            EditorGUILayout.LabelField("info", EditorStyles.boldLabel);
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("If you like this tool feel free to", EditorStyles.wordWrappedLabel);
            HelperFunctions.Button.linkButton(110, 20, "Buy me a Coffee", "https://ko-fi.com/saberslay");
            EditorGUILayout.LabelField("If you went to                    ", EditorStyles.wordWrappedLabel);
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("If you like to help me out in the development in this tool", EditorStyles.wordWrappedLabel);
            HelperFunctions.Button.linkButton(110, 20, "Github", "https://github.com/saberslay/Slayer-Tools");
            EditorGUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Close!")) this.Close();
            GUILayout.Space(5);
        }
    }
}