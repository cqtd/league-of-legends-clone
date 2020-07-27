using System;
using System.Collections;
using System.Collections.Generic;
using CQ.LeagueOfLegends.Unit;
using UnityEngine;

namespace CQ.LeagueOfLegends
{
    namespace Unit
    {
        public enum EUnitTeam
        {
            Unknown = 0,
            Order = 100,
            Chaos = 200,
            Neutral = 300
        }
        
        public enum EUnitType
        {
            NeutralMinionCamp,
            obj_AI_Base,
            FollowerObject,
            FollowerObjectWithLerpMovement,
            AIHeroClient,
            obj_AI_Marker,
            obj_AI_Minion,
            LevelPropAI,
            obj_AI_Turret,
            obj_GeneralParticleEmitter,
            MissileClient,
            DrawFX,
            UnrevealedTarget,
            obj_LampBulb,
            obj_Barracks,
            obj_BarracksDampener,
            obj_AnimatedBuilding,
            obj_Building,
            obj_Levelsizer,
            obj_NavPoint,
            obj_SpawnPoint,	
            obj_Lake, 
            obj_HQ,
            obj_InfoPoint,
            LevelPropGameObject,
            LevelPropSpawnerPoint,
            obj_Shop,
            obj_Turret,
            GrassObject,
            obj_Ward,
            GameObject,
            Unknown
        }
    }
    
    public abstract class UnitBase : MonoBehaviour
    {
        [Header("UnitBase")]
        
        [ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
        [SerializeField] protected EUnitType unitType = EUnitType.Unknown;

        [ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
        [SerializeField] protected int index = -1;

        [ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
        [SerializeField] protected int networkId = -1;

        [ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
        [SerializeField] protected bool isAlive = false;

        [ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
        [SerializeField] protected EUnitTeam team = EUnitTeam.Unknown;

        [ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
        [SerializeField] protected bool isVisible = false;

        [ReadOnly(EReadOnlyType.EDITABLE_RUNTIME)]
        [SerializeField] protected bool isVisibleOnScreen = false;
        
        public EUnitType GetUnitType()
        {
            return this.unitType;
        }

        public int GetIndex()
        {
            return this.index;
        }

        public int GetNetworkId()
        {
            return this.networkId;
        }

        public Vector3 GetPosition()
        {
            return this.transform.position;
        }

        public bool IsDead()
        {
            return !this.isAlive;
        }

        public EUnitTeam GetTeam()
        {
            return this.team;
        }

        public bool IsVisible()
        {
            return this.isVisible;
        }

        public bool IsVisibleOnScreen()
        {
            return this.isVisibleOnScreen;
        }
    }
}