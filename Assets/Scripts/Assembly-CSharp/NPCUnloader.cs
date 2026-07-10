using System.Collections;
using System.Collections.Generic;
using FortressOccident;
using UnityEngine;

public class NPCUnloader : MonoBehaviour
{
	public static List<AbstractScheduleManager> characterScheduleRegistry;

	public static List<SenseOrb> usedOrbs;

	public static List<SenseOrb> unusedOrbs;

	public static List<BasicEntity> basicEntityRegistry;

	public static Queue<MonoBehaviour> activationQueue;

	private static Rect viewportRect;

	private Coroutine updateActiveOrbsOnceCor;

	private Coroutine processSenseOrbRegistryCor;

	private const int NPCPerFrame = 30;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public static bool GetStateBasedOnPosition(Vector3 pos)
	{
		return false;
	}

	public static bool GetStateBasedOnBounds(Plane[] planes, Dictionary<GameObject, Bounds> b)
	{
		return false;
	}

	public static bool GetStateBasedOnBounds(Plane[] planes, Bounds b)
	{
		return false;
	}

	public static bool GetStateBasedOnSphere(Plane[] planes, Vector3 position, float radius)
	{
		return false;
	}

	public void StartUpdatingActiveOrbsOnce()
	{
	}

	private void StartProcessingOrbs()
	{
	}

	public static void ForceUpdateCharacterSchedulers()
	{
	}

	private void StopProcessingOrbs()
	{
	}

	private IEnumerator ProcessCharacterScheduleRegistry(bool instant = false)
	{
		return null;
	}

	private IEnumerator ProcessSenseOrbRegistry(bool instant = false)
	{
		return null;
	}

	private IEnumerator UpdateActiveOrbsOnce()
	{
		return null;
	}

	private IEnumerator ProcessBasicEntityRegistry(bool instant = false)
	{
		return null;
	}
}
