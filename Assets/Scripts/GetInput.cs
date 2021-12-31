using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class GetInput : MonoBehaviour
{
    public Rigidbody2D rb;
    public PlayerInput PlayerI;
    public PlayerController player;

    public bool PickUpButton;
    public bool Primary_Fire;
    public bool Alt_Fire;
    public bool InventoryButton;
    public Vector2 PlayerMovement;
    public Vector2 LookDirection;
    public Vector2 MousePosition;
    // Use this for initialization
    void Awake()
    {
        PlayerI = GetComponent<PlayerInput>();
        GamePlay playerinputactions = new GamePlay();
        playerinputactions.Ship.Enable();
        playerinputactions.Ship.PrimFire.performed += PrimFire_performed;
        playerinputactions.Ship.PrimFire.canceled += PrimFire_performed;
        playerinputactions.Ship.Movement.performed += Movement_performed;
        playerinputactions.Ship.Movement.canceled += Movement_performed;
        playerinputactions.Ship.Look.performed += Look_performed;
        playerinputactions.Ship.Look.canceled += Look_performed;
        playerinputactions.Ship.AltFire.performed += AltFire_performed;
        playerinputactions.Ship.AltFire.canceled += AltFire_performed;
        playerinputactions.Ship.InventoryOpen.performed += InventoryOpen_performed;
        playerinputactions.Ship.InventoryOpen.canceled += InventoryOpen_performed;
        playerinputactions.Ship.PickUp.performed += PickUp_performed;
        playerinputactions.Ship.PickUp.canceled += PickUp_performed;
        playerinputactions.Ship.MousePosition.performed += MousePosition_performed;
        playerinputactions.Ship.MousePosition.canceled += MousePosition_performed;

    }

    private void MousePosition_performed(InputAction.CallbackContext ctx)
    {
        MousePosition = ctx.ReadValue<Vector2>();
    }

    private void PickUp_performed(InputAction.CallbackContext ctx)
    {
        float Temp = ctx.ReadValue<float>();
        if (Temp > 0)
        { PickUpButton = true; }
        else { PickUpButton = false; }
    }

    private void InventoryOpen_performed(InputAction.CallbackContext ctx)
    {
        if(ctx.canceled)
        {
            player.FixJitter = false;
        }
        float Temp = ctx.ReadValue<float>();
        if (Temp > 0)
        { InventoryButton = true; }
        else { InventoryButton = false; }
    }

    private void Look_performed(InputAction.CallbackContext ctx)
    {
        LookDirection = ctx.ReadValue<Vector2>();
    }
    private void AltFire_performed(InputAction.CallbackContext ctx)
    {
        float Temp = ctx.ReadValue<float>();
        if (Temp > 0)
        { Alt_Fire = true; }
        else { Alt_Fire = false; }
    }
    public void Movement_performed(InputAction.CallbackContext ctx)
    {
        PlayerMovement = ctx.ReadValue<Vector2>();
    }
    public void PrimFire_performed(InputAction.CallbackContext ctx)
    {
        float Temp = ctx.ReadValue<float>();
        if(Temp > 0)
        { Primary_Fire = true; }
        else { Primary_Fire = false; }
    }
}