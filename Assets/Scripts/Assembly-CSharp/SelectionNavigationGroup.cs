using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectionNavigationGroup : Selectable
{
	[SerializeField]
	protected Selectable selectableToChangeTo;

	public virtual Selectable SelectableToChangeTo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void OnSelect(BaseEventData eventData)
	{
	}
}
