using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FortressOccident;
using Sunshine.Metric;
using UnityEngine;
using Voidforge;

public class World : SingletonComponent<World>
{
	private bool _isRunning;

	private bool _isStarting;

	public static Action OnCharacterCreated;

	public static Action OnResetWorldState;

	public SunshineCharacterTemplate youTemplate;

	public SunshineCharacterTemplate kimTemplate;

	[NonSerialized]
	public CharacterSheet kim;

	private ApplicationManager radiusQuickSingleton;

	public static bool IsLoadingLevel { get; private set; }

	public static bool RunningOrCollage => false;

	public static bool CollageMode => false;

	public bool isRunning => false;

	public CharacterSheet you { get; private set; }

	public event Action OnWorldStartsRunningCallback
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

	public event Action OnWorldStopsRunningCallbackStopOngoing
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

	public void StartWorld()
	{
	}

	public void StopWorld()
	{
	}

	public void SetCharacterForYou(CharacterSheet playerCharacterSheet)
	{
	}

	public bool IsInTequilaRadius(GameObject gameObject)
	{
		return false;
	}

	public bool IsInCameraRadius(GameObject gameObject)
	{
		return false;
	}

	protected override void Awake()
	{
	}

	public void CreateKim()
	{
	}

	public static void LoadStreamersCapAndLobby()
	{
	}

	public static void LoadLobby()
	{
	}

	public static IEnumerator NewGameCoR(bool showIntro = true, bool isActivity = false)
	{
		return null;
	}

	public static IEnumerator MidGameCoR(string areaId, string destinationId, bool startFromLobby)
	{
		return null;
	}

	public static void ResetStates()
	{
	}
}
