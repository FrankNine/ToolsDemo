using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// From https://docs.unity3d.com/ScriptReference/PropertyDrawer.html
[CustomPropertyDrawer(typeof(CharacterData))]
public class CharacterDataDrawer : PropertyDrawer {

	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Using BeginProperty / EndProperty on the parent property means that
        // prefab override logic works on the entire property.
        EditorGUI.BeginProperty(position, label, property);

        // Draw label
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        // Don't make child fields be indented
        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // Calculate rects
        float hpWidth = 50;
        float mpWidth = 50;
        float nameWidth = position.width - hpWidth - mpWidth; 
        var nameRect = new Rect(position.x, position.y, nameWidth, position.height);
        var hpRect = new Rect(position.x + nameWidth + 5, position.y, hpWidth, position.height);
        var mpRect = new Rect(position.x + nameWidth + 5 + hpWidth + 5, position.y, mpWidth, position.height);

        // Draw fields - passs GUIContent.none to each so they are drawn without labels
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("Name"), GUIContent.none);
        EditorGUI.PropertyField(hpRect, property.FindPropertyRelative("HP"), GUIContent.none);
        EditorGUI.PropertyField(mpRect, property.FindPropertyRelative("MP"), GUIContent.none);

        // Set indent back to what it was
        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}
