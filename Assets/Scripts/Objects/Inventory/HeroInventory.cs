using System;
using System.Collections.Generic;
using UnityEngine;

namespace CQ.LeagueOfLegends.Objects
{
	public class HeroInventory : MonoBehaviour
	{
		public bool BuyItem(int itemID)
		{
			throw new NotImplementedException();
		}

		public bool SellItem(int itemID)
		{
			throw new NotImplementedException();
		}

		public bool SwapItem(int sourceSlotID, int destSlotID)
		{
			throw new NotImplementedException();
		}

		public void Undo()
		{
			throw new NotImplementedException();
		}

		public List<InventorySlot> GetInventory()
		{
			throw new NotImplementedException();
		}

		public InventorySlot GetInventorySlot(int slot)
		{
			throw new NotImplementedException();
		}

		public InventorySlot GetItemInfo(int itemID)
		{
			throw new NotImplementedException();
		}
	}
}