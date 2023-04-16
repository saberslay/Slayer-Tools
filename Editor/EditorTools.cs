using UnityEditor;
using UnityEngine;

namespace Saberslay.SlayTools.Editor.EditorTools {
    public class EditorTools : EditorWindow {
        [MenuItem("Slayer Tools/Create Parent For Selected")]
        static void CreateParentForSelected() {
            if (Selection.gameObjects.Length >= 1) {
                foreach (GameObject obj in Selection.gameObjects) {
                    GameObject go = new GameObject(obj.name);
                    go.transform.position = new Vector3(0, 0, 0);
                    obj.transform.parent = go.transform;
                }
            } else {
                Debug.LogError("You must select GameObjects for This to work");
            }
        }
        [MenuItem("Slayer Tools/Console In Game Window")]
        static void ConsoleInGameWindow() {
            GameObject go = new GameObject("Console In Game Window");
            go.transform.position = new Vector3(0, 0, 0);
            go.AddComponent(typeof(ConsoleInGameWindow));
        }
    }
}