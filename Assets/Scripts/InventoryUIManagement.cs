using System;
using System.Collections;
using UnityEngine;

    public class InventoryUIManagement : MonoBehaviour
    {
        public GameObject m_slotPrefab;
        public TMPro.TextMeshProUGUI InventoryCountDisplay;
        // Use this for initialization
        void Start()
        {
            InventorySystem.onInventoryChanged += OnUpdateInventory;
        }
        private void OnUpdateInventory()
        {
            Debug.Log("Updating UI");
            foreach(Transform t in transform)
            {
                Destroy(t.gameObject);
            }
            DrawInventory();
        }

        public void DrawInventory()
        {
            foreach (InventoryItem item in InventorySystem.current.inventory)
            {
                AddInventorySlot(item);
            }
           InventoryCountDisplay.text = (InventorySystem.current.CurrentInventorySpace + 1) + "/" + InventorySystem.current.MaxInventorySpace;
        }
        public void AddInventorySlot(InventoryItem item)
        {
            GameObject ctx = Instantiate(m_slotPrefab);
            ctx.transform.SetParent(transform, false);
            SlotItem slot = ctx.GetComponent<SlotItem>();
            slot.Set(item);
        }
    }