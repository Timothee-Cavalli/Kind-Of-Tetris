// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/GamePlay.inputactions'

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
            ""name"": ""GamePlayControls"",
            ""id"": ""60a103e7-f14a-4547-aa90-4b97f1de5995"",
            ""actions"": [
                {
                    ""name"": ""East"",
                    ""type"": ""Button"",
                    ""id"": ""a0774f49-5105-41ce-a9a3-af4f3d4006b7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""West"",
                    ""type"": ""Button"",
                    ""id"": ""12c932e1-5fb1-4a80-9932-abab389117cd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""North"",
                    ""type"": ""Button"",
                    ""id"": ""2da5595b-21dd-4377-9c3b-fe38c213f643"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""South"",
                    ""type"": ""Button"",
                    ""id"": ""00c121d5-b67f-4d98-a45f-206fed8e94bf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""230bbdfd-2810-4b84-8275-68ce04e58bf6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""4c254308-ba90-4264-a780-54ca293a2b76"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Place"",
                    ""type"": ""Button"",
                    ""id"": ""e97f950f-8d70-44e6-9c60-7abe48cb2b54"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ChangePiece"",
                    ""type"": ""Button"",
                    ""id"": ""1b75cb88-e8fd-41ac-871c-23b6fc7c9988"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""NextPiece"",
                    ""type"": ""Button"",
                    ""id"": ""d5f4b922-3e52-4a91-a591-42b89db6de55"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PrevPiece"",
                    ""type"": ""Button"",
                    ""id"": ""6850bc7d-539e-45b8-ae52-8203c74b22b9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SwitchStatus"",
                    ""type"": ""Button"",
                    ""id"": ""8b43faff-f9b7-4bbe-a821-3f8561332bc3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a7793e38-de19-4e83-b6be-c68c834a375c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b36b9ab-4151-45f5-81ed-ca8849e5c100"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2793e881-51d4-4a38-bf10-903570965b00"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16718297-ede3-4e98-849e-d01873a88fce"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""298ef901-96ae-4b54-92f6-bb5a9d6c7898"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5dc9d5a6-82c7-4128-b4ea-dd973def0f69"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fec470f-c7b1-4c8b-b1cc-2d3fff4d52b8"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""541e2440-6627-490a-ae01-ec34a0f00d6d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb2d4e66-dbca-4dc8-a94a-9ca1f886de6a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d409ae1d-4300-45b4-bbde-da21c449f75a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bba514f-4510-4479-99e2-f0dbd233710f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66b54df0-6bc2-4b88-bf29-0d3282486744"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6cbfc04-89f2-4e9a-bbf4-0d79556264d5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Place"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cea40ba-fcc1-45b4-a091-c6be9b016a08"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Place"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c9c1b29-d38e-4dc3-aac3-26f0a6d42b90"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ChangePiece"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de1c35f0-b38c-4d30-99d6-4e0c0b9fc963"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""NextPiece"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da24602a-e230-444d-9b11-047930bb9548"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""PrevPiece"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a85ea53b-cf68-4623-9961-baef2274e1f6"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""SwitchStatus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3b915eb-26da-4e07-8a9f-3703290d4801"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""SwitchStatus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
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
        // GamePlayControls
        m_GamePlayControls = asset.FindActionMap("GamePlayControls", throwIfNotFound: true);
        m_GamePlayControls_East = m_GamePlayControls.FindAction("East", throwIfNotFound: true);
        m_GamePlayControls_West = m_GamePlayControls.FindAction("West", throwIfNotFound: true);
        m_GamePlayControls_North = m_GamePlayControls.FindAction("North", throwIfNotFound: true);
        m_GamePlayControls_South = m_GamePlayControls.FindAction("South", throwIfNotFound: true);
        m_GamePlayControls_Up = m_GamePlayControls.FindAction("Up", throwIfNotFound: true);
        m_GamePlayControls_Down = m_GamePlayControls.FindAction("Down", throwIfNotFound: true);
        m_GamePlayControls_Place = m_GamePlayControls.FindAction("Place", throwIfNotFound: true);
        m_GamePlayControls_ChangePiece = m_GamePlayControls.FindAction("ChangePiece", throwIfNotFound: true);
        m_GamePlayControls_NextPiece = m_GamePlayControls.FindAction("NextPiece", throwIfNotFound: true);
        m_GamePlayControls_PrevPiece = m_GamePlayControls.FindAction("PrevPiece", throwIfNotFound: true);
        m_GamePlayControls_SwitchStatus = m_GamePlayControls.FindAction("SwitchStatus", throwIfNotFound: true);
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

    // GamePlayControls
    private readonly InputActionMap m_GamePlayControls;
    private IGamePlayControlsActions m_GamePlayControlsActionsCallbackInterface;
    private readonly InputAction m_GamePlayControls_East;
    private readonly InputAction m_GamePlayControls_West;
    private readonly InputAction m_GamePlayControls_North;
    private readonly InputAction m_GamePlayControls_South;
    private readonly InputAction m_GamePlayControls_Up;
    private readonly InputAction m_GamePlayControls_Down;
    private readonly InputAction m_GamePlayControls_Place;
    private readonly InputAction m_GamePlayControls_ChangePiece;
    private readonly InputAction m_GamePlayControls_NextPiece;
    private readonly InputAction m_GamePlayControls_PrevPiece;
    private readonly InputAction m_GamePlayControls_SwitchStatus;
    public struct GamePlayControlsActions
    {
        private @GamePlay m_Wrapper;
        public GamePlayControlsActions(@GamePlay wrapper) { m_Wrapper = wrapper; }
        public InputAction @East => m_Wrapper.m_GamePlayControls_East;
        public InputAction @West => m_Wrapper.m_GamePlayControls_West;
        public InputAction @North => m_Wrapper.m_GamePlayControls_North;
        public InputAction @South => m_Wrapper.m_GamePlayControls_South;
        public InputAction @Up => m_Wrapper.m_GamePlayControls_Up;
        public InputAction @Down => m_Wrapper.m_GamePlayControls_Down;
        public InputAction @Place => m_Wrapper.m_GamePlayControls_Place;
        public InputAction @ChangePiece => m_Wrapper.m_GamePlayControls_ChangePiece;
        public InputAction @NextPiece => m_Wrapper.m_GamePlayControls_NextPiece;
        public InputAction @PrevPiece => m_Wrapper.m_GamePlayControls_PrevPiece;
        public InputAction @SwitchStatus => m_Wrapper.m_GamePlayControls_SwitchStatus;
        public InputActionMap Get() { return m_Wrapper.m_GamePlayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayControlsActions instance)
        {
            if (m_Wrapper.m_GamePlayControlsActionsCallbackInterface != null)
            {
                @East.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnEast;
                @East.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnEast;
                @East.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnEast;
                @West.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnWest;
                @West.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnWest;
                @West.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnWest;
                @North.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnNorth;
                @North.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnNorth;
                @North.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnNorth;
                @South.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnSouth;
                @South.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnSouth;
                @South.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnSouth;
                @Up.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnDown;
                @Place.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnPlace;
                @Place.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnPlace;
                @Place.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnPlace;
                @ChangePiece.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnChangePiece;
                @ChangePiece.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnChangePiece;
                @ChangePiece.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnChangePiece;
                @NextPiece.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnNextPiece;
                @NextPiece.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnNextPiece;
                @NextPiece.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnNextPiece;
                @PrevPiece.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnPrevPiece;
                @PrevPiece.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnPrevPiece;
                @PrevPiece.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnPrevPiece;
                @SwitchStatus.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnSwitchStatus;
                @SwitchStatus.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnSwitchStatus;
                @SwitchStatus.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnSwitchStatus;
            }
            m_Wrapper.m_GamePlayControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @East.started += instance.OnEast;
                @East.performed += instance.OnEast;
                @East.canceled += instance.OnEast;
                @West.started += instance.OnWest;
                @West.performed += instance.OnWest;
                @West.canceled += instance.OnWest;
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
                @South.started += instance.OnSouth;
                @South.performed += instance.OnSouth;
                @South.canceled += instance.OnSouth;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Place.started += instance.OnPlace;
                @Place.performed += instance.OnPlace;
                @Place.canceled += instance.OnPlace;
                @ChangePiece.started += instance.OnChangePiece;
                @ChangePiece.performed += instance.OnChangePiece;
                @ChangePiece.canceled += instance.OnChangePiece;
                @NextPiece.started += instance.OnNextPiece;
                @NextPiece.performed += instance.OnNextPiece;
                @NextPiece.canceled += instance.OnNextPiece;
                @PrevPiece.started += instance.OnPrevPiece;
                @PrevPiece.performed += instance.OnPrevPiece;
                @PrevPiece.canceled += instance.OnPrevPiece;
                @SwitchStatus.started += instance.OnSwitchStatus;
                @SwitchStatus.performed += instance.OnSwitchStatus;
                @SwitchStatus.canceled += instance.OnSwitchStatus;
            }
        }
    }
    public GamePlayControlsActions @GamePlayControls => new GamePlayControlsActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IGamePlayControlsActions
    {
        void OnEast(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
        void OnNorth(InputAction.CallbackContext context);
        void OnSouth(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnPlace(InputAction.CallbackContext context);
        void OnChangePiece(InputAction.CallbackContext context);
        void OnNextPiece(InputAction.CallbackContext context);
        void OnPrevPiece(InputAction.CallbackContext context);
        void OnSwitchStatus(InputAction.CallbackContext context);
    }
}
