// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerStandard"",
            ""id"": ""516f6bee-5af0-4b6d-85e3-db0fd1616fdb"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""10347fd3-75a6-42f4-9a4d-d72798e30602"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""17dd8bb9-48a2-4db2-9506-8208cf0d55c0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Collect"",
                    ""type"": ""Button"",
                    ""id"": ""1622dadb-3d25-4616-ad18-0351740902d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Throw"",
                    ""type"": ""Button"",
                    ""id"": ""69ae11f7-f9c3-4d98-b1e3-36c7591b71cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""73658886-a1d8-45a3-8464-ec881fd4feb6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""25cb6035-5154-4b9c-8b79-898bc257c474"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwapActive"",
                    ""type"": ""Button"",
                    ""id"": ""00aac3ec-3215-4e43-85f2-777ce09e5113"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UseActive"",
                    ""type"": ""Button"",
                    ""id"": ""ff464c30-35ef-4242-8efb-165be2debc24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DropSocks"",
                    ""type"": ""Button"",
                    ""id"": ""c3c78b56-2cb0-4170-9019-e54fe81924ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8852493d-427f-47f9-a452-386fab087008"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Collect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01b329d1-056f-44e2-b13f-58c460f3fd20"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Collect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""569ea0b1-593d-4241-bfc2-6ff09b7d5476"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""154dcfc6-aadb-4701-8a59-8152bea54c82"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Throw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adb26c5a-4892-4cb0-897c-cdcb73ba2da2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e92dd544-9ead-4612-a76e-0f955d9b208a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0108629-d85a-41ff-9bac-b1a8d40880b4"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62f79757-5991-4fff-ba7a-88550b16b83f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f62312f-e89e-4336-bea7-726e427285ec"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""SwapActive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""601cd96b-c1ff-4f57-832f-7d08f0b31f0a"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""SwapActive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""712c5b4b-7237-403a-9df9-81bf880136e1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""31725387-74bc-4f39-a50e-37759a3d403a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e8eda4dd-d59e-4389-bf1d-00b01b2c1106"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""da76602a-00eb-4c31-9bf2-557d98480fae"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c7bcf6e3-4d8d-4ef8-8bb0-687ccea36a76"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""adcc92e0-d403-4460-b3fa-c0719a6d1642"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be7a3b65-f2e2-4b2d-9bd0-446f10a1a4a4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""UseActive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""686414d4-c975-4487-a188-8640899aa922"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""UseActive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""721a2b93-2f7a-4b17-8113-7a526a676d82"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""DropSocks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0537cdef-d8f0-40db-b9be-0dada6f0f0de"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""DropSocks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1aee8230-75f5-4482-90d0-d7a30b581def"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec833fb6-efb3-44d4-97db-7082f275077e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LookKeys"",
                    ""id"": ""20b62b5e-259e-4539-ab01-b2c6174cc3ea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e608be24-2f09-43c9-850b-c82fce67e38b"",
                    ""path"": ""<Keyboard>/home"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9ff3f7bb-6243-4386-9707-ec1e3a86f504"",
                    ""path"": ""<Keyboard>/end"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6b9c092f-b03e-4f32-a7e4-29e000a43278"",
                    ""path"": ""<Keyboard>/delete"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cddf9100-4091-4bcc-bc32-6b165ad9f7bf"",
                    ""path"": ""<Keyboard>/pageDown"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerStandard
        m_PlayerStandard = asset.FindActionMap("PlayerStandard", throwIfNotFound: true);
        m_PlayerStandard_Move = m_PlayerStandard.FindAction("Move", throwIfNotFound: true);
        m_PlayerStandard_Look = m_PlayerStandard.FindAction("Look", throwIfNotFound: true);
        m_PlayerStandard_Collect = m_PlayerStandard.FindAction("Collect", throwIfNotFound: true);
        m_PlayerStandard_Throw = m_PlayerStandard.FindAction("Throw", throwIfNotFound: true);
        m_PlayerStandard_PickUp = m_PlayerStandard.FindAction("PickUp", throwIfNotFound: true);
        m_PlayerStandard_Drop = m_PlayerStandard.FindAction("Drop", throwIfNotFound: true);
        m_PlayerStandard_SwapActive = m_PlayerStandard.FindAction("SwapActive", throwIfNotFound: true);
        m_PlayerStandard_UseActive = m_PlayerStandard.FindAction("UseActive", throwIfNotFound: true);
        m_PlayerStandard_DropSocks = m_PlayerStandard.FindAction("DropSocks", throwIfNotFound: true);
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

    // PlayerStandard
    private readonly InputActionMap m_PlayerStandard;
    private IPlayerStandardActions m_PlayerStandardActionsCallbackInterface;
    private readonly InputAction m_PlayerStandard_Move;
    private readonly InputAction m_PlayerStandard_Look;
    private readonly InputAction m_PlayerStandard_Collect;
    private readonly InputAction m_PlayerStandard_Throw;
    private readonly InputAction m_PlayerStandard_PickUp;
    private readonly InputAction m_PlayerStandard_Drop;
    private readonly InputAction m_PlayerStandard_SwapActive;
    private readonly InputAction m_PlayerStandard_UseActive;
    private readonly InputAction m_PlayerStandard_DropSocks;
    public struct PlayerStandardActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerStandardActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerStandard_Move;
        public InputAction @Look => m_Wrapper.m_PlayerStandard_Look;
        public InputAction @Collect => m_Wrapper.m_PlayerStandard_Collect;
        public InputAction @Throw => m_Wrapper.m_PlayerStandard_Throw;
        public InputAction @PickUp => m_Wrapper.m_PlayerStandard_PickUp;
        public InputAction @Drop => m_Wrapper.m_PlayerStandard_Drop;
        public InputAction @SwapActive => m_Wrapper.m_PlayerStandard_SwapActive;
        public InputAction @UseActive => m_Wrapper.m_PlayerStandard_UseActive;
        public InputAction @DropSocks => m_Wrapper.m_PlayerStandard_DropSocks;
        public InputActionMap Get() { return m_Wrapper.m_PlayerStandard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerStandardActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerStandardActions instance)
        {
            if (m_Wrapper.m_PlayerStandardActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnLook;
                @Collect.started -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnCollect;
                @Collect.performed -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnCollect;
                @Collect.canceled -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnCollect;
                @Throw.started -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnThrow;
                @Throw.performed -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnThrow;
                @Throw.canceled -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnThrow;
                @PickUp.started -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnPickUp;
                @Drop.started -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnDrop;
                @SwapActive.started -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnSwapActive;
                @SwapActive.performed -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnSwapActive;
                @SwapActive.canceled -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnSwapActive;
                @UseActive.started -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnUseActive;
                @UseActive.performed -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnUseActive;
                @UseActive.canceled -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnUseActive;
                @DropSocks.started -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnDropSocks;
                @DropSocks.performed -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnDropSocks;
                @DropSocks.canceled -= m_Wrapper.m_PlayerStandardActionsCallbackInterface.OnDropSocks;
            }
            m_Wrapper.m_PlayerStandardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Collect.started += instance.OnCollect;
                @Collect.performed += instance.OnCollect;
                @Collect.canceled += instance.OnCollect;
                @Throw.started += instance.OnThrow;
                @Throw.performed += instance.OnThrow;
                @Throw.canceled += instance.OnThrow;
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
                @SwapActive.started += instance.OnSwapActive;
                @SwapActive.performed += instance.OnSwapActive;
                @SwapActive.canceled += instance.OnSwapActive;
                @UseActive.started += instance.OnUseActive;
                @UseActive.performed += instance.OnUseActive;
                @UseActive.canceled += instance.OnUseActive;
                @DropSocks.started += instance.OnDropSocks;
                @DropSocks.performed += instance.OnDropSocks;
                @DropSocks.canceled += instance.OnDropSocks;
            }
        }
    }
    public PlayerStandardActions @PlayerStandard => new PlayerStandardActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IPlayerStandardActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnCollect(InputAction.CallbackContext context);
        void OnThrow(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
        void OnSwapActive(InputAction.CallbackContext context);
        void OnUseActive(InputAction.CallbackContext context);
        void OnDropSocks(InputAction.CallbackContext context);
    }
}
