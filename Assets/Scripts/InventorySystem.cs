using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    [SerializeField]
    public static InventorySystem current;
    public Dictionary<InventoryItemData, InventoryItem> m_itemDictionary;
    public List<InventoryItem> inventory;
    public int MaxInventorySpace;
    public int CurrentInventorySpace;
    public InventoryItem CurrentWeapon;
    public void Awake()
    {
        if(current == null)
        {
            DontDestroyOnLoad(gameObject);
            current = this;
        }
        else
        {
            Destroy(gameObject);
        }
        inventory = new List<InventoryItem>();
        m_itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
    }
    public void SetCurrentWeapon(int InventorySlot)
    {
        
        //CurrentWeapon = inventory[InventorySlot - 1];
    }
    public void Update()
    {
        CurrentInventorySpace = inventory.Count; 
    }
    public delegate void UpdateInventoryUI();
    public static event UpdateInventoryUI onInventoryChanged;
    public InventoryItem Get(InventoryItemData referenceData)
    {
        if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            return value;
        }
        return null;
    }
    public void Add(InventoryItemData referenceData)
    {
        if (CurrentInventorySpace + 1 <= MaxInventorySpace)
        {
            if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
            {
                value.AddToStack();
            }
            else
            {
                InventoryItem NewItem = new InventoryItem(referenceData);
                inventory.Add(NewItem);
                m_itemDictionary.Add(referenceData, NewItem);
            }
            onInventoryChanged();
        }
    }
    public void Remove(InventoryItemData referenceData)
    {
        if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.RemoveFromStack();

            if (value.stackSize == 0)
            {
                inventory.Remove(value);
                m_itemDictionary.Remove(referenceData);
            }
        }
        onInventoryChanged();
    }
}
