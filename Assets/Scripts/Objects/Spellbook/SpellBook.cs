using System;
using UnityEngine;

namespace CQ.LeagueOfLegends
{
    namespace Objects
    {
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

            // Kha`zix, Victor
            public bool EvolvSpell(ESpellSlot slot)
            {
                throw new NotImplementedException();
            }

            public bool LevelSpell(ESpellSlot slot)
            {
                throw new NotImplementedException();
            }

            public bool SpellSlotCanBeUpdated(ESpellSlot slot)
            {
                throw new NotImplementedException();
            }
        }
    }
}