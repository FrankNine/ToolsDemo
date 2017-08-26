using UnityEngine;
using UnityEditor;

public class AssetDatabaseDemo
{
    [MenuItem("ToolsDemo/List Assets")]
    public static void ListAssets()
    {
        string[] textureGUIDs = AssetDatabase.FindAssets("t:Texture",
                                                         new string[] {"Assets/02AssetDatabase"});
        foreach (string guid in textureGUIDs)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            Debug.Log(path);
        }
    }
}
