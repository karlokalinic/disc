using UnityEngine;
using UnityEngine.EventSystems;

public class UIInputField : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	public void OnDeselect(BaseEventData eventData)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	private void RegisterHighPriorityKeyListener()
	{
	}

	private void UnregisterHighPriorityKeyListener()
	{
	}
}
