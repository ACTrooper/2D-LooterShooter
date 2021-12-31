using UnityEngine;

public class WorldItem : MonoBehaviour
{
    public InventoryItemData referenceItem;
    public void OnHandlePickUp()
    {

            InventorySystem.current.Add(referenceItem);
        if (InventorySystem.current.CurrentInventorySpace + 1 <= InventorySystem.current.MaxInventorySpace)
        {
            Destroy(gameObject);
        }
    }
}