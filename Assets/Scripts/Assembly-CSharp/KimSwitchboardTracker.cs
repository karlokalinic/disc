using System.Collections.Generic;
using PixelCrushers.DialogueSystem;

public class KimSwitchboardTracker : LiteSingleton<KimSwitchboardTracker>
{
	private const string KIM_DIALOGUE_NAME = "WHIRLING / KIM MAIN";

	private static Dictionary<string, DialogueEntry> switchEntryList;

	private static bool listenersRegistered;

	private static bool upcomingHighlight;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void FindSwitchboardElements()
	{
	}

	public static bool IsKimSwitchAvailable(string booleanName)
	{
		return false;
	}

	public void ClearSwitchboardElements()
	{
	}

	public void CheckForKimHighlight()
	{
	}

	public bool AutoStartAvailableKimSwitchDialogue(KimSwitchBoolean[] kimSwitches)
	{
		return false;
	}

	private static void VariableChanged(string varname)
	{
	}

	private void OnInventoryChanged()
	{
	}

	private static void ScheduleKimHighlight()
	{
	}

	private static void ClearKimHighlight()
	{
	}

	private static void ScheduledHighlight()
	{
	}
}
