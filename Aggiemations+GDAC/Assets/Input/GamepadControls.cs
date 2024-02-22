//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/GamepadControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GamepadControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GamepadControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GamepadControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""2304a758-2e1c-42b6-bb95-a3cf5bbbde70"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""01e0379f-6d2b-4700-a255-df76600f03a6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d88d6771-4cb0-4787-bba0-7cc91e97bcba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Basic"",
                    ""type"": ""Button"",
                    ""id"": ""202f30c4-cbb0-4d48-b071-faac12c7f692"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Heavy"",
                    ""type"": ""Button"",
                    ""id"": ""04831cff-c1bd-4a2b-b8d5-6fca3686f62f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash_Left"",
                    ""type"": ""Button"",
                    ""id"": ""01780217-5bf7-4357-bf1c-c8330cd9d644"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Dash_Right"",
                    ""type"": ""Button"",
                    ""id"": ""433f977b-4782-4c7b-a08f-e77cbed4d1f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Taunt"",
                    ""type"": ""Button"",
                    ""id"": ""03362fc4-9494-45ca-8e56-528f2d00658f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""42cdbc05-ff28-433c-8d6d-4fb4832f3c8a"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33e7fc5b-fef9-4f8d-ad72-28bb0dc6ae1e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7be5bac1-304b-4e06-8ded-48c0a7d7c4e5"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Basic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7331478a-d09c-487f-b12d-6c8c665cf4ea"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Heavy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5be7f844-bf8e-4c5c-8202-58656b3d8337"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef645fe4-8d2a-40d2-94c3-2082be092330"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dda585d0-6656-4404-814d-7cb0c63b1db1"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Taunt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""358894c0-326e-479b-9110-2e72b17c8cb8"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46bd1ac0-85d2-43b4-a249-a487bc91b7d9"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""381b37ce-3557-4aff-b15e-5d3caea69d54"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05244636-cd68-40d5-956f-e1f7d8b39fc4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f5448db-aa39-459e-a0c4-f1754c6d9b85"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Basic = m_Gameplay.FindAction("Basic", throwIfNotFound: true);
        m_Gameplay_Heavy = m_Gameplay.FindAction("Heavy", throwIfNotFound: true);
        m_Gameplay_Dash_Left = m_Gameplay.FindAction("Dash_Left", throwIfNotFound: true);
        m_Gameplay_Dash_Right = m_Gameplay.FindAction("Dash_Right", throwIfNotFound: true);
        m_Gameplay_Taunt = m_Gameplay.FindAction("Taunt", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Movement;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Basic;
    private readonly InputAction m_Gameplay_Heavy;
    private readonly InputAction m_Gameplay_Dash_Left;
    private readonly InputAction m_Gameplay_Dash_Right;
    private readonly InputAction m_Gameplay_Taunt;
    public struct GameplayActions
    {
        private @GamepadControls m_Wrapper;
        public GameplayActions(@GamepadControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Basic => m_Wrapper.m_Gameplay_Basic;
        public InputAction @Heavy => m_Wrapper.m_Gameplay_Heavy;
        public InputAction @Dash_Left => m_Wrapper.m_Gameplay_Dash_Left;
        public InputAction @Dash_Right => m_Wrapper.m_Gameplay_Dash_Right;
        public InputAction @Taunt => m_Wrapper.m_Gameplay_Taunt;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Basic.started += instance.OnBasic;
            @Basic.performed += instance.OnBasic;
            @Basic.canceled += instance.OnBasic;
            @Heavy.started += instance.OnHeavy;
            @Heavy.performed += instance.OnHeavy;
            @Heavy.canceled += instance.OnHeavy;
            @Dash_Left.started += instance.OnDash_Left;
            @Dash_Left.performed += instance.OnDash_Left;
            @Dash_Left.canceled += instance.OnDash_Left;
            @Dash_Right.started += instance.OnDash_Right;
            @Dash_Right.performed += instance.OnDash_Right;
            @Dash_Right.canceled += instance.OnDash_Right;
            @Taunt.started += instance.OnTaunt;
            @Taunt.performed += instance.OnTaunt;
            @Taunt.canceled += instance.OnTaunt;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Basic.started -= instance.OnBasic;
            @Basic.performed -= instance.OnBasic;
            @Basic.canceled -= instance.OnBasic;
            @Heavy.started -= instance.OnHeavy;
            @Heavy.performed -= instance.OnHeavy;
            @Heavy.canceled -= instance.OnHeavy;
            @Dash_Left.started -= instance.OnDash_Left;
            @Dash_Left.performed -= instance.OnDash_Left;
            @Dash_Left.canceled -= instance.OnDash_Left;
            @Dash_Right.started -= instance.OnDash_Right;
            @Dash_Right.performed -= instance.OnDash_Right;
            @Dash_Right.canceled -= instance.OnDash_Right;
            @Taunt.started -= instance.OnTaunt;
            @Taunt.performed -= instance.OnTaunt;
            @Taunt.canceled -= instance.OnTaunt;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBasic(InputAction.CallbackContext context);
        void OnHeavy(InputAction.CallbackContext context);
        void OnDash_Left(InputAction.CallbackContext context);
        void OnDash_Right(InputAction.CallbackContext context);
        void OnTaunt(InputAction.CallbackContext context);
    }
}
