using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class InventoryEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        // divider
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

        // helpbox
        EditorGUILayout.TextArea("Enhance Equip- increases selected equipment's value by 2\n" +
                                 "Upgrade Equip- raises selected equipment's rarity by 1 tier\n" + 
                                 "Reset All Stats- resets all equipment values and rarities", GUI.skin.GetStyle("HelpBox"));

        Inventory inventory = (Inventory)target;

        GUILayout.BeginHorizontal();

            if (GUILayout.Button("ENHANCE EQUIP"))
            {
                inventory.Enhance();
            }

            if (GUILayout.Button("UPGRADE EQUIP"))
            {
                inventory.Upgrade();
            }

            if (GUILayout.Button("RESET ALL STATS"))
            {
                inventory.ResetAllStats();
            }

        GUILayout.EndHorizontal();
    }
}
