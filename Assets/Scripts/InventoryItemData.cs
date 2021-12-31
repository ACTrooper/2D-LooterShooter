using UnityEngine;

[CreateAssetMenu(menuName = "Inventory Item")]
public class InventoryItemData : ScriptableObject
{
    public string id;
    public string displayName;
    public Sprite Icon;
    public enum PossibleItemTypes { Gun, Shield, Grenade};
    public PossibleItemTypes ItemType;
    public Object UseScript;
}
