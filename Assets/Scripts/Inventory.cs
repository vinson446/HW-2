using System;
using UnityEngine;

public enum Rarity { Common, Rare, Epic, Legendary }

public enum Slot { Head, Chest, Arms, Legs }

// Custom serializable class
[Serializable]
public class Equipment
{
    public string Name;
    public int Value;
    public Rarity Tier;
    public Slot EquipmentSlot;
}

public class Inventory : MonoBehaviour
{
    public int CurrentlyEquippedIndex = 0;
    public Equipment[] CurrentlyEquipped;

    public void SelectEquipment(int index)
    {
        CurrentlyEquippedIndex = index;
    }

    // increases equipment's value (multiply by 2)
    public void Enhance()
    {
        CurrentlyEquipped[CurrentlyEquippedIndex].Value += 2;
    }

    // increases equipment's tier
    public void Upgrade()
    {
        if (CurrentlyEquipped[CurrentlyEquippedIndex].Tier < (Rarity)3)
            CurrentlyEquipped[CurrentlyEquippedIndex].Tier += 1;
    }

    public void ResetAllStats()
    {
        for (int i = 0; i < CurrentlyEquipped.Length; i++)
        {
            CurrentlyEquipped[i].Value = 1;
            CurrentlyEquipped[i].Tier = (Rarity)0;
        }
    }
}
