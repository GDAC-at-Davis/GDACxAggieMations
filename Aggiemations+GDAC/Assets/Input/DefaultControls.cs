//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/DefaultControls.inputactions
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

public partial class @DefaultControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""2304a758-2e1c-42b6-bb95-a3cf5bbbde70"",
            ""actions"": [
                {
                    ""name"": ""Movement_P1"",
                    ""type"": ""Value"",
                    ""id"": ""01e0379f-6d2b-4700-a255-df76600f03a6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Movement_P2"",
                    ""type"": ""Value"",
                    ""id"": ""3b71b26b-f573-43dd-9511-71ae58f7f6ab"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump_P1"",
                    ""type"": ""Button"",
                    ""id"": ""d88d6771-4cb0-4787-bba0-7cc91e97bcba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump_P2"",
                    ""type"": ""Button"",
                    ""id"": ""3ccdd629-e810-4c1a-90c4-ef47f4f9a645"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4557edaf-7159-4b53-8ce1-0aa234e855d4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""bfa971b2-4e86-45fd-873d-a3a10d7cee98"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""d25f9294-6e6f-4713-b9d0-0ec12456960f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""8af42b69-be32-469b-9d8a-fe7f6a82c7f4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""fecf59f5-d770-4f78-ab95-5582f2440742"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""42cdbc05-ff28-433c-8d6d-4fb4832f3c8a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump_P1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0744fbb2-aa35-40e4-bc5e-aad477004a32"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""d74aea3b-34fd-46ad-9d8d-1a08286fc423"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""4d4106b1-17bc-4f68-91e7-879f1dc2cc5e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""b9a5fe6a-55f3-4227-9342-29873323fdc2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""66eac183-4940-4638-bdd7-0f8cb35e45cf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement_P2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1e0148d9-e419-49ac-8c2a-a581d3723e0e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump_P2"",
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
        m_Gameplay_Movement_P1 = m_Gameplay.FindAction("Movement_P1", throwIfNotFound: true);
        m_Gameplay_Movement_P2 = m_Gameplay.FindAction("Movement_P2", throwIfNotFound: true);
        m_Gameplay_Jump_P1 = m_Gameplay.FindAction("Jump_P1", throwIfNotFound: true);
        m_Gameplay_Jump_P2 = m_Gameplay.FindAction("Jump_P2", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Movement_P1;
    private readonly InputAction m_Gameplay_Movement_P2;
    private readonly InputAction m_Gameplay_Jump_P1;
    private readonly InputAction m_Gameplay_Jump_P2;
    public struct GameplayActions
    {
        private @DefaultControls m_Wrapper;
        public GameplayActions(@DefaultControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement_P1 => m_Wrapper.m_Gameplay_Movement_P1;
        public InputAction @Movement_P2 => m_Wrapper.m_Gameplay_Movement_P2;
        public InputAction @Jump_P1 => m_Wrapper.m_Gameplay_Jump_P1;
        public InputAction @Jump_P2 => m_Wrapper.m_Gameplay_Jump_P2;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Movement_P1.started += instance.OnMovement_P1;
            @Movement_P1.performed += instance.OnMovement_P1;
            @Movement_P1.canceled += instance.OnMovement_P1;
            @Movement_P2.started += instance.OnMovement_P2;
            @Movement_P2.performed += instance.OnMovement_P2;
            @Movement_P2.canceled += instance.OnMovement_P2;
            @Jump_P1.started += instance.OnJump_P1;
            @Jump_P1.performed += instance.OnJump_P1;
            @Jump_P1.canceled += instance.OnJump_P1;
            @Jump_P2.started += instance.OnJump_P2;
            @Jump_P2.performed += instance.OnJump_P2;
            @Jump_P2.canceled += instance.OnJump_P2;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Movement_P1.started -= instance.OnMovement_P1;
            @Movement_P1.performed -= instance.OnMovement_P1;
            @Movement_P1.canceled -= instance.OnMovement_P1;
            @Movement_P2.started -= instance.OnMovement_P2;
            @Movement_P2.performed -= instance.OnMovement_P2;
            @Movement_P2.canceled -= instance.OnMovement_P2;
            @Jump_P1.started -= instance.OnJump_P1;
            @Jump_P1.performed -= instance.OnJump_P1;
            @Jump_P1.canceled -= instance.OnJump_P1;
            @Jump_P2.started -= instance.OnJump_P2;
            @Jump_P2.performed -= instance.OnJump_P2;
            @Jump_P2.canceled -= instance.OnJump_P2;
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
        void OnMovement_P1(InputAction.CallbackContext context);
        void OnMovement_P2(InputAction.CallbackContext context);
        void OnJump_P1(InputAction.CallbackContext context);
        void OnJump_P2(InputAction.CallbackContext context);
    }
}
