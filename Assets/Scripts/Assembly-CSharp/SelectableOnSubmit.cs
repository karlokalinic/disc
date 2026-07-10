using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class SelectableOnSubmit : Selectable, ISubmitHandler, IEventSystemHandler
{
	[SerializeField]
	private UnityEvent OnSubmitEvent;

	[SerializeField]
	private UnityEvent OnDeselectEvent;

	public void OnSubmit(BaseEventData eventData)
	{
	}

	public override void OnDeselect(BaseEventData eventData)
	{
	}
}
