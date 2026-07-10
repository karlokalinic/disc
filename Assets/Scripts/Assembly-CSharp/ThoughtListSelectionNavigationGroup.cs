using Sunshine;
using UnityEngine;
using UnityEngine.UI;

public class ThoughtListSelectionNavigationGroup : SelectionNavigationGroup
{
	[SerializeField]
	private AllThoughtsList allThoughtsList;

	public override Selectable SelectableToChangeTo => null;
}
