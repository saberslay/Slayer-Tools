using UnityEngine;

namespace Saberslay.SlayTools {
    public class ConsoleInGameWindow : MonoBehaviour {

        static string myLog = "";
        private string output;
        private string stack;

        bool ShowConsoleInGameWindow = false;

        void OnEnable() {
            Application.logMessageReceived += Log;
        }

        void OnDisable() {
            Application.logMessageReceived -= Log;
        }

        void Update() {
            if (Debug.isDebugBuild) {
                if (Input.GetKeyDown(KeyCode.Tilde)) {
                    ShowConsoleInGameWindow = !ShowConsoleInGameWindow; 
                }
            }
        }

        public void Log(string logString, string stackTrace, LogType type) {
            output = logString;
            stack = stackTrace;
            myLog = output + "\n" + myLog;
            if (myLog.Length > 5000) {
                myLog = myLog.Substring(0, 4000);
            }
        }

        void OnGUI() {
            if (!ShowConsoleInGameWindow) { return; }
            GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity,
               new Vector3(Screen.width / 1200.0f, Screen.height / 800.0f, 1.0f));
            GUI.TextArea(new Rect(10, 10, 540, 370), myLog);
        }
    }
}
