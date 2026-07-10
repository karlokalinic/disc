using System;

[Serializable]
public class SunshineClockTime : IComparable
{
	public const int MINUTES_IN_A_DAY = 1440;

	private int dayMinutes;

	private int dayCounter;

	private int seconds;

	private int midnightResetDayCounter;

	private const int stopTickingHour = 2;

	private bool isTimeLocked;

	public bool IsTimeLocked => false;

	public int TotalHours => 0;

	public int TotalMinutes => 0;

	public int DayMinutes
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int DayCounter
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int RealDayCounter
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Hours
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Minutes
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Seconds
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Daytime Daytime => default(Daytime);

	public bool IsNight => false;

	public bool IsDay => false;

	public SunshineClockTime(int hours = 0, int minutes = 0)
	{
	}

	public SunshineClockTime(SunshineClockTime time)
	{
	}

	public Daytime GetDaytime()
	{
		return default(Daytime);
	}

	public DayOfWeek GetDayOfWeek()
	{
		return default(DayOfWeek);
	}

	public string ToDayHourString()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private void LockTimeIfNeed()
	{
	}

	public void UnlockTime()
	{
	}

	public void ForceUnlockTime()
	{
	}
}
