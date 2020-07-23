using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CQ.LeagueOfLegends
{
    namespace Spellbook
    {
        public enum ESpellState
        {
            Ready = 0,
            NotAvailable = 4,
            Surpressed = 8,
            NotLearned = 12,
            Cooldown = 32,
            NoMana = 64,
            Unknown
        }
        
        public enum ESpellSlot
        {
            Unknown = -1,
            Q = 0,
            W = 1,
            E = 2,
            R = 3,
            Summoner1 = 4,
            Summoner2 = 5,
            Item1 = 6,
            Item2 = 7,
            Item3 = 8,
            Item4 = 9,
            Item5 = 10,
            Item6 = 11,
            Trinket = 12,
            Recall = 13
        };
        
        public class SpellBook : MonoBehaviour
        {
            public ESpellState CanUseSpell(ESpellSlot spellSlot)
            {
                throw new NotImplementedException();
            }
            
            public bool CastSpell(ESpellSlot slot, Vector3 from, Vector3 to, bool triggerEvent)
            {
                throw new NotImplementedException();
            }

            public bool CastSpell(ESpellSlot slot, Vector3 from, Vector3 to, UnitBase target, bool triggerEvent)
            {
                throw new NotImplementedException();
            }

            public bool CastSpell(ESpellSlot slot, bool triggerEvent = false)
            {
                throw new NotImplementedException();
            }
            
            public bool CastSpell(ESpellSlot slot, UnitBase target, bool triggerEvent = false)
            {
                throw new NotImplementedException();
            }
            
            public bool CastSpell(ESpellSlot slot, Vector3 position, bool triggerEvent = false)
            {
                throw new NotImplementedException();
            }


            public bool EvolvSpell(ESpellSlot slot)
            {
                throw new NotImplementedException();
            }

            public bool LevelSpell(ESpellSlot slot)
            {
                throw new NotImplementedException();
            }
        }
    }
}