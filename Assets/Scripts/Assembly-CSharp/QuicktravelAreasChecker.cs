using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sunshine.Journal;
using UnityEngine;

public class QuicktravelAreasChecker : MonoBehaviour
{
	public static Dictionary<string, QuicktravelMarker> quicktravelMarkersRegistry;

	private static List<QuicktravelMarker> quicktravelMarkersRegistryList;

	public static Dictionary<QuicktravelMarker, bool> quicktravelMarkersStates;

	private Coroutine processVisitedAreas;

	public static event Action<string> OnQuicktravelMarkerVisited
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
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

	public static void Register(QuicktravelMarker marker)
	{
	}

	public static void Unregister(QuicktravelMarker marker)
	{
	}

	private void StartProcessingVisitedAreas()
	{
	}

	private void StopProcessingVisitedAreas()
	{
	}

	private IEnumerator ProcessCharacterScheduleRegistry()
	{
		return null;
	}
}
