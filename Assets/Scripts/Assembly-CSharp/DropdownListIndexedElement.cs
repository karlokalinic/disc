using UnityEngine;
using UnityEngine.EventSystems;

public class DropdownListIndexedElement : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	[SerializeField]
	private DropDownAutoScrollSelection dropdownAuto;

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnSelected()
	{
	}
}
