// GENERATED AUTOMATICALLY FROM 'Assets/InputSettings/Moving On.inputactions'

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
    ""name"": ""Moving On"",
    ""maps"": [
        {
            ""name"": ""PlayerBiped"",
            ""id"": ""0a8a152c-a969-4825-be30-9c23afa64184"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d181fd2e-75c2-4894-9205-d8705d32ea50"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""63b4833f-0d12-4f68-a8c5-78d02a610cd3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""6eb8b4b6-3fa8-4116-862f-38563b24f910"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BombPress"",
                    ""type"": ""Button"",
                    ""id"": ""fbe3c8d4-df8b-4980-b035-052cc1a8ff63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""BombRelease"",
                    ""type"": ""Button"",
                    ""id"": ""14254feb-3ecf-4f45-b775-d9c63e3d6af5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5e4664c2-5bd5-462c-b50f-e787d624adf6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TransformIntoFlight"",
                    ""type"": ""Button"",
                    ""id"": ""0c6f082c-92b6-4d7e-a739-47fd32147274"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TransformIntoBall"",
                    ""type"": ""Button"",
                    ""id"": ""0330c024-3a58-44c5-8ca9-48cb049d0f33"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TransformIntoBiped"",
                    ""type"": ""Button"",
                    ""id"": ""09bd6b69-6708-400e-914b-acb02bb41b5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ResetLevel"",
                    ""type"": ""Button"",
                    ""id"": ""693205be-7482-4eda-944a-a63532362031"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.8)""
                },
                {
                    ""name"": ""ShowControls"",
                    ""type"": ""Button"",
                    ""id"": ""d1a49420-403a-488e-8bac-d8c3e91e3168"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""ExitGame"",
                    ""type"": ""Button"",
                    ""id"": ""d8484227-ed51-451b-a8c1-66cffab69a29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=2)""
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""95948a73-8bc9-401f-8552-5a981e424bb2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=2)""
                },
                {
                    ""name"": ""InvertYCam"",
                    ""type"": ""Button"",
                    ""id"": ""16108e65-fad1-43e5-9c08-eecdd0151268"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoreSensibility"",
                    ""type"": ""Button"",
                    ""id"": ""bb2a2fe9-6cbc-40f5-bffc-8115bb74c162"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LessSensibility"",
                    ""type"": ""Button"",
                    ""id"": ""7b81311a-2b3a-4915-b6cb-5a70b3f4bc28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InvertYFlight"",
                    ""type"": ""Button"",
                    ""id"": ""1cdae496-5eeb-452c-920b-1d968e06d809"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8180e8bd-4097-4f4e-ab88-4523101a6ce9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c5327b5-f71c-4f60-99c7-4e737386f1d1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2e46982e-44cc-431b-9f0b-c11910bf467a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""77bff152-3580-4b21-b6de-dcd0c7e41164"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1635d3fe-58b6-4ba9-a4e2-f4b964f6b5c8"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ea4d645-4504-4529-b061-ab81934c3752"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1f7a91b-d0fd-4a62-997e-7fb9b69bf235"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c8e490b-c610-4785-884f-f04217b23ca4"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse;Touch"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e5f5442-8668-4b27-a940-df99bad7e831"",
                    ""path"": ""<Joystick>/{Hatswitch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""143bb1cd-cc10-4eca-a2f0-a3664166fe91"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05f6913d-c316-48b2-a6bb-e225f14c7960"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""886e731e-7071-4ae4-95c0-e61739dad6fd"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee3d0cd2-254e-47a7-a8cb-bc94d9658c54"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8255d333-5683-4943-a58a-ccb207ff1dce"",
                    ""path"": ""<XRController>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f83a077-35b4-4965-9321-946f6ed6f0c1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55d22428-be99-41b8-ba64-e03e6db8ae6d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""c80e1fbb-396c-4129-80fd-59abe3dc116d"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransformIntoFlight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""673ba5bc-29bc-4c12-84e2-826398d83c66"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoFlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""88df1332-70d1-4ba7-95cf-4950c77319bf"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoFlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dae44423-f9cf-461c-a07e-2f8a9cdb4ef6"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TransformIntoFlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""18256169-e6f5-4ed3-92a5-b734a0ca6a88"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransformIntoBall"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""fcaf4a33-a02c-4d11-a521-def5125cfc4a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""dd88a689-553d-48b9-a17c-21ec058620b8"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7a665f02-2858-4e93-9d6c-0e8d70c2f12b"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TransformIntoBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""597ddf36-b1bd-45b9-be50-d71a3ae6274c"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""8a0ace4b-faef-4d37-9458-2367076fffbd"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""81e37953-83b2-4e60-ba9c-ad387eb4f545"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b3b2c372-2e34-468c-be17-90400e2751ac"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f3cfd2a-a0c4-465e-94da-4431b5962e47"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""BombPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c59dfdb1-542e-4fa9-9628-299429db0f5f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""BombPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e993cd87-5747-45d4-baee-a886389d9162"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""BombPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f0f3403-63dd-41d0-98c6-1acd1287ac98"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""BombPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd0e779a-561c-4dd0-8f3d-803b176d8091"",
                    ""path"": ""<XRController>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""BombPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f176dc2e-93fb-40bb-acf9-23bb569c511e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""BombRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9a206da-8d47-40b1-8142-5e59267f87c5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""BombRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74416512-9be7-496b-a7c3-4760a08633d7"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""BombRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3259bba2-7edc-41a1-a322-a174ab06494f"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""BombRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c4f8d90-5988-432f-82fe-0f59167f0a83"",
                    ""path"": ""<XRController>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""BombRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60df6879-073c-4375-9af5-b62b4e07b5ad"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ResetLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b281a5f1-96d8-4b1d-82d8-e853b1569ba2"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""ResetLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc58cab9-e933-4308-9a21-929f0fcff821"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShowControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af149ffd-fb21-468d-ba49-1cfa36a993d5"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""ShowControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""112f3411-0522-401e-9971-f721bb24eef3"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ExitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d1fc3aa-7aab-4d67-a104-038d3a8db517"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""ExitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c0a3f3c-94bc-4875-951d-84b8c75665a8"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8127e777-1f39-49ce-8364-81a6ed78b73a"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c5ba23f-ec34-415a-b42c-a0b4368ffbed"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""InvertYCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76ae2d97-c1ba-468d-bc69-db7e56f84aa0"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""InvertYCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41d4f8dc-5335-4634-a958-ddff31f83da4"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoreSensibility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""630547bf-2005-49ce-89b2-77a94a2aafc6"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoreSensibility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""941bdb42-ed9a-4c88-80c0-26c320a8e5e4"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""LessSensibility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbb6d883-2221-4f33-be03-47baa53176c2"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""LessSensibility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""753e9ccc-610e-4ca1-ae59-e96ec0f4c0fc"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""InvertYFlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d720122e-4c3c-463b-94f0-b0c994e05c88"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""InvertYFlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerFlight"",
            ""id"": ""781ecee1-9a5c-4c3d-8415-df5d6fa818d9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""faab4356-76e0-421e-983a-81003db1ba5b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""780d38a8-2213-44b1-a513-449c8e56d4eb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""44838edb-af97-4bff-85ee-f23c7a702cc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a51a3acd-c824-47b6-bf2f-14c7ccc92ae6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TransformIntoBiped"",
                    ""type"": ""Button"",
                    ""id"": ""0a6afd8f-17c5-4e62-b49a-7203f7fe98ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TransformIntoBall"",
                    ""type"": ""Button"",
                    ""id"": ""7b6bfffa-2782-4e18-aae2-7e1ee1e3b11e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b96d2246-bbad-42d0-bb01-8dd37261a1b3"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f30bca7f-c28c-4f73-adf4-5d7756b27f2b"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1ee78b87-1aa8-4ef9-853c-dd2c5c76dec6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""869a9c7a-ae1a-41af-9f96-7f6b8a4d75ed"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5ffbb46e-f6b5-4e60-88f7-6fdb1cf14109"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac31c9a4-c754-4be3-a6e4-24bf0bdb77ae"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4b9e5345-cede-4ccd-b9ae-a6b2f76fd299"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""34a7aa1c-187f-413e-8878-b13ad1576bde"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1de42bd4-fc78-43ce-a910-041f2a631f13"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""db723ad7-b923-4333-be3c-70b4ca8ccf8f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fd9fb481-ecef-4343-b6aa-04f8cdf1bc53"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f03e2ffe-0b89-4b06-90df-1c76d283e266"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a70e8ba8-fc7c-46d6-8960-c0be34b76714"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cefafa80-453a-494e-bd55-57ed3ac745b9"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse;Touch"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a78a05b4-6ca3-429a-b064-dfc0e87aba2b"",
                    ""path"": ""<Joystick>/{Hatswitch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d330a2e4-e8a0-4056-8fb1-5e2fb296dc84"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12c8ffc8-f7d1-41ed-a6c7-dce2ad4270ba"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb371a66-8d0d-402c-8039-a2b581c68f6f"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8470f56-33dc-43d3-a7f0-ac1347248b4c"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcac8251-478d-4133-badf-174b59c2e340"",
                    ""path"": ""<XRController>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49961ca5-a588-465a-8e6a-32e7ddc317e4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0656880b-3fcc-491d-aef7-4bf891300846"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34060441-2a7c-40b8-b25b-7926d38d4bc8"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""315f307c-2ff4-4f28-94f8-4eef20c36017"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f19eefd1-b23c-4e84-8f5e-f5ccc0e31e2d"",
                    ""path"": ""<XRController>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6683185e-8418-406b-b795-6434f9851b1b"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""664b2c3b-3fd3-4be9-be9a-97c185540c7b"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""6a36c311-a89e-4bb6-a560-d98612254bb4"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""2b1f608a-605a-46a1-8bf7-6027c1c898f6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""9b53f523-e660-4dc6-9303-aeb600327957"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransformIntoBall"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""f20a142f-351c-4ea8-9243-c2ae9ddf2e4c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""f4ed3e47-7d94-46b8-bbd6-550159d160d0"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0bf868ff-ed76-4cfa-a576-ab68a06f5fa7"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TransformIntoBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerBall"",
            ""id"": ""695e044a-553a-4712-b9aa-99079f6214ac"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ad0e17fb-31cc-4052-aa10-29e0c241a736"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""800ff2af-6ad9-42d1-ac2f-b2101df4c3e6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""e482c62f-8c4e-47c9-9e06-250c95b678e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""1dfaddf3-8dde-4fea-929b-712b7b79914a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TransformIntoFlight"",
                    ""type"": ""Button"",
                    ""id"": ""d491ae66-56df-4735-b52a-a31b46a25808"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TransformIntoBiped"",
                    ""type"": ""Button"",
                    ""id"": ""f314b353-9a66-478e-ac57-20d92ebe67bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""66f51464-bd33-4baf-9c88-c1f7a65499b4"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""76204c27-419c-43a8-aea2-75ad86de33fe"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""31c6f7f1-b4d6-48b8-9ff0-3db67ef2e6f7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4ffc411b-3110-44ba-a4f1-933370091a6f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6ad07966-b69a-4c18-a96c-6e636b99a23e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""584108e8-e650-4f0d-bb0b-8d3b604406cb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9e161bc2-2b88-4625-a4ca-a3cddb50df83"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e035bf86-5016-4c00-85fc-f9352c720d6f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f8ad2954-9442-4e74-b9d9-a16da2c62ea1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d2bab429-7391-46f8-81f4-29382ea9bbe0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""382735ee-632d-44d0-99dc-2fb11d66f5fa"",
                    ""path"": ""<XRController>/{Primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29ba33d3-c527-406d-ab8e-d9e7d5b0e619"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5662c74-6408-45d2-be33-5aeec13ae0fa"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d29cb5c-8a83-47b7-9579-32e9c883b625"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse;Touch"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b004beb-8d19-4932-b05e-f22d6db5ee2a"",
                    ""path"": ""<Joystick>/{Hatswitch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cdf67c3-7edb-47ee-837a-b00e43a7c78b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b456d01-af33-48e1-87f2-74c581e29eac"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e28eb860-34dd-4693-b53a-2011fb04b0e8"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""834d8439-7684-4e38-aeed-9b271eaf9ed1"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0490b8ca-4618-463d-abfb-210257bdb7cc"",
                    ""path"": ""<XRController>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb3918b8-53bd-4c1f-a345-cdbb9b3bfd23"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6983da09-7ab8-49e0-bd58-23c3394754d2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a0eee9b-c674-4191-80e5-82052a47796f"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Touch"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de90872a-df39-4193-be4f-8e6045b2aa0f"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e027d036-2c0e-43a3-a1d2-b3e9894238fc"",
                    ""path"": ""<XRController>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""4e36f71d-d5db-4d23-ab56-ab4819737c3f"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransformIntoFlight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""fe709fb2-ddbd-458d-a0f8-fdc812106967"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoFlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""4dac81b3-1cdb-4b93-9da5-464c6e84a72c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoFlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d5b9f7b9-8a23-4e81-b84a-74f4a9d5ff13"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TransformIntoFlight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""893ecf4a-4ff7-43c9-91c0-6c6c46147277"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""4442e6a6-9472-4958-b78e-af44ea3196a2"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""e70bed81-2816-4436-b6ed-0c4a1f1bfc05"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f816de7f-3603-47f5-86dd-d84ff88e73f4"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""TransformIntoBiped"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""370ed8c0-bec3-4536-8362-335a7696fa9d"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""0b78872c-41e7-4bcb-a6bc-930f0714fcc2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""d2d75579-8de1-4c0f-be0c-5844f3f80445"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""a8280358-82de-441d-a8c3-63470319acf2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e9954050-e8b6-4c16-af2e-1b4a82e6622d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""783c6e69-a07d-4420-ba9a-7edf3cfa8eef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""60a340ad-c9b1-4d80-802d-eb3a754e4245"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""efa95ab0-0e7c-46d2-be42-7c72928c1198"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5955d650-1447-43e2-ba54-57316b2ab652"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""611975b9-f93e-48a6-9489-c7b169415fe8"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""13f5955d-800d-4782-bd39-cceced973f6c"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""809f371f-c5e2-4e7a-83a1-d867598f40dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""14a5d6e8-4aaf-4119-a9ef-34b8c2c548bf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9144cbe6-05e1-4687-a6d7-24f99d23dd81"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2db08d65-c5fb-421b-983f-c71163608d67"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""58748904-2ea9-4a80-8579-b500e6a76df8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8ba04515-75aa-45de-966d-393d9bbd1c14"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""712e721c-bdfb-4b23-a86c-a0d9fcfea921"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcd248ae-a788-4676-a12e-f4d81205600b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f04d9bc-c50b-41a1-bfcc-afb75475ec20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb8277d4-c5cd-4663-9dc7-ee3f0b506d90"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""e25d9774-381c-4a61-b47c-7b6b299ad9f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3db53b26-6601-41be-9887-63ac74e79d19"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cb3e13e-3d90-4178-8ae6-d9c5501d653f"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0392d399-f6dd-4c82-8062-c1e9c0d34835"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""942a66d9-d42f-43d6-8d70-ecb4ba5363bc"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff527021-f211-4c02-933e-5976594c46ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""563fbfdd-0f09-408d-aa75-8642c4f08ef0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb480147-c587-4a33-85ed-eb0ab9942c43"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2bf42165-60bc-42ca-8072-8c13ab40239b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""85d264ad-e0a0-4565-b7ff-1a37edde51ac"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74214943-c580-44e4-98eb-ad7eebe17902"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cea9b045-a000-445b-95b8-0c171af70a3b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8607c725-d935-4808-84b1-8354e29bab63"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4cda81dc-9edd-4e03-9d7c-a71a14345d0b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e92bb26-7e3b-4ec4-b06b-3c8f8e498ddc"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82627dcc-3b13-4ba9-841d-e4b746d6553e"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52c8e0b-8179-41d3-b8a1-d149033bbe86"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1394cbc-336e-44ce-9ea8-6007ed6193f7"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5693e57a-238a-46ed-b5ae-e64e6e574302"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4faf7dc9-b979-4210-aa8c-e808e1ef89f5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d66d5ba-88d7-48e6-b1cd-198bbfef7ace"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47c2a644-3ebc-4dae-a106-589b7ca75b59"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb9e6b34-44bf-4381-ac63-5aa15d19f677"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38c99815-14ea-4617-8627-164d27641299"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24066f69-da47-44f3-a07e-0015fb02eb2e"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c191405-5738-4d4b-a523-c6a301dbf754"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7236c0d9-6ca3-47cf-a6ee-a97f5b59ea77"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23e01e3a-f935-4948-8d8b-9bcac77714fb"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerBiped
        m_PlayerBiped = asset.FindActionMap("PlayerBiped", throwIfNotFound: true);
        m_PlayerBiped_Move = m_PlayerBiped.FindAction("Move", throwIfNotFound: true);
        m_PlayerBiped_Look = m_PlayerBiped.FindAction("Look", throwIfNotFound: true);
        m_PlayerBiped_Fire = m_PlayerBiped.FindAction("Fire", throwIfNotFound: true);
        m_PlayerBiped_BombPress = m_PlayerBiped.FindAction("BombPress", throwIfNotFound: true);
        m_PlayerBiped_BombRelease = m_PlayerBiped.FindAction("BombRelease", throwIfNotFound: true);
        m_PlayerBiped_Jump = m_PlayerBiped.FindAction("Jump", throwIfNotFound: true);
        m_PlayerBiped_TransformIntoFlight = m_PlayerBiped.FindAction("TransformIntoFlight", throwIfNotFound: true);
        m_PlayerBiped_TransformIntoBall = m_PlayerBiped.FindAction("TransformIntoBall", throwIfNotFound: true);
        m_PlayerBiped_TransformIntoBiped = m_PlayerBiped.FindAction("TransformIntoBiped", throwIfNotFound: true);
        m_PlayerBiped_ResetLevel = m_PlayerBiped.FindAction("ResetLevel", throwIfNotFound: true);
        m_PlayerBiped_ShowControls = m_PlayerBiped.FindAction("ShowControls", throwIfNotFound: true);
        m_PlayerBiped_ExitGame = m_PlayerBiped.FindAction("ExitGame", throwIfNotFound: true);
        m_PlayerBiped_Interact = m_PlayerBiped.FindAction("Interact", throwIfNotFound: true);
        m_PlayerBiped_InvertYCam = m_PlayerBiped.FindAction("InvertYCam", throwIfNotFound: true);
        m_PlayerBiped_MoreSensibility = m_PlayerBiped.FindAction("MoreSensibility", throwIfNotFound: true);
        m_PlayerBiped_LessSensibility = m_PlayerBiped.FindAction("LessSensibility", throwIfNotFound: true);
        m_PlayerBiped_InvertYFlight = m_PlayerBiped.FindAction("InvertYFlight", throwIfNotFound: true);
        // PlayerFlight
        m_PlayerFlight = asset.FindActionMap("PlayerFlight", throwIfNotFound: true);
        m_PlayerFlight_Move = m_PlayerFlight.FindAction("Move", throwIfNotFound: true);
        m_PlayerFlight_Look = m_PlayerFlight.FindAction("Look", throwIfNotFound: true);
        m_PlayerFlight_Fire = m_PlayerFlight.FindAction("Fire", throwIfNotFound: true);
        m_PlayerFlight_Jump = m_PlayerFlight.FindAction("Jump", throwIfNotFound: true);
        m_PlayerFlight_TransformIntoBiped = m_PlayerFlight.FindAction("TransformIntoBiped", throwIfNotFound: true);
        m_PlayerFlight_TransformIntoBall = m_PlayerFlight.FindAction("TransformIntoBall", throwIfNotFound: true);
        // PlayerBall
        m_PlayerBall = asset.FindActionMap("PlayerBall", throwIfNotFound: true);
        m_PlayerBall_Move = m_PlayerBall.FindAction("Move", throwIfNotFound: true);
        m_PlayerBall_Look = m_PlayerBall.FindAction("Look", throwIfNotFound: true);
        m_PlayerBall_Fire = m_PlayerBall.FindAction("Fire", throwIfNotFound: true);
        m_PlayerBall_Jump = m_PlayerBall.FindAction("Jump", throwIfNotFound: true);
        m_PlayerBall_TransformIntoFlight = m_PlayerBall.FindAction("TransformIntoFlight", throwIfNotFound: true);
        m_PlayerBall_TransformIntoBiped = m_PlayerBall.FindAction("TransformIntoBiped", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
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

    // PlayerBiped
    private readonly InputActionMap m_PlayerBiped;
    private IPlayerBipedActions m_PlayerBipedActionsCallbackInterface;
    private readonly InputAction m_PlayerBiped_Move;
    private readonly InputAction m_PlayerBiped_Look;
    private readonly InputAction m_PlayerBiped_Fire;
    private readonly InputAction m_PlayerBiped_BombPress;
    private readonly InputAction m_PlayerBiped_BombRelease;
    private readonly InputAction m_PlayerBiped_Jump;
    private readonly InputAction m_PlayerBiped_TransformIntoFlight;
    private readonly InputAction m_PlayerBiped_TransformIntoBall;
    private readonly InputAction m_PlayerBiped_TransformIntoBiped;
    private readonly InputAction m_PlayerBiped_ResetLevel;
    private readonly InputAction m_PlayerBiped_ShowControls;
    private readonly InputAction m_PlayerBiped_ExitGame;
    private readonly InputAction m_PlayerBiped_Interact;
    private readonly InputAction m_PlayerBiped_InvertYCam;
    private readonly InputAction m_PlayerBiped_MoreSensibility;
    private readonly InputAction m_PlayerBiped_LessSensibility;
    private readonly InputAction m_PlayerBiped_InvertYFlight;
    public struct PlayerBipedActions
    {
        private @InputActions m_Wrapper;
        public PlayerBipedActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerBiped_Move;
        public InputAction @Look => m_Wrapper.m_PlayerBiped_Look;
        public InputAction @Fire => m_Wrapper.m_PlayerBiped_Fire;
        public InputAction @BombPress => m_Wrapper.m_PlayerBiped_BombPress;
        public InputAction @BombRelease => m_Wrapper.m_PlayerBiped_BombRelease;
        public InputAction @Jump => m_Wrapper.m_PlayerBiped_Jump;
        public InputAction @TransformIntoFlight => m_Wrapper.m_PlayerBiped_TransformIntoFlight;
        public InputAction @TransformIntoBall => m_Wrapper.m_PlayerBiped_TransformIntoBall;
        public InputAction @TransformIntoBiped => m_Wrapper.m_PlayerBiped_TransformIntoBiped;
        public InputAction @ResetLevel => m_Wrapper.m_PlayerBiped_ResetLevel;
        public InputAction @ShowControls => m_Wrapper.m_PlayerBiped_ShowControls;
        public InputAction @ExitGame => m_Wrapper.m_PlayerBiped_ExitGame;
        public InputAction @Interact => m_Wrapper.m_PlayerBiped_Interact;
        public InputAction @InvertYCam => m_Wrapper.m_PlayerBiped_InvertYCam;
        public InputAction @MoreSensibility => m_Wrapper.m_PlayerBiped_MoreSensibility;
        public InputAction @LessSensibility => m_Wrapper.m_PlayerBiped_LessSensibility;
        public InputAction @InvertYFlight => m_Wrapper.m_PlayerBiped_InvertYFlight;
        public InputActionMap Get() { return m_Wrapper.m_PlayerBiped; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerBipedActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerBipedActions instance)
        {
            if (m_Wrapper.m_PlayerBipedActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnFire;
                @BombPress.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnBombPress;
                @BombPress.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnBombPress;
                @BombPress.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnBombPress;
                @BombRelease.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnBombRelease;
                @BombRelease.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnBombRelease;
                @BombRelease.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnBombRelease;
                @Jump.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnJump;
                @TransformIntoFlight.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnTransformIntoFlight;
                @TransformIntoFlight.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnTransformIntoFlight;
                @TransformIntoFlight.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnTransformIntoFlight;
                @TransformIntoBall.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnTransformIntoBall;
                @TransformIntoBall.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnTransformIntoBall;
                @TransformIntoBall.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnTransformIntoBall;
                @TransformIntoBiped.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnTransformIntoBiped;
                @TransformIntoBiped.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnTransformIntoBiped;
                @TransformIntoBiped.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnTransformIntoBiped;
                @ResetLevel.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnResetLevel;
                @ResetLevel.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnResetLevel;
                @ResetLevel.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnResetLevel;
                @ShowControls.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnShowControls;
                @ShowControls.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnShowControls;
                @ShowControls.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnShowControls;
                @ExitGame.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnExitGame;
                @ExitGame.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnExitGame;
                @ExitGame.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnExitGame;
                @Interact.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnInteract;
                @InvertYCam.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnInvertYCam;
                @InvertYCam.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnInvertYCam;
                @InvertYCam.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnInvertYCam;
                @MoreSensibility.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnMoreSensibility;
                @MoreSensibility.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnMoreSensibility;
                @MoreSensibility.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnMoreSensibility;
                @LessSensibility.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnLessSensibility;
                @LessSensibility.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnLessSensibility;
                @LessSensibility.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnLessSensibility;
                @InvertYFlight.started -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnInvertYFlight;
                @InvertYFlight.performed -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnInvertYFlight;
                @InvertYFlight.canceled -= m_Wrapper.m_PlayerBipedActionsCallbackInterface.OnInvertYFlight;
            }
            m_Wrapper.m_PlayerBipedActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @BombPress.started += instance.OnBombPress;
                @BombPress.performed += instance.OnBombPress;
                @BombPress.canceled += instance.OnBombPress;
                @BombRelease.started += instance.OnBombRelease;
                @BombRelease.performed += instance.OnBombRelease;
                @BombRelease.canceled += instance.OnBombRelease;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @TransformIntoFlight.started += instance.OnTransformIntoFlight;
                @TransformIntoFlight.performed += instance.OnTransformIntoFlight;
                @TransformIntoFlight.canceled += instance.OnTransformIntoFlight;
                @TransformIntoBall.started += instance.OnTransformIntoBall;
                @TransformIntoBall.performed += instance.OnTransformIntoBall;
                @TransformIntoBall.canceled += instance.OnTransformIntoBall;
                @TransformIntoBiped.started += instance.OnTransformIntoBiped;
                @TransformIntoBiped.performed += instance.OnTransformIntoBiped;
                @TransformIntoBiped.canceled += instance.OnTransformIntoBiped;
                @ResetLevel.started += instance.OnResetLevel;
                @ResetLevel.performed += instance.OnResetLevel;
                @ResetLevel.canceled += instance.OnResetLevel;
                @ShowControls.started += instance.OnShowControls;
                @ShowControls.performed += instance.OnShowControls;
                @ShowControls.canceled += instance.OnShowControls;
                @ExitGame.started += instance.OnExitGame;
                @ExitGame.performed += instance.OnExitGame;
                @ExitGame.canceled += instance.OnExitGame;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @InvertYCam.started += instance.OnInvertYCam;
                @InvertYCam.performed += instance.OnInvertYCam;
                @InvertYCam.canceled += instance.OnInvertYCam;
                @MoreSensibility.started += instance.OnMoreSensibility;
                @MoreSensibility.performed += instance.OnMoreSensibility;
                @MoreSensibility.canceled += instance.OnMoreSensibility;
                @LessSensibility.started += instance.OnLessSensibility;
                @LessSensibility.performed += instance.OnLessSensibility;
                @LessSensibility.canceled += instance.OnLessSensibility;
                @InvertYFlight.started += instance.OnInvertYFlight;
                @InvertYFlight.performed += instance.OnInvertYFlight;
                @InvertYFlight.canceled += instance.OnInvertYFlight;
            }
        }
    }
    public PlayerBipedActions @PlayerBiped => new PlayerBipedActions(this);

    // PlayerFlight
    private readonly InputActionMap m_PlayerFlight;
    private IPlayerFlightActions m_PlayerFlightActionsCallbackInterface;
    private readonly InputAction m_PlayerFlight_Move;
    private readonly InputAction m_PlayerFlight_Look;
    private readonly InputAction m_PlayerFlight_Fire;
    private readonly InputAction m_PlayerFlight_Jump;
    private readonly InputAction m_PlayerFlight_TransformIntoBiped;
    private readonly InputAction m_PlayerFlight_TransformIntoBall;
    public struct PlayerFlightActions
    {
        private @InputActions m_Wrapper;
        public PlayerFlightActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerFlight_Move;
        public InputAction @Look => m_Wrapper.m_PlayerFlight_Look;
        public InputAction @Fire => m_Wrapper.m_PlayerFlight_Fire;
        public InputAction @Jump => m_Wrapper.m_PlayerFlight_Jump;
        public InputAction @TransformIntoBiped => m_Wrapper.m_PlayerFlight_TransformIntoBiped;
        public InputAction @TransformIntoBall => m_Wrapper.m_PlayerFlight_TransformIntoBall;
        public InputActionMap Get() { return m_Wrapper.m_PlayerFlight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerFlightActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerFlightActions instance)
        {
            if (m_Wrapper.m_PlayerFlightActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnFire;
                @Jump.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnJump;
                @TransformIntoBiped.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnTransformIntoBiped;
                @TransformIntoBiped.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnTransformIntoBiped;
                @TransformIntoBiped.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnTransformIntoBiped;
                @TransformIntoBall.started -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnTransformIntoBall;
                @TransformIntoBall.performed -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnTransformIntoBall;
                @TransformIntoBall.canceled -= m_Wrapper.m_PlayerFlightActionsCallbackInterface.OnTransformIntoBall;
            }
            m_Wrapper.m_PlayerFlightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @TransformIntoBiped.started += instance.OnTransformIntoBiped;
                @TransformIntoBiped.performed += instance.OnTransformIntoBiped;
                @TransformIntoBiped.canceled += instance.OnTransformIntoBiped;
                @TransformIntoBall.started += instance.OnTransformIntoBall;
                @TransformIntoBall.performed += instance.OnTransformIntoBall;
                @TransformIntoBall.canceled += instance.OnTransformIntoBall;
            }
        }
    }
    public PlayerFlightActions @PlayerFlight => new PlayerFlightActions(this);

    // PlayerBall
    private readonly InputActionMap m_PlayerBall;
    private IPlayerBallActions m_PlayerBallActionsCallbackInterface;
    private readonly InputAction m_PlayerBall_Move;
    private readonly InputAction m_PlayerBall_Look;
    private readonly InputAction m_PlayerBall_Fire;
    private readonly InputAction m_PlayerBall_Jump;
    private readonly InputAction m_PlayerBall_TransformIntoFlight;
    private readonly InputAction m_PlayerBall_TransformIntoBiped;
    public struct PlayerBallActions
    {
        private @InputActions m_Wrapper;
        public PlayerBallActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerBall_Move;
        public InputAction @Look => m_Wrapper.m_PlayerBall_Look;
        public InputAction @Fire => m_Wrapper.m_PlayerBall_Fire;
        public InputAction @Jump => m_Wrapper.m_PlayerBall_Jump;
        public InputAction @TransformIntoFlight => m_Wrapper.m_PlayerBall_TransformIntoFlight;
        public InputAction @TransformIntoBiped => m_Wrapper.m_PlayerBall_TransformIntoBiped;
        public InputActionMap Get() { return m_Wrapper.m_PlayerBall; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerBallActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerBallActions instance)
        {
            if (m_Wrapper.m_PlayerBallActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnLook;
                @Fire.started -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnFire;
                @Jump.started -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnJump;
                @TransformIntoFlight.started -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnTransformIntoFlight;
                @TransformIntoFlight.performed -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnTransformIntoFlight;
                @TransformIntoFlight.canceled -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnTransformIntoFlight;
                @TransformIntoBiped.started -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnTransformIntoBiped;
                @TransformIntoBiped.performed -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnTransformIntoBiped;
                @TransformIntoBiped.canceled -= m_Wrapper.m_PlayerBallActionsCallbackInterface.OnTransformIntoBiped;
            }
            m_Wrapper.m_PlayerBallActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @TransformIntoFlight.started += instance.OnTransformIntoFlight;
                @TransformIntoFlight.performed += instance.OnTransformIntoFlight;
                @TransformIntoFlight.canceled += instance.OnTransformIntoFlight;
                @TransformIntoBiped.started += instance.OnTransformIntoBiped;
                @TransformIntoBiped.performed += instance.OnTransformIntoBiped;
                @TransformIntoBiped.canceled += instance.OnTransformIntoBiped;
            }
        }
    }
    public PlayerBallActions @PlayerBall => new PlayerBallActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_TrackedDevicePosition;
    private readonly InputAction m_UI_TrackedDeviceOrientation;
    public struct UIActions
    {
        private @InputActions m_Wrapper;
        public UIActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerBipedActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnBombPress(InputAction.CallbackContext context);
        void OnBombRelease(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTransformIntoFlight(InputAction.CallbackContext context);
        void OnTransformIntoBall(InputAction.CallbackContext context);
        void OnTransformIntoBiped(InputAction.CallbackContext context);
        void OnResetLevel(InputAction.CallbackContext context);
        void OnShowControls(InputAction.CallbackContext context);
        void OnExitGame(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnInvertYCam(InputAction.CallbackContext context);
        void OnMoreSensibility(InputAction.CallbackContext context);
        void OnLessSensibility(InputAction.CallbackContext context);
        void OnInvertYFlight(InputAction.CallbackContext context);
    }
    public interface IPlayerFlightActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTransformIntoBiped(InputAction.CallbackContext context);
        void OnTransformIntoBall(InputAction.CallbackContext context);
    }
    public interface IPlayerBallActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnTransformIntoFlight(InputAction.CallbackContext context);
        void OnTransformIntoBiped(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
    }
}
