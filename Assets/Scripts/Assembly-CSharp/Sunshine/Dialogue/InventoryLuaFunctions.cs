using System.Collections;

namespace Sunshine.Dialogue
{
	public static class InventoryLuaFunctions
	{
		public static void Register()
		{
		}

		public static void GainItem(string itemName)
		{
		}

		public static void LoseItem(string itemName)
		{
		}

		public static void LoseGun()
		{
		}

		public static void LooseItem(string itemName)
		{
		}

		public static bool CheckItem(string itemName)
		{
			return false;
		}

		public static bool CheckEquipped(string itemName)
		{
			return false;
		}

		public static bool CheckEquippedGroup(string group)
		{
			return false;
		}

		public static bool CheckHeldLeftGroup(string group)
		{
			return false;
		}

		public static bool CheckHeldRightGroup(string group)
		{
			return false;
		}

		public static bool CheckItemGroup(string group)
		{
			return false;
		}

		public static void SellItemGroup(string group)
		{
		}

		public static void SellItemGroupWithModifier(string group, double modifier)
		{
		}

		public static bool SubstanceUsedOnce(string substance)
		{
			return false;
		}

		public static bool SubstanceUsedMore(string substance)
		{
			return false;
		}

		public static void ShowInventoryForPawning()
		{
		}

		public static bool HasPawnablesInInventory()
		{
			return false;
		}

		public static void UseSubstanceInHand(string hand)
		{
		}

		public static void UnequipAll()
		{
		}

		private static IEnumerator UnequipAllFadeToBlackCutscene()
		{
			return null;
		}
	}
}
