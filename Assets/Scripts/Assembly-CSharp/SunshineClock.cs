using System;
using Voidforge;

public class SunshineClock : SingletonClass<SunshineClock>
{
	private SunshineClockTime time;

	private SunshineClockTime timeOverride;

	private const int TICKTIME = 1;

	private const int CLANGTIME = 15;

	private const int SECONDS_PER_DIALOGUE_LINE = 23;

	public static readonly SunshineClockTime hangoverStartTime;

	public static readonly SunshineClockTime debugStartTime;

	public static readonly SunshineClockTime wakeupTime;

	public static readonly SunshineClockTime tirednessTime;

	public static readonly SunshineClockTime kimWorriedTime;

	private Action OnTimeChangeCallback;

	private Action OnTimeNormalForward;

	public SunshineClockTime Time => null;

	public bool HasOverride => false;

	public void SetOverride(SunshineClockTime overrideTime)
	{
	}

	public void ClearOverride()
	{
	}

	public void Tick()
	{
	}

	public void Clang()
	{
	}

	public void UnlockTime()
	{
	}

	public void NormalTimeForward(int amount, bool wasSleeping)
	{
	}

	public void MoveTimeFromDialogue()
	{
	}

	private void ApplyTimeForwardEffects(int minutes, bool wasSleeping)
	{
	}

	public void SetTime(int hours, int minutes)
	{
	}

	public void SetTime(SunshineClockTime newTime)
	{
	}

	public void SetDay(int dayNumber)
	{
	}

	public void SetDayReal(int dayNumber)
	{
	}

	public void NextMorning()
	{
	}

	public void SetTimeOverride(int hours, int minutes)
	{
	}

	public void UpdateVisualsAndInvokeCallbacks(bool updateVisualsImmediately, bool fireEvents)
	{
	}

	public void RegisterOnTimeChangeCallback(Action callback, bool isEvent)
	{
	}

	public void UnregisterOnTimeChangeCallback(Action callback, bool isEvent)
	{
	}

	public SunshineClockTime GetTimeForSaving()
	{
		return null;
	}

	public SunshineClockTime GetTimeOverrideForSaving()
	{
		return null;
	}

	public void SetTimeAfterLoading(SunshineClockTimePersister.PersistenceClockTime time, SunshineClockTimePersister.PersistenceClockTime timeOverride)
	{
	}
}
