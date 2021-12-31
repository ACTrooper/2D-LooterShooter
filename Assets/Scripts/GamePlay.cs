// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/GamePlay.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GamePlay : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GamePlay()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GamePlay"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""45b7bb51-946b-455b-badb-ebdc0a4a6748"",
            ""actions"": [
                {
                    ""name"": ""PrimFire"",
                    ""type"": ""Value"",
                    ""id"": ""9778b41a-2605-4c10-8711-f70d10bff62b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AltFire"",
                    ""type"": ""Button"",
                    ""id"": ""e0339fc8-ccfa-4480-8890-1ced85634563"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""11b6a3ef-f157-4993-83f5-7615973a3d64"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""fc40d9fa-7652-4962-8b72-390796d9d2b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InventoryOpen"",
                    ""type"": ""Button"",
                    ""id"": ""d53dda18-3ac5-4938-9baa-ca1eb95dc5c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""818bd73b-f9c7-48d1-b102-f235b416b42c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""05a298e7-95d2-4c3e-983c-6f5fee81b6cf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bb8690d3-f34e-4617-8473-a320e36f273b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1e9d523-e716-4363-9f91-6070c40ef7ca"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20f723a9-b7a2-4ffd-b437-36640e376927"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d78d48c-c7a4-4874-a776-af7f00f636ae"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltFire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c13f39d4-f700-40a2-9597-f04005d325bc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""03601e39-907e-44ca-893c-6803aace614b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""91f73f9d-7b1f-4227-91e9-ed62852c06d1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f12b4dd2-cf29-4230-92a4-4cf743763791"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c65ef95e-0f80-413f-8652-6148c9fd3c5f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3f067850-5c39-471a-8881-43da59608116"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""42db6cae-0cdb-405b-a9b1-33cb115ee8eb"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""661567f9-b2f4-4dcf-b907-125030b1f4ac"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryOpen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5ef264e-ec19-44d8-a909-963cbbe932f3"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""InventoryOpen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""546e91e1-4d3f-4dfe-8bf6-c506c8b3a0b4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5b7cebb-3c64-4456-ad86-504a93860c70"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5923dc43-538a-4780-8d4a-61a051c95775"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_PrimFire = m_Ship.FindAction("PrimFire", throwIfNotFound: true);
        m_Ship_AltFire = m_Ship.FindAction("AltFire", throwIfNotFound: true);
        m_Ship_Movement = m_Ship.FindAction("Movement", throwIfNotFound: true);
        m_Ship_Look = m_Ship.FindAction("Look", throwIfNotFound: true);
        m_Ship_InventoryOpen = m_Ship.FindAction("InventoryOpen", throwIfNotFound: true);
        m_Ship_PickUp = m_Ship.FindAction("PickUp", throwIfNotFound: true);
        m_Ship_MousePosition = m_Ship.FindAction("MousePosition", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_PrimFire;
    private readonly InputAction m_Ship_AltFire;
    private readonly InputAction m_Ship_Movement;
    private readonly InputAction m_Ship_Look;
    private readonly InputAction m_Ship_InventoryOpen;
    private readonly InputAction m_Ship_PickUp;
    private readonly InputAction m_Ship_MousePosition;
    public struct ShipActions
    {
        private @GamePlay m_Wrapper;
        public ShipActions(@GamePlay wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimFire => m_Wrapper.m_Ship_PrimFire;
        public InputAction @AltFire => m_Wrapper.m_Ship_AltFire;
        public InputAction @Movement => m_Wrapper.m_Ship_Movement;
        public InputAction @Look => m_Wrapper.m_Ship_Look;
        public InputAction @InventoryOpen => m_Wrapper.m_Ship_InventoryOpen;
        public InputAction @PickUp => m_Wrapper.m_Ship_PickUp;
        public InputAction @MousePosition => m_Wrapper.m_Ship_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @PrimFire.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnPrimFire;
                @PrimFire.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnPrimFire;
                @PrimFire.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnPrimFire;
                @AltFire.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnAltFire;
                @AltFire.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnAltFire;
                @AltFire.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnAltFire;
                @Movement.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnLook;
                @InventoryOpen.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnInventoryOpen;
                @InventoryOpen.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnInventoryOpen;
                @InventoryOpen.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnInventoryOpen;
                @PickUp.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnPickUp;
                @MousePosition.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimFire.started += instance.OnPrimFire;
                @PrimFire.performed += instance.OnPrimFire;
                @PrimFire.canceled += instance.OnPrimFire;
                @AltFire.started += instance.OnAltFire;
                @AltFire.performed += instance.OnAltFire;
                @AltFire.canceled += instance.OnAltFire;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @InventoryOpen.started += instance.OnInventoryOpen;
                @InventoryOpen.performed += instance.OnInventoryOpen;
                @InventoryOpen.canceled += instance.OnInventoryOpen;
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);
    public interface IShipActions
    {
        void OnPrimFire(InputAction.CallbackContext context);
        void OnAltFire(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInventoryOpen(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
