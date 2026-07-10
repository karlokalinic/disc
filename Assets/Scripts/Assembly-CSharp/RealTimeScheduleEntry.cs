using System;

[Serializable]
public class RealTimeScheduleEntry : ScheduleEntry
{
	public bool doRealTimeFadeIn;

	public int realTimeFadeInSeconds;
}
