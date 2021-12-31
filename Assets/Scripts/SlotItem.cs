using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotItem : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public  Image m_icon;
    public TextMeshProUGUI m_Label;
    public GameObject m_StackOBJ;
    public TextMeshProUGUI m_stackLabel;
    public InventoryItemData RepresentingInventoryItem;
    public Collider2D InputZone;
    public Vector3 OldPosition;
    public Canvas parentCanvas;
    public bool canMove;
    public bool dragging;
    public bool AttempttoSetNewWeapon;
    public void Set(InventoryItem Item)
    {
        m_icon.sprite = Item.data.Icon;
        m_Label.text = Item.data.displayName;
        RepresentingInventoryItem = Item.data;
        if (Item.stackSize <= 1)
        {
            m_StackOBJ.SetActive(false);
            return;
        }

        m_stackLabel.text = Item.stackSize.ToString();
    }
    private void Awake()
    {
        if(InputZone == null)
        { InputZone = GetComponent<BoxCollider2D>(); }
        if (parentCanvas == null)
        { parentCanvas = PlayerController.current.UICanvas; }
        canMove = false;
        dragging = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(PlayerController.current.InventoryIsOn)
        { PlayerController.current.GridController.enabled = false; }
        else
        { PlayerController.current.GridController.enabled = true; }
        if(dragging)
        {
            Vector2 movePos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
            parentCanvas.transform as RectTransform,
            PlayerController.current.MainInput.MousePosition, parentCanvas.worldCamera,
            out movePos);

            Vector3 mousePos = parentCanvas.transform.TransformPoint(movePos);

            this.transform.position = mousePos;
        }
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        OldPosition = this.GetComponent<RectTransform>().position;
        dragging = true;
    }
    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        AttempttoSetNewWeapon = true;
        dragging = false;
        this.GetComponent<RectTransform>().position = OldPosition;
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if(AttempttoSetNewWeapon)
        {
            Debug.Log("Setting New Weapon");
        }
    }
}