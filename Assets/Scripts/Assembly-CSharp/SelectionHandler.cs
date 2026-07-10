using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class SelectionHandler : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	[SerializeField]
	private UnityEvent OnSelectEvent;

	[SerializeField]
	private UnityEvent OnDeselectEvent;

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}
}
