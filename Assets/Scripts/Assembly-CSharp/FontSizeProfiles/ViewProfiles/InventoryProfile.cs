using System;
using System.Collections.Generic;
using FontSizeProfiles.BuildParts;

namespace FontSizeProfiles.ViewProfiles
{
	[Serializable]
	public class InventoryProfile : ViewProfile
	{
		public TextElementSettings menuTitle;

		public TextElementSettings equippedTitle;

		public TextElementSettings equippedItemSlot;

		public AutoTextElementSettings autoItemName;

		public TextElementSettings itemEffect;

		public TextElementSettings itemPrice;

		public TextElementSettings itemDescription;

		public TextElementSettings itemsTabLabels;

		public TextElementSettings itemPawnShowClose;

		public TextElementSettings tooltipTitle;

		public TextElementSettings tooltipText;

		public override Dictionary<string, ElementSettings> GetAllTextElements()
		{
			return null;
		}
	}
}
