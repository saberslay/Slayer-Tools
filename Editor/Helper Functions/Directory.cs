using UnityEditor;
using UnityEngine;

namespace Saberslay.SlayTools.HelperFunctions {
    public class Directory : MonoBehaviour {
        public static string CreateFolder(string FolderName) {
            string guid = AssetDatabase.CreateFolder("Assets", $"{FolderName}");
            string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            return newFolderPath;
        }
        //public static string CreateTextFile(string FileName) {
        //    string guid = AssetDatabase.CreateAsset(, $"{FileName}.txt");
        //    string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
        //    return newFolderPath;
        //}
    }
}
