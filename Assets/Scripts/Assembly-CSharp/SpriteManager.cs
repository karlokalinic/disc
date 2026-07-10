using System.Collections.Generic;
using UnityEngine;

public static class SpriteManager
{
	public const string EQUIPMENT_SLOT_EMPTY = "slot/equ_empty";

	public const string EQUIPMENT_SLOT_FILLED = "slot/equ_filled";

	public const string EQUIPMENT_SLOT_FILLED_UNAVAILABLE = "slot/equ_filled_unavailable";

	public const string EQUIPMENT_SLOT_FRESH = "slot/equ_fresh";

	public const string EQUIPMENT_SLOT_FRESH_UNAVAILABLE = "slot/equ_fresh_unavailable";

	public const string EQUIPMENT_SLOT_UNAVAILABLE = "slot/equ_unavailable";

	public const string INVENTORY_SLOT_EMPTY = "slot/inv_empty";

	public const string INVENTORY_SLOT_FILLED = "slot/inv_filled";

	public const string INVENTORY_SLOT_FRESH = "slot/inv_fresh";

	public const string INVENTORY_ITEM_ICONS = "inventory_icons/";

	public const string THC_SLOT_BUYABLE_NOT = "slot/buyableX";

	public const string THC_SLOT_BUYABLE_1 = "slot/buyable1";

	public const string THC_SLOT_BUYABLE_2 = "slot/buyable2";

	public const string THC_SLOT_BUYABLE_3 = "slot/buyable3";

	public const string THC_SLOT_OPEN_OLD = "slot/openold";

	public const string THC_SLOT_OPEN = "slot/open";

	public const string THC_SLOT_CLOSED = "slot/closed";

	public const string THC_SLOT_FIXED = "slot/fixed";

	public const string THC_SLOT_FIXED_FRESH = "slot/fixedFresh";

	public const string THC_SLOT_FRESH = "slot/fresh";

	public const string THOUGHT_SLOT_INVENTORY = "slot/thoughtInventory";

	public const string THOUGHT_SLOT_FRESH_INVENTORY = "slot/freshInventory";

	private static Dictionary<string, Sprite> cachedSprites;

	public static Sprite GetSprite(string itemName)
	{
		return null;
	}
}
