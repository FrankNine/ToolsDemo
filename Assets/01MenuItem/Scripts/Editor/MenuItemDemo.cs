﻿using UnityEngine;
using UnityEditor;

public class MenuItemDemo
{
    [MenuItem("ToolsDemo/Rename")]
    public static void Rename()
    {
		// activeGameObject == The one appear on Inspector
        if (Selection.activeGameObject == null)
        {
            Debug.Log("No active GameObject selected");
            return;
        }

        Selection.activeGameObject.name = "Renamed";
    }
}