using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public GetInput MainInput;
    public enum ControlMethod { Keyboard, Controller};
    public ControlMethod ControlStyle;

    public float ScreenDarkenerAlpha;
    public float MenuOutTime;
    public float PlayerSpeed;
    public float Offset;
    public float TurnRate;
    public bool FixJitter;
    public bool InventoryIsOn;

    public bool AbleToMove;
    public bool AbleToLook;
    public bool AbleToPickUp;

    [SerializeField]
    public static PlayerController current;
    public Canvas UICanvas;
    public Camera Camera;
    public Collider2D CurrentWeaponCollider;
    public GridLayoutGroup GridController;
    public UnityEngine.UI.RawImage ScreenDarkener;
    public GameObject ObjectToLookAt;
    public GameObject Graphic;
    public SpriteRenderer Cursor;
    public GameObject BagLocation;
    public GameObject NewBagLocation;
    private Vector3 OldBagLocation;
    public GameObject ImageLocation;
    public GameObject NewImageLocation;
    private Vector3 OldImageLocation;
    public GameObject DescLocation;
    public GameObject NewDescLocation;
    private Vector3 OldDescLocation;

    private void Awake()
    {
        if (current == null)
        {
            DontDestroyOnLoad(gameObject);
            current = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        OldBagLocation = BagLocation.transform.position;
        OldImageLocation = ImageLocation.transform.position;
        OldDescLocation = DescLocation.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if(AbleToMove)
        {
            this.transform.Translate(new Vector3(MainInput.PlayerMovement.x * PlayerSpeed, MainInput.PlayerMovement.y * PlayerSpeed, 0), Space.World);
        }
        if (AbleToLook && ControlStyle == ControlMethod.Controller)
        {
            ObjectToLookAt.transform.position = this.transform.position + new Vector3(MainInput.LookDirection.x * Offset, MainInput.LookDirection.y * Offset, 0);
            if(MainInput.LookDirection.x != 0 || MainInput.LookDirection.y != 0)
            {
                Cursor.enabled = true;
                transform.right = Vector3.Lerp(transform.right, (ObjectToLookAt.transform.position - transform.position), TurnRate);
            }
            else
            {
                Cursor.enabled = false;
            }
        }
        if(AbleToLook && ControlStyle == ControlMethod.Keyboard)
        {
            if(Cursor.enabled == false) { Cursor.enabled = true; }
            Vector3 TempPosition = Camera.ScreenToWorldPoint(MainInput.MousePosition);
            ObjectToLookAt.transform.position = new Vector3(TempPosition.x, TempPosition.y, 0f);
            transform.right = Vector3.Lerp(transform.right, (ObjectToLookAt.transform.position - transform.position), TurnRate);
        }
        if(MainInput.InventoryButton)
        {
            if(InventoryIsOn && FixJitter == false)
            {
                AbleToMove = true;
                AbleToLook = true;
                AbleToPickUp = true;
                InventoryIsOn = false;
                FixJitter = true;
                CloseInventoryMenu();
            }
            else if(!InventoryIsOn && FixJitter == false)
            {
                AbleToMove = false;
                AbleToLook = false;
                AbleToPickUp = false;
                InventoryIsOn = true;
                FixJitter = true;
                OpenInventoryMenu();
            }
        }
    }
    public void OpenInventoryMenu()
    {
        LeanTween.alpha(ScreenDarkener.rectTransform, ScreenDarkenerAlpha, MenuOutTime);
        LeanTween.move(BagLocation, NewBagLocation.transform.position, MenuOutTime).setOnComplete(OpenImageBar);
    }
    private void OpenImageBar()
    {
        LeanTween.move(ImageLocation, NewImageLocation.transform.position, MenuOutTime).setOnComplete(OpenDescBar);
    }
    private void OpenDescBar()
    {
        LeanTween.move(DescLocation, NewDescLocation.transform.position, MenuOutTime);
    }


    public void CloseInventoryMenu()
    {
        LeanTween.alpha(ScreenDarkener.rectTransform, 0f, MenuOutTime);
        LeanTween.move(BagLocation, OldBagLocation, MenuOutTime).setOnComplete(CloseImageBar);
    }
    private void CloseImageBar()
    {
        LeanTween.move(ImageLocation, OldImageLocation, MenuOutTime).setOnComplete(CloseDescBar);
    }
    private void CloseDescBar()
    {
        LeanTween.move(DescLocation, OldDescLocation, MenuOutTime);
    }
    public void OnTriggerStay2D(Collider2D ctx)
    {
        if(ctx.CompareTag("World_Item"))
        {
            if (AbleToPickUp && MainInput.PickUpButton)
            {
                ctx.GetComponent<WorldItem>().OnHandlePickUp();
            }
        }
    }
}
