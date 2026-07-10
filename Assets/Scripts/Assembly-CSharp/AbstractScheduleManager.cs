using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractScheduleManager : MonoBehaviour
{
	public static HashSet<GameObject> scheduledObjects;

	public virtual Dictionary<GameObject, Bounds> CharacterBounds { get; }

	public abstract GameObject GetScheduledObject();

	public abstract void LoadEntityByTimeOfDay(bool immediately);
}
