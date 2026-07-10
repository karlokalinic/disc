using FortressOccident;
using UnityEngine;

public class KimDoor : Door
{
	public static KimDoor singleton;

	public Transform frontOfDoor;

	public Transform backOfDoor;

	private bool LuaConditionsToStartConversationWithKimWhirlingDoors => false;

	private bool IsNightAfter3rdDay => false;

	public bool CanPlayPost3rdDayKimDoorDialogue => false;

	protected override void OnAwakeInitialized()
	{
	}

	protected override void OnSceneActivated()
	{
	}

	protected override void OnSceneDeactivated()
	{
	}

	public override void OnUse(Transform user = null)
	{
	}

	public static void CloseDoor()
	{
	}

	public override bool Interact(ClickEventData data)
	{
		return false;
	}

	protected override bool CanPlayDialogue()
	{
		return false;
	}

	private void PrintOutKimDoorsDialogConditions()
	{
	}
}
