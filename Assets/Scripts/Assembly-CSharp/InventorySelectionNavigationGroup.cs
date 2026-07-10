using UnityEngine;
using UnityEngine.UI;

public class InventorySelectionNavigationGroup : SelectionNavigationGroup
{
	private enum WhichSlot
	{
		FirstOnLeft = 0,
		FirstOnRight = 1
	}

	[SerializeField]
	private WhichSlot whichSlot;

	public override Selectable SelectableToChangeTo => null;
}
