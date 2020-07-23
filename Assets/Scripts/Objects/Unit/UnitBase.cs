using System.Collections;
using System.Collections.Generic;
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

    }
}