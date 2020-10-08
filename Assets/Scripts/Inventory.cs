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
    public Equipment[] CurrentlyEquipped;
}
