using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;


public class MenuItemDemo
{
    [MenuItem("ToolsDemo/MenuItem/Rename", isValidateFunction: false, priority: 0)]
    public static void Rename()
    {
        // activeGameObject == The one appear on Inspector
        var selectedGameObject = Selection.activeGameObject;
        if (selectedGameObject == null)
        {
            Debug.Log("No active GameObject selected");
            return;
        }

        selectedGameObject.name = "Renamed";
    }


    [MenuItem("ToolsDemo/MenuItem/Rename with scene dirty flag", isValidateFunction: false, priority: 1)]
    public static void RenameWithSceneDirtyFlag()
    {
        var selectedGameObject = Selection.activeGameObject;
        if (selectedGameObject == null)
        {
            Debug.Log("No active GameObject selected");
            return;
        }

        selectedGameObject.name = "Renamed";
        EditorSceneManager.MarkSceneDirty(SceneManager.GetActiveScene());
    }


    [MenuItem("ToolsDemo/MenuItem/Set layer with dirty flag", isValidateFunction: false, priority: 1)]
    public static void RenameWithDirtyFlag()
    {
        var selectedGameObject = Selection.activeGameObject;
        if (selectedGameObject == null)
        {
            Debug.Log("No active GameObject selected");
            return;
        }

        selectedGameObject.layer = 2;
        EditorUtility.SetDirty(selectedGameObject);
    }


    [MenuItem("ToolsDemo/MenuItem/Rename with Undo", isValidateFunction: false, priority: 2)]
    public static void RenameWithUndo()
    {
        var selectedGameObject = Selection.activeGameObject;
        if (selectedGameObject == null)
        {
            Debug.Log("No active GameObject selected");
            return;
        }

        Undo.RecordObject(Selection.activeGameObject, "My Rename GameObject");
        selectedGameObject.name = "Renamed";
    }
}