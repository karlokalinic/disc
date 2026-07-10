using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class ScheduleManager<T, S> : AbstractScheduleManager where T : Component where S : ScheduleEntry
{
	public const string CLONE_PREFIX = "(Clone)";

	private const int BoundsPaddingScaling = 3;

	public List<S> schedule;

	public T character;

	public int fakeTimeOfDay;

	public int fakeDay;

	public bool IgnoreProximity;

	public bool NeverUnload;

	private Scene sourceScene;

	private ScheduleEntry currentlyActiveSchedule;

	private AreaStatePersistence areaStatePersistence;

	public static List<AbstractScheduleManager> loadingQueue;

	private static Coroutine loadingQueueProcessor;

	private T _NPC;

	private Dictionary<GameObject, Bounds> _characterBounds;

	public override Dictionary<GameObject, Bounds> CharacterBounds => null;

	private void Awake()
	{
	}

	private void OnSceneActivated()
	{
	}

	private void OnSceneDeactivated()
	{
	}

	protected void OnDestroy()
	{
	}

	private bool AttachToAreaChange()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void LoadEntityImmediately()
	{
	}

	private void LoadEntityWhenOutOfSight()
	{
	}

	private void LoadEntityWhenOutOfSight(string changedVariableName)
	{
	}

	public static IEnumerator LoadingQueueProcessor()
	{
		return null;
	}

	public override void LoadEntityByTimeOfDay(bool loadImmediately)
	{
	}

	private T FindNPC()
	{
		return null;
	}

	private void SpawnNPC(T NPC, S scheduleEntry, bool loadImmediately)
	{
	}

	protected virtual void PlaceNPC(T NPC, S scheduleEntry)
	{
	}

	private void DeSpawnNPC(T NPC, bool loadImmediately)
	{
	}

	private int getCurrentDay()
	{
		return 0;
	}

	private int getCurrentHour()
	{
		return 0;
	}

	private int getCurrentMinute()
	{
		return 0;
	}

	public bool ValidateScheduleConditions(S scheduleEntry)
	{
		return false;
	}

	private bool CheckTime(S scheduleEntry, int hour, int minute)
	{
		return false;
	}

	private T InstantiateNPC()
	{
		return null;
	}

	private IEnumerator WaitUntilOutOfSightAndDestroy(T npc)
	{
		return null;
	}

	private void DestroyObject(T npc)
	{
	}

	private void SetNPCPositionAndProperties(T NPC, S scheduleEntry, bool overrideDialogue = true)
	{
	}

	public override GameObject GetScheduledObject()
	{
		return null;
	}

	private void GenerateBoundsForAllPositions()
	{
	}

	public void InitBounds(GameObject location, bool force = false)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
