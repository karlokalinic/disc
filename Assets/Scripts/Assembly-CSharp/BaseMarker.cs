using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMarker : MonoBehaviour
{
	public static List<BaseMarker> instances;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public abstract void TryArriveHere();

	public static void OnArrival(SpawnType spawnType)
	{
	}

	public static void OnGameLoaded()
	{
	}

	private static void ArriveAtLastKimMarker(WaitLocation location)
	{
	}

	private static void ArriveAtLastCunoMarker(CunoWaitLocation location)
	{
	}
}
