using TMPro;
using UnityEngine;
using UnityEngine.UI;
using CQ.LeagueOfLegends.Objects;

namespace CQ.LeagueOfLegends.UI
{
	public class UISpellSlot : MonoBehaviour
	{
		[SerializeField] Button main = default;
		[SerializeField] Button levelUp = default;
		
		[SerializeField] TextMeshProUGUI binding = default;
		[SerializeField] TextMeshProUGUI manaCost = default;
		
		[SerializeField] UISpellSlotLevel[] levels = new UISpellSlotLevel[0];

		public void Initialize(SpellData spellData)
		{
			
		}
	}
}