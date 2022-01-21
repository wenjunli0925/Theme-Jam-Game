// GENERATED AUTOMATICALLY FROM 'Assets/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e0ccb602-52b7-4f8d-b671-93fc088122a6"",
            ""actions"": [
                {
                    ""name"": ""Yes"",
                    ""type"": ""Button"",
                    ""id"": ""6ee07955-2d5c-4ee4-8e43-573470653426"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""No"",
                    ""type"": ""Button"",
                    ""id"": ""6a0968f8-d44b-4e48-b2e6-865fb9ec43ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LastYear"",
                    ""type"": ""Button"",
                    ""id"": ""4d30c02c-7bcd-4023-bcd4-d461375dac23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1)""
                },
                {
                    ""name"": ""NextYear"",
                    ""type"": ""Button"",
                    ""id"": ""a14be649-90c7-48e2-8f32-03eeaaccef19"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1)""
                },
                {
                    ""name"": ""Locate"",
                    ""type"": ""Button"",
                    ""id"": ""653a30c1-afb8-4b65-8868-8afb9b67a48f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""e13c18a3-aa0f-4391-a4e8-2b14805f36f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1)""
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""3a747538-0814-412a-9045-9d2f7e733b9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1)""
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""08534c45-430f-4958-a8f6-74ca54ad1834"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1)""
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""ecc8f591-516a-49d9-8019-770e6246d066"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=1)""
                },
                {
                    ""name"": ""Insturction"",
                    ""type"": ""Button"",
                    ""id"": ""42a2ad98-87ee-45ac-8bfd-a8aae5c766fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26c23bf7-11e6-42ff-8806-04de1baa8104"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df79cbfc-dc03-46bc-b3bd-ff343f1a4b8a"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""163849be-75aa-4e9e-ab17-57e69bf6be5f"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""No"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cfcef47-a4dc-4fd8-9866-dcac281fdf6f"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""No"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""addc2136-e4e3-461f-b4ea-76d88a4efbf7"",
                    ""path"": ""<DualShockGamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LastYear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8942a6e8-10a3-49f9-8172-9c84aafa774b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LastYear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcb0b459-c881-401b-95d5-d620c1123cec"",
                    ""path"": ""<DualShockGamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextYear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cf0c9b7-1d1e-460f-9add-ca6acbb1aca6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextYear"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09c614e4-b880-4631-8ed6-c8ccc1fafdcd"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Locate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cce2d0f-b317-4ed2-9057-014e843d1391"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Locate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19e45842-25d7-4d24-82d0-484ad50f53f4"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec524af8-c49c-4768-9899-dc4fe9d75378"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f346393-293c-4b1a-ba3f-23158573b7b2"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85e21283-ec18-4183-b041-0049ccdd361c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7a2bc18-0b5a-4453-b469-df44bbefef39"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2fea3235-5d0b-4c32-83b8-284808373b8a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa02b7a8-0f1f-41cd-ab27-1f97e90166b0"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54b1e662-24db-41be-a3a9-546f4bbf55ee"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fe68e8b-02a4-428e-b6c1-311e0e54c650"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Insturction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6356919-e0aa-4b2f-9457-c5980f6fa5de"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Insturction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Yes = m_Player.FindAction("Yes", throwIfNotFound: true);
        m_Player_No = m_Player.FindAction("No", throwIfNotFound: true);
        m_Player_LastYear = m_Player.FindAction("LastYear", throwIfNotFound: true);
        m_Player_NextYear = m_Player.FindAction("NextYear", throwIfNotFound: true);
        m_Player_Locate = m_Player.FindAction("Locate", throwIfNotFound: true);
        m_Player_Up = m_Player.FindAction("Up", throwIfNotFound: true);
        m_Player_Down = m_Player.FindAction("Down", throwIfNotFound: true);
        m_Player_Left = m_Player.FindAction("Left", throwIfNotFound: true);
        m_Player_Right = m_Player.FindAction("Right", throwIfNotFound: true);
        m_Player_Insturction = m_Player.FindAction("Insturction", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Yes;
    private readonly InputAction m_Player_No;
    private readonly InputAction m_Player_LastYear;
    private readonly InputAction m_Player_NextYear;
    private readonly InputAction m_Player_Locate;
    private readonly InputAction m_Player_Up;
    private readonly InputAction m_Player_Down;
    private readonly InputAction m_Player_Left;
    private readonly InputAction m_Player_Right;
    private readonly InputAction m_Player_Insturction;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Yes => m_Wrapper.m_Player_Yes;
        public InputAction @No => m_Wrapper.m_Player_No;
        public InputAction @LastYear => m_Wrapper.m_Player_LastYear;
        public InputAction @NextYear => m_Wrapper.m_Player_NextYear;
        public InputAction @Locate => m_Wrapper.m_Player_Locate;
        public InputAction @Up => m_Wrapper.m_Player_Up;
        public InputAction @Down => m_Wrapper.m_Player_Down;
        public InputAction @Left => m_Wrapper.m_Player_Left;
        public InputAction @Right => m_Wrapper.m_Player_Right;
        public InputAction @Insturction => m_Wrapper.m_Player_Insturction;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Yes.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYes;
                @Yes.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYes;
                @Yes.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYes;
                @No.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNo;
                @No.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNo;
                @No.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNo;
                @LastYear.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLastYear;
                @LastYear.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLastYear;
                @LastYear.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLastYear;
                @NextYear.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNextYear;
                @NextYear.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNextYear;
                @NextYear.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNextYear;
                @Locate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLocate;
                @Locate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLocate;
                @Locate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLocate;
                @Up.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight;
                @Insturction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInsturction;
                @Insturction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInsturction;
                @Insturction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInsturction;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Yes.started += instance.OnYes;
                @Yes.performed += instance.OnYes;
                @Yes.canceled += instance.OnYes;
                @No.started += instance.OnNo;
                @No.performed += instance.OnNo;
                @No.canceled += instance.OnNo;
                @LastYear.started += instance.OnLastYear;
                @LastYear.performed += instance.OnLastYear;
                @LastYear.canceled += instance.OnLastYear;
                @NextYear.started += instance.OnNextYear;
                @NextYear.performed += instance.OnNextYear;
                @NextYear.canceled += instance.OnNextYear;
                @Locate.started += instance.OnLocate;
                @Locate.performed += instance.OnLocate;
                @Locate.canceled += instance.OnLocate;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Insturction.started += instance.OnInsturction;
                @Insturction.performed += instance.OnInsturction;
                @Insturction.canceled += instance.OnInsturction;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnYes(InputAction.CallbackContext context);
        void OnNo(InputAction.CallbackContext context);
        void OnLastYear(InputAction.CallbackContext context);
        void OnNextYear(InputAction.CallbackContext context);
        void OnLocate(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnInsturction(InputAction.CallbackContext context);
    }
}
