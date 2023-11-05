using System.IO;
using UnityEngine;

namespace Saberslay.SlayTools {
    public class HiResScreenShots : MonoBehaviour {
        public int resWidth = 1920;
        public int resHeight = 1080;

        private bool takeHiResShot = false;
        public static string ScreenShotName(int width, int height) {
            return string.Format("{0}/screenshots/screen{1}x{2} {3}.png",
                                 Application.dataPath,
                                 width, height,
                                 System.DateTime.Now.ToString("HH-mm dd-MM-yyyy"));
        }

        public void TakeHiResShot() {
            takeHiResShot = true;
        }

        public void LateUpdate() {
            takeHiResShot |= Input.GetKeyDown("k");
            Taketheshot();
        }
        public void Taketheshot() {
            if (!Directory.Exists("Assets/screenshots")) {
                //if it doesn't, create it
                Directory.CreateDirectory("Assets/screenshots");

            }
            if (true) {
                RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
                GetComponent<Camera>().targetTexture = rt;
                Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
                GetComponent<Camera>().Render();
                RenderTexture.active = rt;
                screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
                GetComponent<Camera>().targetTexture = null;
                RenderTexture.active = null;
                Destroy(rt);
                byte[] bytes = screenShot.EncodeToPNG();
                string filename = ScreenShotName(resWidth, resHeight);
                File.WriteAllBytes(filename, bytes);
                Debug.Log(string.Format("Took screenshot to: {0}", filename));
                HelperFunctions.Timer.Wait_ForSecondsRealtime(5);
                Application.OpenURL(filename);
                takeHiResShot = false;
            }
        }
    }
}
