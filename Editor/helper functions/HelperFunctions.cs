using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Saberslay.SlayTools.Editor.helper_functions {
    public static class HelperFunctions {
        public static void linkButton(int Width, int Height, string title, string link) {
            if (GUILayout.Button(title, GUILayout.Width(Width), GUILayout.Height(Height))) {
                Application.OpenURL(link);
            }
        }
    }
}
