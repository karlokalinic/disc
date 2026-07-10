using UnityEngine;
using UnityEngine.EventSystems;

public class UIActivateObjectOnSelect : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	[SerializeField]
	private GameObject objectToActivate;

	private void Reset()
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}
}
