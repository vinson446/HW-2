using UnityEditor;
using UnityEngine;

// InventoryDrawer
[CustomPropertyDrawer(typeof(Equipment))]
public class InventoryDrawer : PropertyDrawer
{
    // draw property in given rect
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        // draw label
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        // don't indent child fields
        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        // calculate rects
        var nameRect = new Rect(position.x - 75, position.y, 120, position.height);
        var valueRect = new Rect(position.x + 60, position.y, 45, position.height);
        var tierRect = new Rect(position.x + 120, position.y, 85, position.height);
        var slotRect = new Rect(position.x + 220, position.y, 65, position.height);

        // draw fields - pass GUIContent.none to each so they are drawn without labels
        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("Name"), GUIContent.none);
        EditorGUI.PropertyField(valueRect, property.FindPropertyRelative("Value"), GUIContent.none);
        EditorGUI.PropertyField(tierRect, property.FindPropertyRelative("Tier"), GUIContent.none);
        EditorGUI.PropertyField(slotRect, property.FindPropertyRelative("EquipmentSlot"), GUIContent.none);

        // reset indent
        EditorGUI.indentLevel = indent;

        EditorGUI.EndProperty();
    }
}
