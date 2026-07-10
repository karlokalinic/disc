using FortressOccident;
using PixelCrushers.DialogueSystem;
using Sunshine.Metric;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class PortraitVisualizer : MonoBehaviour
{
	public static PortraitVisualizer youPortrait;

	[SerializeField]
	private Sprite timeoutSprite;

	[SerializeField]
	private SegmentIndicator volition;

	[SerializeField]
	private SegmentIndicator endurance;

	public Image portrait;

	public SubstanceVisualizer substanceVisualizer;

	public Character characterReference;

	public PortraitNotificationManager portraitNotificationManager;

	public string actorName;

	public string prevActorName;

	private bool isAsyncPrepared;

	private CharacterSheet characterSheet;

	private AsyncOperationHandle<Sprite> spriteHandle;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnGameModeChanged(GameModeController.GameMode mode)
	{
	}

	public void RemoveSubstanceOnStart()
	{
	}

	public void Refresh()
	{
	}

	public TimedIndicator IndicateVolitionTimeout(float timer)
	{
		return null;
	}

	public TimedIndicator IndicateEnduranceTimeout(float timer)
	{
		return null;
	}

	private void RefreshStats()
	{
	}

	private void RefreshActorImage()
	{
	}

	private void SetKitsuragiPortrait(DialogueDatabase db)
	{
	}

	private void SetTequilaPortrait()
	{
	}

	private void SetPortrait(AsyncOperationHandle<Sprite> portraitHandle)
	{
	}

	private void UnloadPortraitAsync()
	{
	}

	private void RefreshSubstances()
	{
	}
}
