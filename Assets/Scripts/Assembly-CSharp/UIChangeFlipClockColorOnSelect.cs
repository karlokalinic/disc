using UnityEngine;
using UnityEngine.EventSystems;

public class UIChangeFlipClockColorOnSelect : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	[SerializeField]
	private FlipClock targetFlipClock;

	[SerializeField]
	private Color selectColor;

	[SerializeField]
	private Color deselectColor;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	void ISelectHandler.OnSelect(BaseEventData eventData)
	{
	}

	void IDeselectHandler.OnDeselect(BaseEventData eventData)
	{
	}

	private void InputHotplugHandler_OnDeviceChanged(string deviceName, InputHotplugHandler.InputDeviceType deviceType)
	{
	}

	private void SetColorStateBasedOnbool(bool isGamepadUsed)
	{
	}

	private void SetColorBasedOnCurrentlySelected()
	{
	}
}
