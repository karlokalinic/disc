using FortressOccident;
using UnityEngine;
using UnityEngine.Events;

public class LockedDoorSwitcher : MonoBehaviour
{
	[TextArea]
	public string IsDoorLockedLua;

	public string VariableToSetOnTryLocked;

	public UnityEvent OnTryLockedDoor;

	private bool isDoorLocked;

	private MouseOverHighlight mouseOverHighlight;

	private TransitionEntity transitionEntity;

	private Door door;

	private const string HOURS_BETWEEN_FUNC = "IsHourBetween";

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPartyChanged()
	{
	}

	private void OnInventoryChange()
	{
	}

	private void OnTimeChange()
	{
	}

	private void OnVariableChange(string variable)
	{
	}

	private bool IsExpressionTrue()
	{
		return false;
	}

	private void ToggleDoorState(bool changeToLocked)
	{
	}

	private void AddOnInteractEvent(BasicEntity basicEntity)
	{
	}

	private void SetVariableOnTryLocked()
	{
	}

	public void KimBarkOtherWayIn()
	{
	}
}
