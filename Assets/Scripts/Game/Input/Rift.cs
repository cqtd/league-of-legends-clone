// GENERATED AUTOMATICALLY FROM 'Assets/Content/Settings/Input/Rift.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace CQ.LeagueOfLegends.Game
{
    public class @Rift : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Rift()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Rift"",
    ""maps"": [
        {
            ""name"": ""Spell"",
            ""id"": ""00728c57-279c-43b9-8b7a-90493222dbc1"",
            ""actions"": [
                {
                    ""name"": ""Spell1"",
                    ""type"": ""Button"",
                    ""id"": ""b1898db6-060b-4b86-bc36-15f0dd9a8e05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell2"",
                    ""type"": ""Button"",
                    ""id"": ""012c3658-5a3f-4370-985e-2fbe02d26738"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell3"",
                    ""type"": ""Button"",
                    ""id"": ""b3ab9774-1d2a-4317-bc7a-5d9fc219ba2b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Spell4"",
                    ""type"": ""Button"",
                    ""id"": ""7b427b08-b49c-4391-9bad-ad4f3e73b26b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpellSummoner1"",
                    ""type"": ""Button"",
                    ""id"": ""8d10ded4-1451-456c-bce4-aee296be6700"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpellSummoner2"",
                    ""type"": ""Button"",
                    ""id"": ""c60bb0f6-c4ce-44cf-8457-0acd3d3d1431"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpellRecall"",
                    ""type"": ""Button"",
                    ""id"": ""ee818719-fc46-4faa-b5df-99e5b98929d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpellEmote"",
                    ""type"": ""Button"",
                    ""id"": ""0ad11cff-d9ff-4be9-a160-aaa560dcc91d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""83befd6a-daf4-4546-a857-ff68a2c46939"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d77903c-0ae3-4653-8061-aeb702eac0bf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3133eff7-18e7-4f22-9826-650cef0daaba"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c990ee4-e760-43d6-b705-94e88bac5d2d"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spell4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f03fa93a-821d-4eff-a3f2-dfc3f88381e5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpellSummoner1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c7b2f8a-34d9-41f1-bda8-565c5557879c"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpellSummoner2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46093650-ba36-46f3-b7ef-66f3207a338b"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpellRecall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""feb912ea-b8df-4e62-bc55-f5dff17916ad"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpellEmote"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gameplay"",
            ""id"": ""e2d16d2d-fd83-4653-b73b-cc187a8e3de0"",
            ""actions"": [
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""6edc9347-7f34-42cf-ae10-9c0ba90d163e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stop"",
                    ""type"": ""Button"",
                    ""id"": ""38e907c6-7afd-4985-8b26-d85a15e8c6dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FocusHeroOnly"",
                    ""type"": ""Button"",
                    ""id"": ""398d9ce5-13c8-4cef-89c5-26126cd21759"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fcac673b-7c03-4d42-8bf4-f41d9f7132ca"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c740938d-1f75-48d6-b3db-f9c3c39ed6d0"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2cb1b5e-c624-4412-934a-8562f2c61bce"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ad9241f-b53e-46ed-ba67-041ffe05d41f"",
                    ""path"": ""<Keyboard>/backquote"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FocusHeroOnly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Item"",
            ""id"": ""318d7391-0402-47c4-a44a-38afe81d7ed4"",
            ""actions"": [
                {
                    ""name"": ""Item7"",
                    ""type"": ""Button"",
                    ""id"": ""0b5b8ec0-a0d6-48b1-98e1-9f3d6b07fc71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item6"",
                    ""type"": ""Button"",
                    ""id"": ""8e631aa0-27e0-45ca-8274-f68826b70172"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item5"",
                    ""type"": ""Button"",
                    ""id"": ""e66b5c14-d64b-4c51-8718-02b0a9776770"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trinket"",
                    ""type"": ""Button"",
                    ""id"": ""8935c42a-7f58-4a8a-9a69-f56ff273f8db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item3"",
                    ""type"": ""Button"",
                    ""id"": ""94ca71e1-ee8d-42de-ae13-0875fb9caeb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item2"",
                    ""type"": ""Button"",
                    ""id"": ""f97c29a4-dc82-4fe9-a093-538eddde30dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item1"",
                    ""type"": ""Button"",
                    ""id"": ""d3221ee4-f451-47c9-b6bb-4c2d5cc833cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a0c415e3-2184-4959-882e-92ced659beea"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""721b8d25-449a-4129-9d02-879b333cce1b"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acb408fb-6734-4a11-ad85-c1e3ad89526b"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9a07dce-dd63-4703-8868-a274a117f3fb"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trinket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84ee267f-1383-4125-83ee-00ec3bee0f9f"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""202254e0-36e9-4997-9ffa-733173fe611a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe5ef216-dded-4843-a75e-aed450aed8d4"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""34db29fe-f723-4e0a-ae3e-8f82a488b640"",
            ""actions"": [
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""51350e6c-1d41-4d8e-b498-603d3cd0b1bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scoreboard"",
                    ""type"": ""Button"",
                    ""id"": ""7060d6fd-632f-4503-942d-2b58e604762f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Chat"",
                    ""type"": ""Button"",
                    ""id"": ""5f349db6-47b9-4ed7-86ff-33c24305c879"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shop"",
                    ""type"": ""Button"",
                    ""id"": ""0612cf22-6996-492c-8151-1c4e39c177e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e8cc91ef-10c1-4b99-aa6f-ef94bbde5d53"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0613e398-45ee-4d67-9bbb-b10e21b756ff"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scoreboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fa783bf-0528-41de-a696-d23475e1749a"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Chat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98e5c2e0-fe67-4223-b928-540ae1175422"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Communication"",
            ""id"": ""c0200e60-4f65-418a-9f39-4efda465fcf9"",
            ""actions"": [
                {
                    ""name"": ""Ping"",
                    ""type"": ""Button"",
                    ""id"": ""a7357a60-25f2-4b4a-b297-1e486bb1a65e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Warn"",
                    ""type"": ""Button"",
                    ""id"": ""a92fe6c4-017d-4fb4-ae5e-163896531244"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""38f1658e-03b6-4e57-869f-9197e83c314a"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff1a637f-5352-4a64-b392-7fc0914974dc"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb5e0bf5-c977-4391-8010-a1c298611964"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Warn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64933fde-3fa8-4eb1-bf6e-264adef9231d"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Warn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""53ed03bd-8abd-4a8f-8b04-90b038bca4b4"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""019d7174-9793-452e-8821-af9cf375dfd0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""9f4d784a-e30c-4a38-b86a-052f6559f24b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3152ac0c-105b-435a-bf57-2b2895a0d48f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1aa6e063-c091-4150-b5a8-872a681d363f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""32484048-3e9c-4b0d-b6f7-2d80a620d158"",
            ""actions"": [
                {
                    ""name"": ""SetFocus"",
                    ""type"": ""Button"",
                    ""id"": ""6c88a722-517f-486a-9c80-f970d6b6a4b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleFocusLock"",
                    ""type"": ""Button"",
                    ""id"": ""d0a14fa2-05cc-43b5-a310-b0150ef78641"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""c03aab77-ef65-4545-b79d-1bef58c9f05f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""68d37e2a-bc13-43db-92bb-dd40f8fd7828"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""6bf770fd-75e4-422e-9603-2a404c22e8c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""018745c0-6a1d-4564-a5cd-1867f2b47184"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7a9ce70-bc41-4034-9fe2-26fa1a06843f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SetFocus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2d029df-fb18-4e34-a46e-a38f17d1aa52"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleFocusLock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""badc505f-446d-4845-a913-444657f38a20"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a09ce88-6aac-4192-84d4-bdb61f2b63a9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cdd2cb4-1066-4a74-89e1-d766ed23aea1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c260eb3d-c0d3-45d3-8caf-b5e95b40f022"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Spell
            m_Spell = asset.FindActionMap("Spell", throwIfNotFound: true);
            m_Spell_Spell1 = m_Spell.FindAction("Spell1", throwIfNotFound: true);
            m_Spell_Spell2 = m_Spell.FindAction("Spell2", throwIfNotFound: true);
            m_Spell_Spell3 = m_Spell.FindAction("Spell3", throwIfNotFound: true);
            m_Spell_Spell4 = m_Spell.FindAction("Spell4", throwIfNotFound: true);
            m_Spell_SpellSummoner1 = m_Spell.FindAction("SpellSummoner1", throwIfNotFound: true);
            m_Spell_SpellSummoner2 = m_Spell.FindAction("SpellSummoner2", throwIfNotFound: true);
            m_Spell_SpellRecall = m_Spell.FindAction("SpellRecall", throwIfNotFound: true);
            m_Spell_SpellEmote = m_Spell.FindAction("SpellEmote", throwIfNotFound: true);
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_Attack = m_Gameplay.FindAction("Attack", throwIfNotFound: true);
            m_Gameplay_Stop = m_Gameplay.FindAction("Stop", throwIfNotFound: true);
            m_Gameplay_FocusHeroOnly = m_Gameplay.FindAction("FocusHeroOnly", throwIfNotFound: true);
            // Item
            m_Item = asset.FindActionMap("Item", throwIfNotFound: true);
            m_Item_Item7 = m_Item.FindAction("Item7", throwIfNotFound: true);
            m_Item_Item6 = m_Item.FindAction("Item6", throwIfNotFound: true);
            m_Item_Item5 = m_Item.FindAction("Item5", throwIfNotFound: true);
            m_Item_Trinket = m_Item.FindAction("Trinket", throwIfNotFound: true);
            m_Item_Item3 = m_Item.FindAction("Item3", throwIfNotFound: true);
            m_Item_Item2 = m_Item.FindAction("Item2", throwIfNotFound: true);
            m_Item_Item1 = m_Item.FindAction("Item1", throwIfNotFound: true);
            // Menu
            m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
            m_Menu_Escape = m_Menu.FindAction("Escape", throwIfNotFound: true);
            m_Menu_Scoreboard = m_Menu.FindAction("Scoreboard", throwIfNotFound: true);
            m_Menu_Chat = m_Menu.FindAction("Chat", throwIfNotFound: true);
            m_Menu_Shop = m_Menu.FindAction("Shop", throwIfNotFound: true);
            // Communication
            m_Communication = asset.FindActionMap("Communication", throwIfNotFound: true);
            m_Communication_Ping = m_Communication.FindAction("Ping", throwIfNotFound: true);
            m_Communication_Warn = m_Communication.FindAction("Warn", throwIfNotFound: true);
            // Mouse
            m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
            m_Mouse_Left = m_Mouse.FindAction("Left", throwIfNotFound: true);
            m_Mouse_Right = m_Mouse.FindAction("Right", throwIfNotFound: true);
            // Camera
            m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
            m_Camera_SetFocus = m_Camera.FindAction("SetFocus", throwIfNotFound: true);
            m_Camera_ToggleFocusLock = m_Camera.FindAction("ToggleFocusLock", throwIfNotFound: true);
            m_Camera_Left = m_Camera.FindAction("Left", throwIfNotFound: true);
            m_Camera_Right = m_Camera.FindAction("Right", throwIfNotFound: true);
            m_Camera_Up = m_Camera.FindAction("Up", throwIfNotFound: true);
            m_Camera_Down = m_Camera.FindAction("Down", throwIfNotFound: true);
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

        // Spell
        private readonly InputActionMap m_Spell;
        private ISpellActions m_SpellActionsCallbackInterface;
        private readonly InputAction m_Spell_Spell1;
        private readonly InputAction m_Spell_Spell2;
        private readonly InputAction m_Spell_Spell3;
        private readonly InputAction m_Spell_Spell4;
        private readonly InputAction m_Spell_SpellSummoner1;
        private readonly InputAction m_Spell_SpellSummoner2;
        private readonly InputAction m_Spell_SpellRecall;
        private readonly InputAction m_Spell_SpellEmote;
        public struct SpellActions
        {
            private @Rift m_Wrapper;
            public SpellActions(@Rift wrapper) { m_Wrapper = wrapper; }
            public InputAction @Spell1 => m_Wrapper.m_Spell_Spell1;
            public InputAction @Spell2 => m_Wrapper.m_Spell_Spell2;
            public InputAction @Spell3 => m_Wrapper.m_Spell_Spell3;
            public InputAction @Spell4 => m_Wrapper.m_Spell_Spell4;
            public InputAction @SpellSummoner1 => m_Wrapper.m_Spell_SpellSummoner1;
            public InputAction @SpellSummoner2 => m_Wrapper.m_Spell_SpellSummoner2;
            public InputAction @SpellRecall => m_Wrapper.m_Spell_SpellRecall;
            public InputAction @SpellEmote => m_Wrapper.m_Spell_SpellEmote;
            public InputActionMap Get() { return m_Wrapper.m_Spell; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SpellActions set) { return set.Get(); }
            public void SetCallbacks(ISpellActions instance)
            {
                if (m_Wrapper.m_SpellActionsCallbackInterface != null)
                {
                    @Spell1.started -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell1;
                    @Spell1.performed -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell1;
                    @Spell1.canceled -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell1;
                    @Spell2.started -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell2;
                    @Spell2.performed -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell2;
                    @Spell2.canceled -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell2;
                    @Spell3.started -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell3;
                    @Spell3.performed -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell3;
                    @Spell3.canceled -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell3;
                    @Spell4.started -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell4;
                    @Spell4.performed -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell4;
                    @Spell4.canceled -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpell4;
                    @SpellSummoner1.started -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellSummoner1;
                    @SpellSummoner1.performed -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellSummoner1;
                    @SpellSummoner1.canceled -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellSummoner1;
                    @SpellSummoner2.started -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellSummoner2;
                    @SpellSummoner2.performed -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellSummoner2;
                    @SpellSummoner2.canceled -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellSummoner2;
                    @SpellRecall.started -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellRecall;
                    @SpellRecall.performed -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellRecall;
                    @SpellRecall.canceled -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellRecall;
                    @SpellEmote.started -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellEmote;
                    @SpellEmote.performed -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellEmote;
                    @SpellEmote.canceled -= m_Wrapper.m_SpellActionsCallbackInterface.OnSpellEmote;
                }
                m_Wrapper.m_SpellActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Spell1.started += instance.OnSpell1;
                    @Spell1.performed += instance.OnSpell1;
                    @Spell1.canceled += instance.OnSpell1;
                    @Spell2.started += instance.OnSpell2;
                    @Spell2.performed += instance.OnSpell2;
                    @Spell2.canceled += instance.OnSpell2;
                    @Spell3.started += instance.OnSpell3;
                    @Spell3.performed += instance.OnSpell3;
                    @Spell3.canceled += instance.OnSpell3;
                    @Spell4.started += instance.OnSpell4;
                    @Spell4.performed += instance.OnSpell4;
                    @Spell4.canceled += instance.OnSpell4;
                    @SpellSummoner1.started += instance.OnSpellSummoner1;
                    @SpellSummoner1.performed += instance.OnSpellSummoner1;
                    @SpellSummoner1.canceled += instance.OnSpellSummoner1;
                    @SpellSummoner2.started += instance.OnSpellSummoner2;
                    @SpellSummoner2.performed += instance.OnSpellSummoner2;
                    @SpellSummoner2.canceled += instance.OnSpellSummoner2;
                    @SpellRecall.started += instance.OnSpellRecall;
                    @SpellRecall.performed += instance.OnSpellRecall;
                    @SpellRecall.canceled += instance.OnSpellRecall;
                    @SpellEmote.started += instance.OnSpellEmote;
                    @SpellEmote.performed += instance.OnSpellEmote;
                    @SpellEmote.canceled += instance.OnSpellEmote;
                }
            }
        }
        public SpellActions @Spell => new SpellActions(this);

        // Gameplay
        private readonly InputActionMap m_Gameplay;
        private IGameplayActions m_GameplayActionsCallbackInterface;
        private readonly InputAction m_Gameplay_Attack;
        private readonly InputAction m_Gameplay_Stop;
        private readonly InputAction m_Gameplay_FocusHeroOnly;
        public struct GameplayActions
        {
            private @Rift m_Wrapper;
            public GameplayActions(@Rift wrapper) { m_Wrapper = wrapper; }
            public InputAction @Attack => m_Wrapper.m_Gameplay_Attack;
            public InputAction @Stop => m_Wrapper.m_Gameplay_Stop;
            public InputAction @FocusHeroOnly => m_Wrapper.m_Gameplay_FocusHeroOnly;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @Attack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Stop.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStop;
                    @Stop.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStop;
                    @Stop.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnStop;
                    @FocusHeroOnly.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFocusHeroOnly;
                    @FocusHeroOnly.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFocusHeroOnly;
                    @FocusHeroOnly.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnFocusHeroOnly;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                    @Stop.started += instance.OnStop;
                    @Stop.performed += instance.OnStop;
                    @Stop.canceled += instance.OnStop;
                    @FocusHeroOnly.started += instance.OnFocusHeroOnly;
                    @FocusHeroOnly.performed += instance.OnFocusHeroOnly;
                    @FocusHeroOnly.canceled += instance.OnFocusHeroOnly;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);

        // Item
        private readonly InputActionMap m_Item;
        private IItemActions m_ItemActionsCallbackInterface;
        private readonly InputAction m_Item_Item7;
        private readonly InputAction m_Item_Item6;
        private readonly InputAction m_Item_Item5;
        private readonly InputAction m_Item_Trinket;
        private readonly InputAction m_Item_Item3;
        private readonly InputAction m_Item_Item2;
        private readonly InputAction m_Item_Item1;
        public struct ItemActions
        {
            private @Rift m_Wrapper;
            public ItemActions(@Rift wrapper) { m_Wrapper = wrapper; }
            public InputAction @Item7 => m_Wrapper.m_Item_Item7;
            public InputAction @Item6 => m_Wrapper.m_Item_Item6;
            public InputAction @Item5 => m_Wrapper.m_Item_Item5;
            public InputAction @Trinket => m_Wrapper.m_Item_Trinket;
            public InputAction @Item3 => m_Wrapper.m_Item_Item3;
            public InputAction @Item2 => m_Wrapper.m_Item_Item2;
            public InputAction @Item1 => m_Wrapper.m_Item_Item1;
            public InputActionMap Get() { return m_Wrapper.m_Item; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(ItemActions set) { return set.Get(); }
            public void SetCallbacks(IItemActions instance)
            {
                if (m_Wrapper.m_ItemActionsCallbackInterface != null)
                {
                    @Item7.started -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem7;
                    @Item7.performed -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem7;
                    @Item7.canceled -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem7;
                    @Item6.started -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem6;
                    @Item6.performed -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem6;
                    @Item6.canceled -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem6;
                    @Item5.started -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem5;
                    @Item5.performed -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem5;
                    @Item5.canceled -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem5;
                    @Trinket.started -= m_Wrapper.m_ItemActionsCallbackInterface.OnTrinket;
                    @Trinket.performed -= m_Wrapper.m_ItemActionsCallbackInterface.OnTrinket;
                    @Trinket.canceled -= m_Wrapper.m_ItemActionsCallbackInterface.OnTrinket;
                    @Item3.started -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem3;
                    @Item3.performed -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem3;
                    @Item3.canceled -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem3;
                    @Item2.started -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem2;
                    @Item2.performed -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem2;
                    @Item2.canceled -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem2;
                    @Item1.started -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem1;
                    @Item1.performed -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem1;
                    @Item1.canceled -= m_Wrapper.m_ItemActionsCallbackInterface.OnItem1;
                }
                m_Wrapper.m_ItemActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Item7.started += instance.OnItem7;
                    @Item7.performed += instance.OnItem7;
                    @Item7.canceled += instance.OnItem7;
                    @Item6.started += instance.OnItem6;
                    @Item6.performed += instance.OnItem6;
                    @Item6.canceled += instance.OnItem6;
                    @Item5.started += instance.OnItem5;
                    @Item5.performed += instance.OnItem5;
                    @Item5.canceled += instance.OnItem5;
                    @Trinket.started += instance.OnTrinket;
                    @Trinket.performed += instance.OnTrinket;
                    @Trinket.canceled += instance.OnTrinket;
                    @Item3.started += instance.OnItem3;
                    @Item3.performed += instance.OnItem3;
                    @Item3.canceled += instance.OnItem3;
                    @Item2.started += instance.OnItem2;
                    @Item2.performed += instance.OnItem2;
                    @Item2.canceled += instance.OnItem2;
                    @Item1.started += instance.OnItem1;
                    @Item1.performed += instance.OnItem1;
                    @Item1.canceled += instance.OnItem1;
                }
            }
        }
        public ItemActions @Item => new ItemActions(this);

        // Menu
        private readonly InputActionMap m_Menu;
        private IMenuActions m_MenuActionsCallbackInterface;
        private readonly InputAction m_Menu_Escape;
        private readonly InputAction m_Menu_Scoreboard;
        private readonly InputAction m_Menu_Chat;
        private readonly InputAction m_Menu_Shop;
        public struct MenuActions
        {
            private @Rift m_Wrapper;
            public MenuActions(@Rift wrapper) { m_Wrapper = wrapper; }
            public InputAction @Escape => m_Wrapper.m_Menu_Escape;
            public InputAction @Scoreboard => m_Wrapper.m_Menu_Scoreboard;
            public InputAction @Chat => m_Wrapper.m_Menu_Chat;
            public InputAction @Shop => m_Wrapper.m_Menu_Shop;
            public InputActionMap Get() { return m_Wrapper.m_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
            public void SetCallbacks(IMenuActions instance)
            {
                if (m_Wrapper.m_MenuActionsCallbackInterface != null)
                {
                    @Escape.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnEscape;
                    @Escape.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnEscape;
                    @Escape.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnEscape;
                    @Scoreboard.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnScoreboard;
                    @Scoreboard.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnScoreboard;
                    @Scoreboard.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnScoreboard;
                    @Chat.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnChat;
                    @Chat.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnChat;
                    @Chat.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnChat;
                    @Shop.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnShop;
                    @Shop.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnShop;
                    @Shop.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnShop;
                }
                m_Wrapper.m_MenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Escape.started += instance.OnEscape;
                    @Escape.performed += instance.OnEscape;
                    @Escape.canceled += instance.OnEscape;
                    @Scoreboard.started += instance.OnScoreboard;
                    @Scoreboard.performed += instance.OnScoreboard;
                    @Scoreboard.canceled += instance.OnScoreboard;
                    @Chat.started += instance.OnChat;
                    @Chat.performed += instance.OnChat;
                    @Chat.canceled += instance.OnChat;
                    @Shop.started += instance.OnShop;
                    @Shop.performed += instance.OnShop;
                    @Shop.canceled += instance.OnShop;
                }
            }
        }
        public MenuActions @Menu => new MenuActions(this);

        // Communication
        private readonly InputActionMap m_Communication;
        private ICommunicationActions m_CommunicationActionsCallbackInterface;
        private readonly InputAction m_Communication_Ping;
        private readonly InputAction m_Communication_Warn;
        public struct CommunicationActions
        {
            private @Rift m_Wrapper;
            public CommunicationActions(@Rift wrapper) { m_Wrapper = wrapper; }
            public InputAction @Ping => m_Wrapper.m_Communication_Ping;
            public InputAction @Warn => m_Wrapper.m_Communication_Warn;
            public InputActionMap Get() { return m_Wrapper.m_Communication; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CommunicationActions set) { return set.Get(); }
            public void SetCallbacks(ICommunicationActions instance)
            {
                if (m_Wrapper.m_CommunicationActionsCallbackInterface != null)
                {
                    @Ping.started -= m_Wrapper.m_CommunicationActionsCallbackInterface.OnPing;
                    @Ping.performed -= m_Wrapper.m_CommunicationActionsCallbackInterface.OnPing;
                    @Ping.canceled -= m_Wrapper.m_CommunicationActionsCallbackInterface.OnPing;
                    @Warn.started -= m_Wrapper.m_CommunicationActionsCallbackInterface.OnWarn;
                    @Warn.performed -= m_Wrapper.m_CommunicationActionsCallbackInterface.OnWarn;
                    @Warn.canceled -= m_Wrapper.m_CommunicationActionsCallbackInterface.OnWarn;
                }
                m_Wrapper.m_CommunicationActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Ping.started += instance.OnPing;
                    @Ping.performed += instance.OnPing;
                    @Ping.canceled += instance.OnPing;
                    @Warn.started += instance.OnWarn;
                    @Warn.performed += instance.OnWarn;
                    @Warn.canceled += instance.OnWarn;
                }
            }
        }
        public CommunicationActions @Communication => new CommunicationActions(this);

        // Mouse
        private readonly InputActionMap m_Mouse;
        private IMouseActions m_MouseActionsCallbackInterface;
        private readonly InputAction m_Mouse_Left;
        private readonly InputAction m_Mouse_Right;
        public struct MouseActions
        {
            private @Rift m_Wrapper;
            public MouseActions(@Rift wrapper) { m_Wrapper = wrapper; }
            public InputAction @Left => m_Wrapper.m_Mouse_Left;
            public InputAction @Right => m_Wrapper.m_Mouse_Right;
            public InputActionMap Get() { return m_Wrapper.m_Mouse; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
            public void SetCallbacks(IMouseActions instance)
            {
                if (m_Wrapper.m_MouseActionsCallbackInterface != null)
                {
                    @Left.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeft;
                    @Left.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeft;
                    @Left.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnLeft;
                    @Right.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnRight;
                    @Right.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnRight;
                    @Right.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnRight;
                }
                m_Wrapper.m_MouseActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Left.started += instance.OnLeft;
                    @Left.performed += instance.OnLeft;
                    @Left.canceled += instance.OnLeft;
                    @Right.started += instance.OnRight;
                    @Right.performed += instance.OnRight;
                    @Right.canceled += instance.OnRight;
                }
            }
        }
        public MouseActions @Mouse => new MouseActions(this);

        // Camera
        private readonly InputActionMap m_Camera;
        private ICameraActions m_CameraActionsCallbackInterface;
        private readonly InputAction m_Camera_SetFocus;
        private readonly InputAction m_Camera_ToggleFocusLock;
        private readonly InputAction m_Camera_Left;
        private readonly InputAction m_Camera_Right;
        private readonly InputAction m_Camera_Up;
        private readonly InputAction m_Camera_Down;
        public struct CameraActions
        {
            private @Rift m_Wrapper;
            public CameraActions(@Rift wrapper) { m_Wrapper = wrapper; }
            public InputAction @SetFocus => m_Wrapper.m_Camera_SetFocus;
            public InputAction @ToggleFocusLock => m_Wrapper.m_Camera_ToggleFocusLock;
            public InputAction @Left => m_Wrapper.m_Camera_Left;
            public InputAction @Right => m_Wrapper.m_Camera_Right;
            public InputAction @Up => m_Wrapper.m_Camera_Up;
            public InputAction @Down => m_Wrapper.m_Camera_Down;
            public InputActionMap Get() { return m_Wrapper.m_Camera; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
            public void SetCallbacks(ICameraActions instance)
            {
                if (m_Wrapper.m_CameraActionsCallbackInterface != null)
                {
                    @SetFocus.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnSetFocus;
                    @SetFocus.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnSetFocus;
                    @SetFocus.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnSetFocus;
                    @ToggleFocusLock.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnToggleFocusLock;
                    @ToggleFocusLock.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnToggleFocusLock;
                    @ToggleFocusLock.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnToggleFocusLock;
                    @Left.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnLeft;
                    @Left.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnLeft;
                    @Left.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnLeft;
                    @Right.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRight;
                    @Right.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRight;
                    @Right.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRight;
                    @Up.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnUp;
                    @Up.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnUp;
                    @Up.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnUp;
                    @Down.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnDown;
                    @Down.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnDown;
                    @Down.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnDown;
                }
                m_Wrapper.m_CameraActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @SetFocus.started += instance.OnSetFocus;
                    @SetFocus.performed += instance.OnSetFocus;
                    @SetFocus.canceled += instance.OnSetFocus;
                    @ToggleFocusLock.started += instance.OnToggleFocusLock;
                    @ToggleFocusLock.performed += instance.OnToggleFocusLock;
                    @ToggleFocusLock.canceled += instance.OnToggleFocusLock;
                    @Left.started += instance.OnLeft;
                    @Left.performed += instance.OnLeft;
                    @Left.canceled += instance.OnLeft;
                    @Right.started += instance.OnRight;
                    @Right.performed += instance.OnRight;
                    @Right.canceled += instance.OnRight;
                    @Up.started += instance.OnUp;
                    @Up.performed += instance.OnUp;
                    @Up.canceled += instance.OnUp;
                    @Down.started += instance.OnDown;
                    @Down.performed += instance.OnDown;
                    @Down.canceled += instance.OnDown;
                }
            }
        }
        public CameraActions @Camera => new CameraActions(this);
        public interface ISpellActions
        {
            void OnSpell1(InputAction.CallbackContext context);
            void OnSpell2(InputAction.CallbackContext context);
            void OnSpell3(InputAction.CallbackContext context);
            void OnSpell4(InputAction.CallbackContext context);
            void OnSpellSummoner1(InputAction.CallbackContext context);
            void OnSpellSummoner2(InputAction.CallbackContext context);
            void OnSpellRecall(InputAction.CallbackContext context);
            void OnSpellEmote(InputAction.CallbackContext context);
        }
        public interface IGameplayActions
        {
            void OnAttack(InputAction.CallbackContext context);
            void OnStop(InputAction.CallbackContext context);
            void OnFocusHeroOnly(InputAction.CallbackContext context);
        }
        public interface IItemActions
        {
            void OnItem7(InputAction.CallbackContext context);
            void OnItem6(InputAction.CallbackContext context);
            void OnItem5(InputAction.CallbackContext context);
            void OnTrinket(InputAction.CallbackContext context);
            void OnItem3(InputAction.CallbackContext context);
            void OnItem2(InputAction.CallbackContext context);
            void OnItem1(InputAction.CallbackContext context);
        }
        public interface IMenuActions
        {
            void OnEscape(InputAction.CallbackContext context);
            void OnScoreboard(InputAction.CallbackContext context);
            void OnChat(InputAction.CallbackContext context);
            void OnShop(InputAction.CallbackContext context);
        }
        public interface ICommunicationActions
        {
            void OnPing(InputAction.CallbackContext context);
            void OnWarn(InputAction.CallbackContext context);
        }
        public interface IMouseActions
        {
            void OnLeft(InputAction.CallbackContext context);
            void OnRight(InputAction.CallbackContext context);
        }
        public interface ICameraActions
        {
            void OnSetFocus(InputAction.CallbackContext context);
            void OnToggleFocusLock(InputAction.CallbackContext context);
            void OnLeft(InputAction.CallbackContext context);
            void OnRight(InputAction.CallbackContext context);
            void OnUp(InputAction.CallbackContext context);
            void OnDown(InputAction.CallbackContext context);
        }
    }
}
