using System;
using System.Collections.Generic;
using UnityEngine;

namespace Sunshine.Metric
{
	public class InventoryItem : MonoBehaviour, IModifierCause, ITabbedSlottable<ItemTabGroup, InventoryItem>, IComparable<InventoryItem>
	{
		public string listName;

		public ItemType type;

		public ItemGroup group;

		public bool autoEquip;

		public bool cursed;

		public bool substance;

		public bool consumable;

		public bool multipleAllowed;

		public int itemValue;

		public bool fresh;

		public CharacterEffect[] equipEffects;

		public CharacterBuff[] substanceBuffs;

		public ItemType[] VisualHideItems;

		public string conversation;

		public HudHeldButton hudHeldButton;

		public int substanceUses;

		public string equipOrbName;

		public string alternativeEquipOrbName;

		private int _substanceTimeLeft;

		public string sound;

		public Sprite heldIcon;

		public string stackName;

		public List<InventoryItem> stackItems;

		public bool isVessel;

		public string tutorialText;

		public bool tutorialTextShown;

		public string displayName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string displayNameUpper => null;

		public string description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string displayNameTerm => null;

		public string descriptionTerm => null;

		public bool substanceActive => false;

		public int substanceTimeLeft
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isStackable => false;

		public string SubstanceTimeLeftLabel()
		{
			return null;
		}

		public string GetDisplayName()
		{
			return null;
		}

		public void UpdateUsesHud(int amount)
		{
		}

		public int CompareTo(InventoryItem other)
		{
			return 0;
		}

		public ItemTabGroup GetTab()
		{
			return default(ItemTabGroup);
		}

		public bool IsFresh()
		{
			return false;
		}
	}
}
