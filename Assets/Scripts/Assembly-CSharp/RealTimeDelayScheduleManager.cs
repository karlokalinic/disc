using System.Collections;
using UnityEngine;

public class RealTimeDelayScheduleManager : ScheduleManager<RectTransform, RealTimeScheduleEntry>
{
	public override void LoadEntityByTimeOfDay(bool loadImmediately)
	{
	}

	protected override void PlaceNPC(RectTransform scheduledObject, RealTimeScheduleEntry scheduleEntry)
	{
	}

	private IEnumerator WaitAndPlaceCOR(RectTransform scheduledObject, RealTimeScheduleEntry scheduleEntry)
	{
		return null;
	}
}
